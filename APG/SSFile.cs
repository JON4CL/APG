using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Xml.Linq;

namespace APG
{
    class SSFile
    {
        private ImageFormat imageFormat;
        private ScreenResolution imageResolution;
        private int imageCaptureTime;
        private int imagesCaptured;
        private List<SSFrame> fileFrames;
        //private long 

        public SSFile()
        {
            this.imageFormat = ImageFormat.Jpeg;
            this.imageResolution = new ScreenResolution(0,0);
            this.imageCaptureTime = 0;
            this.imagesCaptured = 0;
            this.fileFrames = new List<SSFrame>();
        }

        internal string GetLatestModificationTime()
        {
            throw new NotImplementedException();
        }

        internal string GetImageType()
        {
            throw new NotImplementedException();
        }

        internal string GetImageResolution()
        {
            throw new NotImplementedException();
        }

        internal string GetCreationTime()
        {
            throw new NotImplementedException();
        }

        public SSFile(Stream streamFile)
        {
            //UNCOMPRESS THE XML DATA FILE
            using (ZipArchive archive = new ZipArchive(streamFile, ZipArchiveMode.Read, true))
            {
                ZipArchiveEntry xmlFileEntry = archive.GetEntry("ssfile.xml");
                using (Stream xmlFileStream = xmlFileEntry.Open())
                {
                    try { 
                        XDocument xd = XDocument.Load(xmlFileStream);
                        this.imageFormat = (ImageFormat)(new ImageFormatConverter()).ConvertFromString(xd.Root.Element("IMAGEFORMAT").Value);
                        this.imageResolution = new ScreenResolution(xd.Root.Element("IMAGERESOLUTION").Value);
                        this.imageCaptureTime = int.Parse(xd.Root.Element("IMAGECAPTURETIME").Value);
                        this.imagesCaptured = int.Parse(xd.Root.Element("FRAMES").Attribute("COUNT").Value);
                        this.fileFrames = new List<SSFrame>();
                        IEnumerable<XElement> elements = xd.Root.Element("FRAMES").Elements("FRAME");
                        foreach(var frame in elements)
                        {
                            this.fileFrames.Add(new SSFrame(int.Parse(frame.Attribute("ID").Value), frame.Attribute("DATA").Value));
                        }
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                }
            }
        }

        private XDocument ToXDocument()
        {
            //ROOT
            XElement root = new XElement("SS_FILE");
            root.Add(new XElement("IMAGEFORMAT", this.imageFormat.ToString()));
            root.Add(new XElement("IMAGERESOLUTION", this.imageResolution.ToString()));
            root.Add(new XElement("IMAGECAPTURETIME", this.imageCaptureTime.ToString()));
            //FRAMELIST
            XElement frames = new XElement("FRAMES");
            frames.SetAttributeValue("COUNT", this.imagesCaptured);
            foreach (SSFrame frame in fileFrames)
            {
                //FRAME
                XElement frameElement = new XElement("FRAME");
                frameElement.SetAttributeValue("ID", frame.GetFrameId().ToString());
                frameElement.SetAttributeValue("DATA", frame.GetFrameData());
                frames.Add(frameElement);
            }
            root.Add(frames);
            XDocument ssFile = new XDocument();
            ssFile.Add(root);
            return ssFile;
        }

        public bool SaveToAPGFile(String filePath)
        {
            XDocument ssFile = ToXDocument();
            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (ZipArchive archive = new ZipArchive(memoryStream, ZipArchiveMode.Create, true))
                {
                    ZipArchiveEntry xmlFile = archive.CreateEntry("ssfile.xml", CompressionLevel.Optimal);
                    using (Stream entryStream = xmlFile.Open())
                    {
                        using (StreamWriter streamWriter = new StreamWriter(entryStream))
                        {
                            streamWriter.Write("<?xml version=\"1.0\" encoding=\"utf-8\"?>" + System.Environment.NewLine + ssFile.ToString());
                        }
                    }
                }

                using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                {
                    memoryStream.Seek(0, SeekOrigin.Begin);
                    memoryStream.CopyTo(fileStream);
                }
            }

            return true;
        }

        public bool SaveToXmlFile(String filePath)
        {
            XDocument ssFile = ToXDocument();
            ssFile.Save(filePath);
            return true;
        }

        public void Capture(int imageCaptureRepetitions, int imageCaptureTime, ImageFormat imageFormat)
        {
            System.Threading.Thread.Sleep(1000);
            this.imageFormat = imageFormat;
            Image imageResolution = ScreenCapture.CaptureDesktop();
            this.imageResolution = new ScreenResolution(imageResolution.Height, imageResolution.Width);
            this.imageCaptureTime = imageCaptureTime;
            this.imagesCaptured = imageCaptureRepetitions;

            for (int i = 0; i < imageCaptureRepetitions; i++)
            {
                using (Image image = ScreenCapture.CaptureDesktop())
                {
                    fileFrames.Add(new SSFrame(i, ImageTools.ImageToBase64(image, imageFormat)));
                }
                System.Threading.Thread.Sleep(imageCaptureTime);
            }
        }

        public int GetFramesCount()
        {
            return this.imagesCaptured;
        }

        public SSFrame GetFrameById(int id)
        {
            return this.fileFrames.Find(
                delegate (SSFrame frame)
                {
                    return frame.GetFrameId() == id;
                }
            );
        }

        public int GetTimeWaitBetweenFrames()
        {
            return this.imageCaptureTime;
        }
    }

    internal class SSFrame
    {
        private int frameId;
        private String frameData;

        public SSFrame(int frameId, String frameData)
        {
            this.frameId = frameId;
            this.frameData = frameData;
        }

        public int GetFrameId()
        {
            return this.frameId;
        }

        public String GetFrameData()
        {
            return this.frameData;
        }
    }

    internal class ScreenResolution
    {
        int height;
        int width;

        public ScreenResolution(int height, int width)
        {
            if (height > 0)
            {
                this.height = height;
            }
            else
            {
                this.height = 0;
            }

            if (width > 0)
            {
                this.width = width;
            }
            else
            {
                this.width = 0;
            }
        }

        public ScreenResolution(String resolution)
        {
            String[] resolutionData = resolution.ToUpper().Split('X');
            this.height = int.Parse(resolutionData[0]);
            this.width = int.Parse(resolutionData[1]);
        }

        public override string ToString()
        {
            return this.height.ToString() + "x" + this.width.ToString();
        }
    }
}

﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ParseRss
{
    class NewYorkTime
    {
        static string uri = "http://rss.nytimes.com/services/xml/rss/nyt/HomePage.xml";
        public static List<NewYorkTime> listNewYT = GetData();
      
    
        public static List<NewYorkTime> GetData()
        {
            List<NewYorkTime> list = new List<NewYorkTime>();

            StringBuilder output = new StringBuilder();
            XDocument doc = XDocument.Parse(XmlRss(uri));
            var result = doc.Root.Attributes().Where(x => x.IsNamespaceDeclaration).
                GroupBy(x => x.Name.Namespace == XNamespace.None ? String.Empty : x.Name.LocalName, x => XNamespace.Get(x.Value))
                .ToDictionary(x => x.Key, x => x.First());
            XNamespace xnmedia = result["media"];
            foreach (var item in doc.Descendants("item"))
            {
                NewYorkTime ny = new NewYorkTime();
                ny.itemtitle = item.Element("title").Value;
                ny.itemlink = item.Element("link").Value;
                XNamespace nsc = doc.Root.Attribute(XNamespace.Xmlns + "dc").Value;
                ny.itemdcreator = item.Element(nsc + "creator").Value;
                ny.description = item.Element("description").Value;
                XElement xemedia = item.Element(xnmedia + "content");
                if (xemedia != null)
                {
                    ny.itemimage = xemedia.Attribute("url").Value;
                }
                else
                    ny.itemimage = "";


                list.Add(ny);
            }



            return list;
        }

        //string xml
        public static string XmlRss(string repuestUri)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.GetAsync(repuestUri).Result;
            string content = response.Content.ReadAsStringAsync().Result;
            return content;
        }
        //getData

        public static List<NewYorkTime> GetTitle()
        {
            List<NewYorkTime> list = new List<NewYorkTime>();
            StringBuilder output = new StringBuilder();
            using (XmlReader reader = XmlReader.Create(new StringReader(XmlRss(uri))))
            {
                //item
                while (reader.ReadToDescendant("item"))
                {
                    while (reader.ReadToFollowing("title"))
                    {
                        output.AppendLine(reader.ReadElementContentAsString());
                    }
                }
                string[] ititle = output.ToString().Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < ititle.Length; i++)
                {
                    NewYorkTime nyt = new NewYorkTime();
                    nyt.itemtitle = ititle[i];
                    list.Add(nyt);
                }
            }

            return list;
        }

        //link
        public static List<NewYorkTime> GetLink()
        {
            List<NewYorkTime> list = new List<NewYorkTime>();
            StringBuilder output = new StringBuilder();
            using (XmlReader reader = XmlReader.Create(new StringReader(XmlRss(uri))))
            {
                //item
                while (reader.ReadToDescendant("item"))
                {
                    while (reader.ReadToFollowing("link"))
                    {
                        output.AppendLine(reader.ReadElementContentAsString());
                    }
                }
                string[] ititle = output.ToString().Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < ititle.Length; i++)
                {
                    NewYorkTime nyt = new NewYorkTime();
                    nyt.itemlink = ititle[i];
                    list.Add(nyt);
                }
            }
            return list;
        }
        //image
        public static List<NewYorkTime> GetImage()
        {
            List<NewYorkTime> list = new List<NewYorkTime>();
            StringBuilder output = new StringBuilder();
            using (XmlReader reader = XmlReader.Create(new StringReader(XmlRss(uri))))
            {
                //item
                while (reader.ReadToDescendant("item"))
                {
                    while (reader.ReadToFollowing("media:content"))
                    {
                        reader.MoveToFirstAttribute();
                        output.AppendLine(reader.Value);
                    }
                }
                string[] ititle = output.ToString().Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < ititle.Length; i++)
                {
                    NewYorkTime nyt = new NewYorkTime();
                    nyt.itemimage = ititle[i];
                    list.Add(nyt);
                }
            }
            return list;
        }

        //creator
        public static List<NewYorkTime> GetCreator()
        {
            List<NewYorkTime> list = new List<NewYorkTime>();
            StringBuilder output = new StringBuilder();
            using (XmlReader reader = XmlReader.Create(new StringReader(XmlRss(uri))))
            {
                //item
                while (reader.ReadToDescendant("item"))
                {
                    while (reader.ReadToFollowing("dc:creator"))
                    {
                        output.AppendLine(reader.ReadElementContentAsString());
                    }
                }
                string[] ititle = output.ToString().Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < ititle.Length; i++)
                {
                    NewYorkTime nyt = new NewYorkTime();
                    nyt.itemdcreator = ititle[i];
                    list.Add(nyt);
                }
            }
            return list;
        }
        //description
        public static List<NewYorkTime> GetDescription()
        {
            List<NewYorkTime> list = new List<NewYorkTime>();
            StringBuilder output = new StringBuilder();
            using (XmlReader reader = XmlReader.Create(new StringReader(XmlRss(uri))))
            {
                //item
                while (reader.ReadToDescendant("item"))
                {
                    while (reader.ReadToFollowing("description"))
                    {
                        output.AppendLine(reader.ReadElementContentAsString());
                    }
                }
                string[] ititle = output.ToString().Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < ititle.Length; i++)
                {
                    NewYorkTime nyt = new NewYorkTime();
                    nyt.description = ititle[i];
                    list.Add(nyt);
                }
            }
            return list;
        }

        //image home
        public static NewYorkTime GetImaggeHome()
        {
            NewYorkTime ny = new NewYorkTime();
            using (XmlReader reader = XmlReader.Create(new StringReader(XmlRss(uri))))
            {
                //Example : 
                //  < guid isPermaLink = "true" > https://www.nytimes.com/2017/04/25/us/politics/tax-plan-trump.html</guid>
                //Lay thuoc tinh trong mot the xml 
                /*reader.ReadToFollowing("guid");
                reader.MoveToFirstAttribute();
                string isPermaLink = reader.Value;
                ouput.AppendLine(isPermaLink);
                aaccc = ouput.ToString();*/

                //image nyt
                while (reader.ReadToDescendant("channel"))
                {
                    reader.ReadToFollowing("url");
                    ny.imgHome = reader.ReadElementContentAsString();
                }

            }
            return ny;
        }


        //New York Time 
        public string imgHome { get; set; }

        //Item
        public string itemtitle { get; set; }
        public string itemlink { get; set; }
        public string itemimage { get; set; }
        public string itemdcreator { get; set; }
        public string description { get; set; }
    }
}

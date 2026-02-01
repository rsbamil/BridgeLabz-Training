using Newtonsoft.Json;
using System;
using System.Xml;

class JsonToXml
{
    static void Main()
    {
        string json = @"{ 'name':'Amit', 'age':25 }";
        XmlDocument doc = JsonConvert.DeserializeXmlNode(json, "root");
        Console.WriteLine(doc.OuterXml);
    }
}

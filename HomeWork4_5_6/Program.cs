using System.Xml;

var xml = new XmlDocument();
xml.Load("TelephoneBook.xml");
Console.WriteLine(xml.OuterXml);
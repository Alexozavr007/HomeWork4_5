using System.Xml;

var xml = new XmlDocument();
xml.Load("TelephoneBook.xml");
foreach(XmlNode node in xml.DocumentElement.ChildNodes) {
    Console.WriteLine(node.Attributes["TelephoneNumber"].Value);
}
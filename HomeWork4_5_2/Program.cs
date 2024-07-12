using System.Text;
using System.Xml;

Console.OutputEncoding = Encoding.Unicode;
Console.WriteLine("Відомості про файл File1.xml");

var document = new XmlDocument();
document.Load("File1.xml");

Console.WriteLine(@$"
Name: {document.Name}
Declaration version: {((XmlDeclaration)document.FirstChild).Version}
Declaration encoding: {((XmlDeclaration)document.FirstChild).Encoding}
Document node name: {document.DocumentElement.Name}
Child node names: {String.Join(", ", document.DocumentElement.ChildNodes.OfType<XmlNode>().Select(x => x.Name).Distinct())}
Child nodes count: {document.DocumentElement.ChildNodes.Count}
");

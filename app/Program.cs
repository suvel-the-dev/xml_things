using System.Xml;

XmlDocument doc = new XmlDocument();
doc.Load("./book.xml");

XmlNodeList catalogs = doc.GetElementsByTagName("catalog");

foreach (XmlNode catalog in catalogs)
{
 
       string newCatalog = catalog.InnerXml;
    
}

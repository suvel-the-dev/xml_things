using System.Xml;

XmlDocument doc = new XmlDocument();
doc.Load("./book.xml");

XmlNodeList catalogs = doc.GetElementsByTagName("catalog");

foreach (XmlNode catalog in catalogs)
{

    XmlNodeList books = catalog.SelectNodes("book");

    foreach (XmlNode book in books)
    {

        var attribute = book.Attributes["author"];
        if (attribute != null)
        {
            string employeeName = attribute.Value;
            Console.WriteLine(employeeName);
            // Process the value here
        }

    }

}

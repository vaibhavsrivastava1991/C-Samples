using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CreateXmlWithChildNodes
{
	class Program
	{
		static void Main(string[] args)
		{
			XmlDocument xmldoc = new XmlDocument();
			string xmlFilePath = @"..\CreateXmlWithChildNodes\Test.xml";
			xmldoc.Load(xmlFilePath);
			if (xmldoc != null)
			{
				XmlElement Field = xmldoc.CreateElement("Field");
				XmlElement InteruptedUTCTime = xmldoc.CreateElement("InteruptedUTCTime");
				InteruptedUTCTime.InnerText = DateTime.UtcNow.ToString();
				Field.AppendChild(InteruptedUTCTime);
				for (int i = 0; i < 5; i++)
				{
					XmlElement Field1 = xmldoc.CreateElement("Field");
					XmlElement InteruptedUTCTime1 = xmldoc.CreateElement("InteruptedUTCTime");
					InteruptedUTCTime1.InnerText = DateTime.UtcNow.ToString();
					Field1.AppendChild(InteruptedUTCTime1);
					Field.AppendChild(Field1);
				}

				xmldoc.DocumentElement.AppendChild(Field);
				xmldoc.Save(xmlFilePath);
			}
	}
}

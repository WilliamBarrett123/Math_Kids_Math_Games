using System;
using System.Xml.Serialization;

[Serializable]
[XmlRoot(ElementName = "Language")]
public class Language
{
	[XmlAttribute(AttributeName = "LangName")]
	public string LangName;

	[XmlAttribute(AttributeName = "LangCode")]
	public string LangCode;

	[XmlAttribute(AttributeName = "LangBundleName")]
	public string LangBundleName;

	[XmlAttribute(AttributeName = "S3BundleName")]
	public string S3BundleName;
}

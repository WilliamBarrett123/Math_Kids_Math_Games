using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[Serializable]
[XmlRoot(ElementName = "LanguagesBundleNames")]
public class LanguagesBundleNames
{
	[XmlElement(ElementName = "Language")]
	public List<Language> lstLanguagesBundleNames;
}

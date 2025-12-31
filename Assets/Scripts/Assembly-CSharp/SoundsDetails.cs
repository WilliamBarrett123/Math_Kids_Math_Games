using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot(ElementName = "SoundsDetails")]
public class SoundsDetails
{
	[XmlElement(ElementName = "SoundFile")]
	public List<SoundFile> lstSoundFiles;
}

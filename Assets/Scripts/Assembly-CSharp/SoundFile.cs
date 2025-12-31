using System.Xml.Serialization;

[XmlRoot(ElementName = "SoundFile")]
public class SoundFile
{
	[XmlAttribute(AttributeName = "OldName")]
	public string OldName { get; set; }

	[XmlAttribute(AttributeName = "NewName")]
	public string NewName { get; set; }
}

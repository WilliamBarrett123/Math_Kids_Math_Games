using System.Threading.Tasks;
using System.Xml.Linq;

public class XMLParser
{
	public enum FileLocation
	{
		ApplicationResource = 1,
		PersistantResource = 2
	}

	public static Task<XDocument> LoadAsync(string path)
	{
		return null;
	}

	public static Task<XDocument> ParseAsync(string path)
	{
		return null;
	}

	public static XDocument ParseXML(string path, FileLocation location, bool isEncrypted = false, bool FromDirectory = false)
	{
		return null;
	}

	public static bool fileExists(string path, FileLocation location)
	{
		return false;
	}

	public static void deleteDirectory(string DirectoryName)
	{
	}

	public static bool fileExistsInDirectory(string path)
	{
		return false;
	}

	public static void SaveXMLToPath(XDocument xDoc, string fileName, string DirectoryName, bool doEncrypt = false, bool doSavePrefs = true)
	{
	}

	public static void SaveXML(XDocument xDoc, string fileName, bool doEncrypt = false, bool doSavePrefs = true)
	{
	}

	public static bool CheckIfDataEdited(string fileName, string xmlString)
	{
		return false;
	}
}

using UnityEngine;
using UnityEngine.UI;

public class ColorUIController : MonoBehaviour
{
	[SerializeField]
	private TexturePainter painter;

	[SerializeField]
	private Button[] colorButtons;

	private void Start()
	{
	}

	private void InitializeColorButtons()
	{
	}

	private Color GetColorForEnum(PaintColor paintColor)
	{
		return default(Color);
	}
}

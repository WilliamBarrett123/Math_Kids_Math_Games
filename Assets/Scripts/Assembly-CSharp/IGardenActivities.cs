using UnityEngine;

public interface IGardenActivities
{
	bool IsactivityFree { get; }

	void EnterState(ICharacter character);

	void ExitState();

	Vector2 GetUIElementSize(RectTransform uiElement);
}

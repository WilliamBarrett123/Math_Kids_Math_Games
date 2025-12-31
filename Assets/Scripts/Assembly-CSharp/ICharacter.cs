using System;
using Spine.Unity;
using UnityEngine;

public interface ICharacter
{
	SkeletonGraphic CharcterSkeleton { get; }

	RectTransform CharRectTransform { get; }

	Transform CharacterTransform { get; }

	BoxCollider2D CharcterCollider { get; }

	Status CurrentStatus { get; set; }

	float LastActivityTime { get; }

	float WalkingStartTime { get; }

	bool SetRayCastStatus { set; }

	bool SwitchAnimationBool { get; set; }

	bool CharacterIdleAnimBool { get; set; }

	bool IsCharacterCanDrag { get; set; }

	bool IsCharacterDragging { get; }

	CharacterName characterName { get; }

	event EventHandler<CharacterEventArgs> CharcterTriggerStatus;

	event EventHandler<Transform> SetCharacterBeginDragStatus;

	event EventHandler SetCharacterEndDragStatus;

	void CheckCharacterCurrentStatus(Status status);

	void UpdateChacterTimeStatus();
}

using System;

public class CharacterEventArgs : EventArgs
{
	public ICharacter Character { get; }

	public bool Status { get; }

	public string _CharacterPrefix => null;

	public CharacterEventArgs(ICharacter character, bool status)
	{
	}
}

using System.Collections.Generic;

public class ModesEvent<T>
{
	public List<IModebuttonListner<T, ModeName>> listeners;

	public void RegisterListner(IModebuttonListner<T, ModeName> listener)
	{
	}

	public void UnregisterListner(IModebuttonListner<T, ModeName> listener)
	{
	}

	public void OnEventRaiseonModebuttonClick(T evnetdata, ModeName mode)
	{
	}
}

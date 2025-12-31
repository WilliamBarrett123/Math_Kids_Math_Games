using System.Collections.Generic;

public class VisibleModeEvent<T>
{
	public List<IVisibelModeListener<T>> listeners;

	public void RegisterListner(IVisibelModeListener<T> listener)
	{
	}

	public void UnregisterListner(IVisibelModeListener<T> listener)
	{
	}

	public void OnEventRaiseonButtonClick(T evnetdata)
	{
	}
}

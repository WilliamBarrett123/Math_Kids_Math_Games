public interface IModebuttonListner<T, ModeName>
{
	void OnModeButtonClick(T data, ModeName modeName);
}

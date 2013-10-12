namespace ELTE.Trainings.Lecture04.CustomerRegister.Views.Utils
{
	public interface IInitializable<TType>
	{
		void Initialize(TType value);
	}
}
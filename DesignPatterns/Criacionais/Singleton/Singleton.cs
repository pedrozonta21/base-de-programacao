namespace DesignPatterns.Criacionais.Singleton;

public class Singleton
{
	private static Singleton _singleton;

	private Singleton() { }

	public static Singleton RetornarInstanciaDaClasse()
	{
		_singleton ??= new Singleton();
		return _singleton;
	}

	public void ReproduzirSomDeErro()
	{
		// ...
	} 
}

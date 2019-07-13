using System;

public class KlasaSaDelegatom
{
	public delegate void Delegat(int broj);
	public void PozoviDelegate(int broj, Delegat delegat)
	{
		delegat(broj);
	}
}
public class KlasaSaMetodom    
{
    public void IspisiKvadrat(int broj)
	{
		Console.WriteLine(broj * broj);
	}
	public void IspisiZbir(int broj)
	{
		Console.WriteLine(broj + broj);
	}

}

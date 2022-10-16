CustomerManager customerManager = new(new IkinciMevzuat());
customerManager.Add();
customerManager.ReadLine();

internal class CustomerManager
{
    private IMevzuat _mevzuat;

    public CustomerManager(IMevzuat mevzuat)
    {
        _mevzuat = mevzuat;
    }

    public void Add()
    {
    }

    public void ReadLine()
    {
        _mevzuat.IslemYap();
    }
}

interface IMevzuat
{
    void IslemYap();
}

class BirinciMevzuat : IMevzuat
{
    public void IslemYap()
    {
        Console.WriteLine("Birinci Mevzuata Göre Eklendi.");
    }
}
class IkinciMevzuat : IMevzuat
{
    public void IslemYap()
    {
        Console.WriteLine("İkinci Mevzuata Göre Eklendi.");
    }
}
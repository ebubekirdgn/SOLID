namespace Open_Closed_Principle_NotIdealCode;

class ParaGonderici
{
    public void Gonder(int tutar)
    {
        //Garanti garanti = new();
        //garanti.HesapNo = "...";
        //garanti.ParaGonder(tutar);

        HalkBank halkBank = new();
        halkBank.GonderilecekHesapNo("12345");
        halkBank.Gonder(tutar);
    }
}

class Garanti
{
    public string HesapNo { get; set; }

    public void ParaGonder(int tutar)
    {
        //...
    }
}

class HalkBank
{
    private string _hesapNo;

    public void GonderilecekHesapNo(string amount)
    {
        //...
    }

    public void Gonder(int tutar)
    {
        //...
    }
}
namespace Open_Closed_Principle_IdealCode;

class ParaGonderici
{
    public void Gonder( IBanka banka , int tutar, string hesapNo)
    {
        banka.Gonder(tutar, hesapNo);   
    }
}

interface IBanka
{
    bool ParaTransferi(int tutar, string hesapNo);

}
class Garanti : IBanka
{
    public string  HesapNo{ get; set; }

    public void ParaGonder(int tutar)
    {
        //
    }
    public bool ParaTransferi(int tutar, string hesapNo)
    {
        try
        {
            HesapNo = hesapNo;
            ParaGonder(tutar);
            return true;
        }
        catch (Exception)
        {

            return false;
        }
    }
}

class HalkBank : IBanka
{
    public string _hesapNo;

    public void Gonder(int tutar)
    {
        //
    }
    public bool ParaTransferi(int tutar, string hesapNo)
    {
        try
        {
            _hesapNo = hesapNo;
            Gonder(tutar);
            return true;
        }
        catch (Exception)
        {

            return false;
        }
    }
}

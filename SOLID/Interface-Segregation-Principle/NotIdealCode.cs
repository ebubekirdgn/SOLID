namespace Interface_Segregation_Principle_NotIdealCode;
interface IPrinter
{
    void Print();
    void Scan();
    void Fax();
    void PrintDuplex();
}

class HpPrinter : IPrinter
{
    public void Fax()
    {
    }

    public void Print()
    {
    }

    public void PrintDuplex()
    {
    }

    public void Scan()
    {
    }
}

class SamsungPrinter : IPrinter
{
    public void Fax()
    {
    }

    public void Print()
    {
    }

    public void PrintDuplex()
    {
        throw new NotImplementedException();
    }

    public void Scan()
    {
        throw new NotImplementedException();
    }
}

class Lexmark : IPrinter
{
    public void Fax()
    {
    }

    public void Print()
    {
    }

    public void PrintDuplex()
    {
        throw new NotImplementedException();
    }

    public void Scan()
    {
    }
}
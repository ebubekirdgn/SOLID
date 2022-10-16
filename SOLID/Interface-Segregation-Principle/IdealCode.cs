using Interface_Segregation_Principle_NotIdealCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle_IdealCode;


interface IPrint
{
    void Print();
}
interface IFax
{
    void Fax();
}
interface IScan
{
    void Scan();
}
interface IPrintDuplex
{
    void PrintDuplex();
}

class HpPrinter : IScan, IPrint, IPrintDuplex, IFax
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

class SamsungPrinter : IPrint, IFax
{
    public void Fax()
    {
    }

    public void Print()
    {
    }
}

class Lexmark : IScan, IPrint, IFax
{
    public void Fax()
    {
    }

    public void Print()
    {
    }

    public void Scan()
    {
    }
}
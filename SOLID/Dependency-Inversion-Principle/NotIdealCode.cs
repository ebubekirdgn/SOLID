namespace Dependency_Inversion_Principle_NotIdealCode;

public class MailService
{
    public void SendMail(Gmail gmail)
    {
        gmail.Send("...");
    }
}

public class Gmail
{
    public void Send(string mail)
    {
        //...Send Mail...
    }
}

public class Yandex
{
    public void SendMail(string mail, string to)
    {
        //...Send Mail...
    }
}

public class Hotmail
{
    public void Send(string mail)
    {
        //...Send Mail...
    }
}
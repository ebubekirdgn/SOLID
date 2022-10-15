namespace Liskov_Substitution_Principle_IdealCode;

abstract class Cloud
{
    public abstract void MachineLearning();
}

 interface ITranslatable
{
    public  void Translate();
}
 class AWS : Cloud, ITranslatable
{
    public override void MachineLearning()
      => Console.WriteLine("AWS Machine Learning");

    public  void Translate()
      => Console.WriteLine("AWS Translate");
}

internal class Google : Cloud, ITranslatable
{
    public override void MachineLearning()
        => Console.WriteLine("Google Machine Learning");

    public void Translate()
      => Console.WriteLine("Google Translate");
}

internal class Azure : Cloud
{
    public override void MachineLearning()
         => Console.WriteLine("Azure Machine Learning");

}
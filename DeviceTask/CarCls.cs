using System.Reflection;

internal class CarCls : Device
{
    private string? model;

    public CarCls(string name, string description, string model) : base(name, description)
    {
        this.model = model;
    }
    public override void Sound()
    {
        Console.WriteLine("Car makes engine sound");
    }

    public new void Desc()
    {
        base.Desc();
        Console.WriteLine("Model: " + model);
    }
}


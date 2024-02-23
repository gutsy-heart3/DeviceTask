internal class MicrowaveCls : Device
{
    private string? power;

    public MicrowaveCls(string name, string description, string power)
        : base(name, description)
    {
        this.power = power;
    }
    public override void Sound()
    {
        Console.WriteLine("Microwave makes buzzing sound");
    }
    public new void Desc()
    {
        this.Desc();
        Console.WriteLine("Power: " + description);
    } 
}
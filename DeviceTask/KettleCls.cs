internal class Kettle : Device
{
    private string capacity;

    public Kettle(string name, string description, string capacity) : base(name, description)
    {
        this.capacity = capacity;
    }
    public override void Sound()
    {
        Console.WriteLine("Kettle makes boiling sound");
    }
    public new void Desc()
    {
        base.Desc();
        Console.WriteLine("Capasity: " + description);
    }
}

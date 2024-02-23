internal class Ship : Device
{
    private string capacity;

    public Ship(string name, string description, string capacity) : base(name, description)
    {
        this.capacity = capacity;
    }

    public override void Sound()
    {
        Console.WriteLine("Ship makes horn sound");
    }

    public new void Desc()
    {
        base.Desc();
        Console.WriteLine("Capacity: " + capacity);
    }
}


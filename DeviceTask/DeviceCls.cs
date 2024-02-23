internal class Device
{
    protected string name;
    protected string description;

    public Device(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public virtual void Sound()
    {
        Console.WriteLine("Device makes a sound");
    }

    public void Show()
    {
        Console.WriteLine("Device: " + name);
    }

    public void Desc()
    {
        Console.WriteLine("Description: " + description);
    }
}
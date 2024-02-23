Kettle kettle = new Kettle("Electric Kettle", "An electric kettle for boiling water", "1.7 liters");
MicrowaveCls microwave = new MicrowaveCls("Microwave Oven", "A microwave oven for heating food", "1500W");
CarCls car = new CarCls("Car", "Mitsubishi","Pajero");
Ship ship = new Ship("Ship", "Titanic", "2400");
Device[] devices = new Device[4];
devices[0] = kettle;
devices[1] = microwave;
devices[2] = car;
devices[3] = ship;
foreach (var item in devices)
{
    item.Sound();
    item.Show();
    item.Desc();
    Console.WriteLine();
}
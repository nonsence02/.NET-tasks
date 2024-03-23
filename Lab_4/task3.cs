using System;

class Ship
{
    public string Name { get; set; }
    public string Purpose { get; set; }
    public double Displacement { get; set; }
    public double EnginePower { get; set; }
    public string FuelType { get; set; }

    public Ship(string name, string purpose, double displacement, double enginePower, string fuelType)
    {
        Name = name;
        Purpose = purpose;
        Displacement = displacement;
        EnginePower = enginePower;
        FuelType = fuelType;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Назва: {Name}");
        Console.WriteLine($"Призначення: {Purpose}");
        Console.WriteLine($"Водотоннажність: {Displacement} тон");
        Console.WriteLine($"Потужність двигуна: {EnginePower} кВт");
        Console.WriteLine($"Вид палива: {FuelType}");
    }
}

class AircraftCarrier : Ship
{
    public int AircraftCount { get; set; }
    public string[] AircraftTypes { get; set; }

    public AircraftCarrier(string name, string purpose, double displacement, double enginePower, string fuelType, int aircraftCount, string[] aircraftTypes)
        : base(name, purpose, displacement, enginePower, fuelType)
    {
        AircraftCount = aircraftCount;
        AircraftTypes = aircraftTypes;
    }

    public new void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Кількість літаків на борту: {AircraftCount}");
        Console.WriteLine($"Типи літаків: {string.Join(", ", AircraftTypes)}");
    }
}

class MissileCarrier : Ship
{
    public string MissileType { get; set; }
    public int MissileCount { get; set; }

    public MissileCarrier(string name, string purpose, double displacement, double enginePower, string fuelType, string missileType, int missileCount)
        : base(name, purpose, displacement, enginePower, fuelType)
    {
        MissileType = missileType;
        MissileCount = missileCount;
    }

    public new void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Тип ракет: {MissileType}");
        Console.WriteLine($"Кількість ракет: {MissileCount}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Ship ship1 = new Ship("Крейсер 'Aurora'", "Бойовий", 10000, 5000, "Дизельне паливо");
        Console.WriteLine("Інформація про корабель:");
        ship1.DisplayInfo();
        Console.WriteLine();

        AircraftCarrier carrier1 = new AircraftCarrier("Авіаносець 'Birmingem'", "Перевезення літаків", 85000, 75000, "Ядерне паливо", 50, new string[] { "F-18", "E-2 Hawkeye", "SH-60 Seahawk" });
        Console.WriteLine("Інформація про авіаносець:");
        carrier1.DisplayInfo();
        Console.WriteLine();

        MissileCarrier carrier2 = new MissileCarrier("Ракетоносець 'Herson'", "Морська оборона", 28000, 60000, "Ядерне паливо", "Повітря-повітря", 200);
        Console.WriteLine("Інформація про ракетоносець:");
        carrier2.DisplayInfo();
    }
}

using System;

abstract class Vehicle
{
    public abstract void Move();
}

class Car : Vehicle
{
    public override void Move() => Console.WriteLine("Car is driving on the road");
}

class Bicycle : Vehicle
{
    public override void Move() => Console.WriteLine("Bicycle is pedaling forward");
}

class Program
{
    static void Main()
    {
        Vehicle v1 = new Car();
        Vehicle v2 = new Bicycle();

        v1.Move();
        v2.Move();
    }
}



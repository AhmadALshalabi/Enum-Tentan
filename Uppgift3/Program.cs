using System;

namespace Uppgift3
{
    class Program
    {
        static void Main(string[] args)
        {

            Avatar avatar1 = new Avatar();
            Avatar avatar2 = new Avatar();

            while (true)
            {
                Direction direction = GetDirection();
                avatar1.Move(direction);
                Direction randomDirection = GetRandomDirection();
                avatar2.Move(randomDirection);

                Console.WriteLine($"Avatar1: {avatar1}");
                Console.WriteLine($"Avatar2: {avatar2}");
            }
        }

        static Direction GetDirection()
        {
            return Direction.West;
        }

        static Direction GetRandomDirection()
        {
            Direction[] directions = new Direction[]
            {
                Direction.North,
                Direction.South,
                Direction.East,
                Direction.West,
                
            };
            int value = new Random().Next(0, directions.Length);
            return directions[value];
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3
{
    //11
    class Avatar
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Avatar()
        {
            X = 100;
            Y = 100;
        }

        public void Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.South:
                    Y--;
                    break;
                case Direction.North:
                    Y++;
                    break;
                case Direction.West:
                    X--;
                    break;
                case Direction.East:
                    X++;
                    break;
                default:
                    Console.WriteLine("Cannot move in that direction");
                    break;
            }
        }

        public override string ToString()
        {
            return $"Avatar [{X}, {Y}]";
        }
    }
}

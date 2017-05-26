using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sendible
{
    class Robot
    {
        private int x;
        private int y;

        public int X
        {
            get { return x; }
            set
            {
                if (value >= 0 && value <= Plateau.MaxX)
                    x = value;
            }
        }
        public int Y
        {
            get { return y; }
            set
            {
                if (value >= 0 && value <= Plateau.MaxY)
                    y = value;
            }
        }
        public Direction Facing { get; set; }

        public Robot()
        {
            var pRobot = Console.ReadLine().ToUpper().Split(' ');
            
            try
            {
                X = int.Parse(pRobot[0]);
                Y = int.Parse(pRobot[1]);
                Facing = (Direction)Enum.Parse(typeof(Direction), pRobot[2]);
            }
            catch(FormatException fe)
            {
                throw new Exception("The X and Y must be numbers.");
            }
            catch(ArgumentException ae)
            {
                throw new Exception("The direction must be either N, E, S or W");
            }
        }

        public void Update(Instruction instruction)
        {
            if (instruction == Instruction.R || instruction == Instruction.L)
                Rotate(instruction);
            else if (instruction == Instruction.M)
                Move();
        }

        private void Rotate(Instruction direction)
        {
            Facing = Facing.Rotate(direction);
        }

        private void Move()
        {
            if (Facing == Direction.N)
                Y++;
            else if (Facing == Direction.E)
                X++;
            else if (Facing == Direction.S)
                Y--;
            else if (Facing == Direction.W)
                X--;
        }
    }
}

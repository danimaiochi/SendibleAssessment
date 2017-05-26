using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sendible
{
    public static class Extension
    {
        public static Direction Rotate(this Direction direction, Instruction side)
        {
            var directionIndex = (int)direction;
            if (side == Instruction.R)
                directionIndex++;
            else
                directionIndex--;

            if (directionIndex > 3)
                directionIndex = 0;
            if (directionIndex < 0)
                directionIndex = 3;

            return (Direction)directionIndex;
        }

        public static bool ValidInstruction(this char instruction)
        {
            if (instruction == 'L' || instruction == 'R' || instruction == 'M')
                return true;
            return false;
        }
    }
}

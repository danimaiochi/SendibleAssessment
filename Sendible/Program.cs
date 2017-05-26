using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sendible
{
    class Program
    {
        const int numberOfRobots = 2;
        static void Main(string[] args)
        {
            InitializePlateau();
            var robots = new List<Robot>();
            for (int i = 0; i < numberOfRobots; i++)
            {
                //Console.WriteLine("Location of the Robot {0}", i+1);
                var robot = new Robot();

                //Console.WriteLine("Instructions for the Robot");
                var instructions = Console.ReadLine().ToUpper();
                
                foreach (char instruction in instructions)
                {
                    if (instruction.ValidInstruction())
                        robot.Update((Instruction)Enum.Parse(typeof(Instruction), instruction.ToString()));
                }
                robots.Add(robot);
            }
            foreach (var robot in robots)
                Console.WriteLine(string.Format("{0} {1} {2}", robot.X, robot.Y, robot.Facing));
        }

        public static void InitializePlateau()
        {
            //Console.WriteLine("Coordinates of the upper-right corner of the plateau");
            var pSize = Console.ReadLine().Split(' ');
            Plateau.Initialize(pSize[0], pSize[1]);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverTestProject
{
    public class RoverRove
    {
        private string InitialPosition { get; set; }
        private string Command { get; set; }

        private int X { get; set; }
        private int Y { get; set; }
        private string Direction { get; set; }

        public RoverRove(string position, string command)
        {
            this.InitialPosition = position;
            this.Command = command;
        }

        public string Calculate()
        {
            String[] positions = this.InitialPosition.Split(" ".ToCharArray());
            this.X = Convert.ToInt32(positions[0], 10);
            this.Y = Convert.ToInt32(positions[1], 10);
            this.Direction = positions[2];

            foreach (char command in this.Command.ToCharArray())
            {
                this.Move(command);
            }
            return  string.Format("{0} {1} {2}", this.X, this.Y, this.Direction);
        }


        private void Move(char command)
        {
            if (this.Direction.ToUpper().Equals("N"))
            {
                switch (command)
                {
                    case 'L':
                        this.Direction = "W";
                        break;
                    case 'R':
                        this.Direction = "E";
                        break;
                    case 'M':
                        this.Y++;
                        break;
                }
            }
            else if (this.Direction.ToUpper().Equals("E"))
            {
                switch (command)
                {
                    case 'L':
                        this.Direction = "N";
                        break;
                    case 'R':
                        this.Direction = "S";
                        break;
                    case 'M':
                        this.X++;
                        break;
                }
            }
            else if (this.Direction.ToUpper().Equals("S"))
            {
                switch (command)
                {
                    case 'L':
                        this.Direction = "E";
                        break;
                    case 'R':
                        this.Direction = "W";
                        break;
                    case 'M':
                        this.Y--;
                        break;
                }
            }
            else if (this.Direction.ToUpper().Equals("W"))
            {
                switch (command)
                {
                    case 'L':
                        this.Direction = "S";
                        break;
                    case 'R':
                        this.Direction = "N";
                        break;
                    case 'M':
                        this.X--;
                        break;
                }
            }
        }
    }
}

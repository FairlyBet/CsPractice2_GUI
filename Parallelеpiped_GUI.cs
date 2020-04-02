using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsPractice3_GUI 
{
    class Parallelеpiped_GUI : Rectangle_GUI
    {
        Double height;

        public double Height { get => height; set => height = value; }

        public bool IsCube()
        {
            if (firstSideLenght == secondSideLenght ? (firstSideLenght == height ? true : false) : false)
                return true;
            else return false;
        }

        public new double GetSquare()
        {
            return 2 * (firstSideLenght * secondSideLenght + secondSideLenght * height + firstSideLenght * height);
        }

        public double GetCapacity()
        {
            return height * firstSideLenght * secondSideLenght;
        }

        public override string ToString() => $"\nFirst side lenght = {String.Format("{0:0.0}", firstSideLenght)}" +
                $"\nSecond side lenght = {String.Format("{0:0.0}", secondSideLenght)}" +
                $"\nHeight lenght = {String.Format("{0:0.0}", height)}" +
                $"\nSquare = {String.Format("{0:0.0}", GetSquare())}" +
                $"\nCapacity = {String.Format("{0:0.0}",GetCapacity())}\n";          
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsPractice3_GUI
{
    class Parallelepipeds_GUI : Rectangles_GUI
    {
        Parallelеpiped_GUI[] parallelеpipeds;
        Byte cubeAmount = 0;

        public Parallelepipeds_GUI(byte size = 0)
        {
            parallelеpipeds = new Parallelеpiped_GUI[size];

            for (int i = 0; i < size; i++)
            {
                parallelеpipeds[i] = new Parallelеpiped_GUI();
            }
        }

        public Boolean SetElement(Double firstSideLength, Double secondSideLength, Double height)
        {
            if (currentElement < parallelеpipeds.Length)
            {
                parallelеpipeds[currentElement].FirstSideLenght = firstSideLength;
                parallelеpipeds[currentElement].SecondSideLenght = secondSideLength;
                parallelеpipeds[currentElement].Height = height;

                currentElement++;

                return true;
            }
            else return false;
        }

        public new Boolean GenerateElement()
        {
            if (currentElement < parallelеpipeds.Length)
            {
                Random random = new Random();

                parallelеpipeds[currentElement].FirstSideLenght = random.NextDouble() * 100 + 1;
                parallelеpipeds[currentElement].SecondSideLenght = random.NextDouble() * 100 + 1;
                parallelеpipeds[currentElement].Height = random.NextDouble() * 100 + 1;

                currentElement++;

                return true;
            }
            else return false;
        }

        public new string Counter()
        {
            return $"Parallelepiped {currentElement}/{parallelеpipeds.Length}";
        }

        public override string ToString()
        {
            AllInfo = null;
            cubeAmount = 0;

            for (int i = 0; i < currentElement; i++)
            {
                AllInfo += $"Parallelepied number {i + 1}:\n{parallelеpipeds[i]}\n";
                if (parallelеpipeds[i].IsCube())
                    cubeAmount++;
            }
            AllInfo += $"Amount of cubes: {cubeAmount}";

            return AllInfo;
        }
    }
}

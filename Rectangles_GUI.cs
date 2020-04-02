﻿using System;

namespace CsPractice3_GUI
{
    class Rectangles_GUI
    {
        Rectangle_GUI[] rectangles;
        private protected Byte currentElement = 0;
        private protected String AllInfo;
        Double averageSquare = 0;
        Byte moreThanAverage = 0;
        public Rectangles_GUI(byte size = 0)
        {
            rectangles = new Rectangle_GUI[size];

            for (int i = 0; i < size; i++)
            {
                rectangles[i] = new Rectangle_GUI();
            }
        }

        public Boolean SetElement(Double firstSideLength, Double secondSideLength)
        {
            if (currentElement < rectangles.Length)
            {
                rectangles[currentElement].FirstSideLenght = firstSideLength;
                rectangles[currentElement].SecondSideLenght = secondSideLength;

                currentElement++;

                return true;
            }
            else return false;
        }

        public Boolean GenerateElement()
        {
            if (currentElement < rectangles.Length)
            {
                Random random = new Random();

                rectangles[currentElement].FirstSideLenght = random.NextDouble() * 100 + 1;
                rectangles[currentElement].SecondSideLenght = random.NextDouble() * 100 + 1;

                currentElement++;

                return true;
            }
            else return false;
        }

        public string Counter()
        {
            return $"Rectangle {currentElement}/{rectangles.Length}";
        }

        public override string ToString()
        {
            AllInfo = null;
            averageSquare = 0;
            moreThanAverage = 0;

            for (int i = 0; i < currentElement; i++)
            {
                AllInfo += $"Recatangle number {i + 1}:\n{rectangles[i]}\n";
                averageSquare += rectangles[i].GetSquare();
            }

            averageSquare /= currentElement;

            for (int i = 0; i < currentElement; i++)
            {
                if (rectangles[i].GetSquare() > averageSquare)
                    moreThanAverage++;
            }
            AllInfo += $"Average square: {String.Format("{0:0.0}", averageSquare)}\n\nAmount of rectangles which square is over average: {moreThanAverage}";

            return AllInfo;
        }
    }
}
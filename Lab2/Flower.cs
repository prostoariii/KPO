﻿namespace KPOLab2
{
    public enum ColorsEnum
    {
        Red,
        Green,
        Blue
    }

    internal class Flower
    {
        public static int FlowersBought { get; private set; } //number of flowers bought

        public readonly ColorsEnum Color;

        public readonly double Price;
        public readonly double WeightGrams;

        public Flower(ColorsEnum color)
        {
            Color = color;

            if (color == ColorsEnum.Red)
            {
                Price = 5;
                WeightGrams = 40.2;
            }
            else if (color == ColorsEnum.Green)
            {
                Price = 5.5;
                WeightGrams = 37.8;
            }
            else
            {
                Price = 4.7;
                WeightGrams = 41;
            }

            FlowersBought++;
        }
    }
}

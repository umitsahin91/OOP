﻿namespace OOP.Inheritance
{
    public class Rectangle:Shape
    {
        public override void Draw()
        {
            System.Console.WriteLine("Rectangle drawing task...");
            //base.Draw();
        }
        public void Calculate()
        {
            System.Console.WriteLine("Calculated by Rectangle...");
        }
    }

}
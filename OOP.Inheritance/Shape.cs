namespace OOP.Inheritance
{
    public class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }

        public int Height { get; set; }
        public int Width { get; set; }

        public void Draw()
        {
            System.Console.WriteLine("Base class drawing task...");
        }
    }

}

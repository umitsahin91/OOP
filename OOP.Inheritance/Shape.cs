namespace OOP.Inheritance
{
    public class Shape
    {
        public Shape()
        {

        }
        public Shape(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public int Height { get; set; }
        public int Width { get; set; }

        public virtual void Draw()
        {
            System.Console.WriteLine("Base class drawing task...");
        }
    }

}

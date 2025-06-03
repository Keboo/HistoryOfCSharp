using System;

namespace CSharp1
{
    public delegate void MyEventHandler(object sender, EventArgs e);

    public class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();
            program.Number = 1;
            Console.WriteLine("C# {0}: Hello, World!", program.Number);
        }

        private int _number;
        public int Number
        {
            get { return _number; }
            set
            {
                _number = value;
                MyEventHandler handler = NumberChanged;
                if (handler != null)
                {
                    handler(this, EventArgs.Empty);
                }
            }
        }

        public event MyEventHandler NumberChanged;
    }
}

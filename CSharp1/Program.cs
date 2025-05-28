using System;

namespace CSharp1
{
    public delegate void MyEventHandler(object sender, EventArgs e);

    public class Program
    {
        private MyNumber _number;
        public MyNumber Number
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

        public static void Main(string[] args)
        {
            Program program = new Program();
            program.Number = 1;
            Console.WriteLine("C# {0}: Hello, World!", program.Number);
        }
    }
    
    public struct MyNumber
    {
        private int _value;
        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public MyNumber(int value)
        {
            _value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public static implicit operator MyNumber(int value)
        {
            return new MyNumber(value);
        }

        public static implicit operator int(MyNumber myNumber)
        {
            return myNumber.Value;
        }
    }
}

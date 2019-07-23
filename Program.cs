using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Canon("принтер Canon");
            Paper paper1 = printer.Create();
            printer.Print(paper1.Type);

            printer = new HP("принтер HP");
            Paper paper2 = printer.Create();
            printer.Print(paper2.Type);

            Console.ReadLine();
        }
    }

    abstract class Printer
    {
        public string Name { get; set; }

        public Printer(string n)
        {
            Name = n;
        }
        public void Print(string paperType)
        {
            Console.WriteLine($"{Name} печатает бумагой {paperType}");
        }
        // фабричный метод
        abstract public Paper Create();
    }

    class Canon : Printer
    {
        public Canon(string n) : base(n)
        { }

        public override Paper Create()
        {
            return new PerlPaper("Perl");
        }
    }

    class HP : Printer
    {
        public HP(string n) : base(n)
        { }

        public override Paper Create()
        {
            return new OffsetPaper("Offset");
        }
    }

    abstract class Paper
    {
        public string Type { get; set; }
        public Paper(string type)
        {
            Type = type;
        }
    }

    class PerlPaper : Paper
    {
        public PerlPaper(string type) : base(type)
        {

        }

    }
    class OffsetPaper : Paper
    {
        public OffsetPaper(string type) : base(type)
        {

        }
    }
}

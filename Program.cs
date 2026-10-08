using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box miBox = new Box();
            miBox.Width = 2;
            miBox.Height = 3;
            miBox.Length = 5;
            miBox.Show();
            int volume = miBox.Volume();
            Console.WriteLine($"Объем коробки = {volume}");
            Console.ReadKey();
        }
    }

    class Box
    {
        public int Height;
        public int Width;
        public int Length;
        public void Show()
        {
            Console.WriteLine($"Коробка: Ширина = {Width}, \nВысота = {Height}, \nДлина = {Length}");
        }
        public int Volume()
        {
            int vol = Width * Height * Length;
            return vol;
        }
    }
}
    



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04_Photo_Galery
{
    class Program
    {
        static void Main()
        {
            var photoNumber = int.Parse(Console.ReadLine());
            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var photoSize = double.Parse(Console.ReadLine());
            var photoWidth = int.Parse(Console.ReadLine());
            var photoHeight = int.Parse(Console.ReadLine());
            Console.WriteLine($"Name: DSC_{photoNumber:d4}.jpg");
            Console.WriteLine($"Date Taken: {day:d2}/{month:d2}/{year} {hours:d2}:{minutes:d2}");
            if(photoSize<1000)
            {
                Console.WriteLine($"Size: {photoSize}B");
            }
            else if (photoSize<1000000)
            {
                Console.WriteLine($"Size: {photoSize/1000}KB");
            }
            else if (photoSize>=1000000)
            {
                Console.WriteLine($"Size: {photoSize/1000000}MB");
            }
            if (photoWidth==photoHeight)
            {
                Console.WriteLine($"Resolution: {photoWidth}x{photoHeight} (square)");
            }
            else if (photoWidth>photoHeight)
            {
                Console.WriteLine($"Resolution: {photoWidth}x{photoHeight} (landscape)");
            }
            else
            {
                Console.WriteLine($"Resolution: {photoWidth}x{photoHeight} (portrait)");
            }
        }
    }
}

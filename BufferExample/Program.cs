using System;

namespace BufferExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var buffer = new CircularBuffer<double>(capacity:5);

            while (true)
            {
                
                var value = 0.0;
                var input = Console.ReadLine();
                
                if (double.TryParse(input, out value))
                {
                    buffer.Write(value);
                    continue;
                }

                break;

            }


            var sum = 0.0;
            Console.WriteLine("Buffer: ");
            while (!buffer.IsEmpty)
            {
                sum += buffer.Read();
            }
            Console.WriteLine(sum);

        }
    }
}

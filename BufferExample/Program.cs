using System;

namespace BufferExample
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var buffer = new CircularBuffer<double>(capacity: 5);

            /*This example uses the new interface*/
            //var buffer = new Buffer<double>();

            ProcessInput(buffer);

            ProcessBuffer(buffer);

        }

        private static void ProcessBuffer(IBuffer<double> buffer)
        {
            var sum = 0.0;
            Console.WriteLine("Buffer: ");
            while (!buffer.IsEmpty)
            {
                sum += buffer.Read();
            }
            Console.WriteLine(sum);
        }

        private static void ProcessInput(IBuffer<double> buffer)
        {
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
        }
    }
}

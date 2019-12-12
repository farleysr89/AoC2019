using System;

namespace AventCode2
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new int[] { 1, 0, 0, 3, 1, 1, 2, 3, 1, 3, 4, 3, 1, 5, 0, 3, 2, 1, 9, 19, 1, 19, 5, 23, 2, 23, 13, 27, 1, 10, 27, 31, 2, 31, 6, 35, 1, 5, 35, 39, 1, 39, 10, 43, 2, 9, 43, 47, 1, 47, 5, 51, 2, 51, 9, 55, 1, 13, 55, 59, 1, 13, 59, 63, 1, 6, 63, 67, 2, 13, 67, 71, 1, 10, 71, 75, 2, 13, 75, 79, 1, 5, 79, 83, 2, 83, 9, 87, 2, 87, 13, 91, 1, 91, 5, 95, 2, 9, 95, 99, 1, 99, 5, 103, 1, 2, 103, 107, 1, 10, 107, 0, 99, 2, 14, 0, 0 };

            var target = 19690720;
            input[1] = 0;
            input[2] = 0;
            var found = false;
            while (!found && input[1] < 100)
            {
                //Console.WriteLine(input[0]);
                int val = processInput(((int[])input.Clone()));
                //Console.WriteLine(val + " " + input[1] + " " + input[2]);
                if (val == target)
                {
                    break;
                }
                input[2] = 0;
                while (!found && input[2] < 100)
                {
                    //Console.WriteLine(input[0]);
                    int val2 = processInput(((int[])input.Clone()));
                    //Console.WriteLine(val2 + " " + input[1] + " " + input[2]);
                    if (val2 == target)
                    {
                        found = true;
                        break;
                    }
                    input[2] += 1;
                }
                if (!found) 
                    input[1] += 1;
            }
            //Console.WriteLine(input.Length);

            Console.WriteLine(input[1]);
            Console.WriteLine(input[2]);
        }

        static int processInput(int[] input)
        {
            var index = 0;
            while (true)
            {
                if (input[index] == 99)
                    break;
                try
                {
                    input = processInstruction(input[index], input, index);
                }
                catch { }
                

                index += 4;
            }
            return input[0];
        }

        static int[] processInstruction(int instruction,int[] input,int index)
        {
            //Console.WriteLine(instruction);
            //Console.WriteLine(index);
            int first, second, dest;
            first = input[index + 1];
            second = input[index + 2];
            dest = input[index + 3];
            if (instruction == 1)
                input[dest] = input[first] + input[second];
            if (instruction == 2)
                input[dest] = input[first] * input[second];

            return input;
        }

    }
}

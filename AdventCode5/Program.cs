﻿using System;

namespace AventCode5
{
    class Program
    {
        static int inputParam = 5;
        static void Main(string[] args)
        {
            var input = new int[] { 3, 225, 1, 225, 6, 6, 1100, 1, 238, 225, 104, 0, 1101, 69, 55, 225, 1001, 144, 76, 224, 101, -139, 224, 224, 4, 224, 1002, 223, 8, 223, 1001, 224, 3, 224, 1, 223, 224, 223, 1102, 60, 49, 225, 1102, 51, 78, 225, 1101, 82, 33, 224, 1001, 224, -115, 224, 4, 224, 1002, 223, 8, 223, 1001, 224, 3, 224, 1, 224, 223, 223, 1102, 69, 5, 225, 2, 39, 13, 224, 1001, 224, -4140, 224, 4, 224, 102, 8, 223, 223, 101, 2, 224, 224, 1, 224, 223, 223, 101, 42, 44, 224, 101, -120, 224, 224, 4, 224, 102, 8, 223, 223, 101, 3, 224, 224, 1, 223, 224, 223, 1102, 68, 49, 224, 101, -3332, 224, 224, 4, 224, 1002, 223, 8, 223, 1001, 224, 4, 224, 1, 224, 223, 223, 1101, 50, 27, 225, 1102, 5, 63, 225, 1002, 139, 75, 224, 1001, 224, -3750, 224, 4, 224, 1002, 223, 8, 223, 1001, 224, 3, 224, 1, 223, 224, 223, 102, 79, 213, 224, 1001, 224, -2844, 224, 4, 224, 102, 8, 223, 223, 1001, 224, 4, 224, 1, 223, 224, 223, 1, 217, 69, 224, 1001, 224, -95, 224, 4, 224, 102, 8, 223, 223, 1001, 224, 5, 224, 1, 223, 224, 223, 1102, 36, 37, 225, 1101, 26, 16, 225, 4, 223, 99, 0, 0, 0, 677, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1105, 0, 99999, 1105, 227, 247, 1105, 1, 99999, 1005, 227, 99999, 1005, 0, 256, 1105, 1, 99999, 1106, 227, 99999, 1106, 0, 265, 1105, 1, 99999, 1006, 0, 99999, 1006, 227, 274, 1105, 1, 99999, 1105, 1, 280, 1105, 1, 99999, 1, 225, 225, 225, 1101, 294, 0, 0, 105, 1, 0, 1105, 1, 99999, 1106, 0, 300, 1105, 1, 99999, 1, 225, 225, 225, 1101, 314, 0, 0, 106, 0, 0, 1105, 1, 99999, 1107, 677, 677, 224, 102, 2, 223, 223, 1006, 224, 329, 1001, 223, 1, 223, 1108, 677, 677, 224, 1002, 223, 2, 223, 1006, 224, 344, 1001, 223, 1, 223, 107, 226, 226, 224, 1002, 223, 2, 223, 1006, 224, 359, 101, 1, 223, 223, 1008, 226, 226, 224, 102, 2, 223, 223, 1005, 224, 374, 1001, 223, 1, 223, 1107, 226, 677, 224, 1002, 223, 2, 223, 1006, 224, 389, 1001, 223, 1, 223, 1008, 677, 226, 224, 1002, 223, 2, 223, 1005, 224, 404, 1001, 223, 1, 223, 7, 677, 226, 224, 102, 2, 223, 223, 1005, 224, 419, 1001, 223, 1, 223, 1008, 677, 677, 224, 1002, 223, 2, 223, 1006, 224, 434, 1001, 223, 1, 223, 108, 226, 226, 224, 102, 2, 223, 223, 1006, 224, 449, 1001, 223, 1, 223, 108, 677, 677, 224, 102, 2, 223, 223, 1006, 224, 464, 1001, 223, 1, 223, 107, 226, 677, 224, 1002, 223, 2, 223, 1005, 224, 479, 101, 1, 223, 223, 1108, 226, 677, 224, 1002, 223, 2, 223, 1006, 224, 494, 1001, 223, 1, 223, 107, 677, 677, 224, 1002, 223, 2, 223, 1006, 224, 509, 101, 1, 223, 223, 7, 677, 677, 224, 102, 2, 223, 223, 1006, 224, 524, 1001, 223, 1, 223, 1007, 226, 677, 224, 1002, 223, 2, 223, 1005, 224, 539, 1001, 223, 1, 223, 8, 226, 677, 224, 1002, 223, 2, 223, 1005, 224, 554, 101, 1, 223, 223, 8, 677, 677, 224, 102, 2, 223, 223, 1005, 224, 569, 101, 1, 223, 223, 7, 226, 677, 224, 102, 2, 223, 223, 1006, 224, 584, 1001, 223, 1, 223, 1007, 226, 226, 224, 102, 2, 223, 223, 1006, 224, 599, 1001, 223, 1, 223, 1107, 677, 226, 224, 1002, 223, 2, 223, 1006, 224, 614, 1001, 223, 1, 223, 1108, 677, 226, 224, 1002, 223, 2, 223, 1005, 224, 629, 1001, 223, 1, 223, 1007, 677, 677, 224, 102, 2, 223, 223, 1006, 224, 644, 1001, 223, 1, 223, 108, 226, 677, 224, 102, 2, 223, 223, 1005, 224, 659, 101, 1, 223, 223, 8, 677, 226, 224, 1002, 223, 2, 223, 1006, 224, 674, 1001, 223, 1, 223, 4, 223, 99, 226 };

//            var input = new int[] { 3,21,1008,21,8,20,1005,20,22,107,8,21,20,1006,20,31,
//1106,0,36,98,0,0,1002,21,125,20,4,20,1105,1,46,104,
//999,1105,1,46,1101,1000,1,20,4,20,1105,1,46,98,99 };

            int val = processInput(input);

            //Console.WriteLine(input[1]);
            //Console.WriteLine(input[2]);
        }

        static int processInput(int[] input)
        {
            var index = 0;
            
            while (true)
            {
                var instruction = input[index].ToString("D5");
                if(instruction[4] == '1')
                {
                    input = processAdd(input, index, instruction[2] == '1', instruction[1] == '1');
                    index += 4;
                }
                else if(instruction[4] == '2')
                {
                    input = processMult(input, index, instruction[2] == '1', instruction[1] == '1');
                    index += 4;
                }
                else if (instruction[4] == '3')
                {
                    input = processSaveInput(input, index);
                    index += 2;
                }
                else if (instruction[4] == '4')
                {
                    processOutput(input, index, instruction[2] == '1');
                    index += 2;
                }
                else if (instruction[4] == '5')
                {
                    index = processJump(input, index, instruction[2] == '1', instruction[1] == '1',true);
                }
                else if (instruction[4] == '6')
                {
                    index = processJump(input, index, instruction[2] == '1', instruction[1] == '1',false);                    
                }
                else if (instruction[4] == '7')
                {
                    input = processLess(input, index, instruction[2] == '1', instruction[1] == '1');
                    index += 4;
                }
                else if (instruction[4] == '8')
                {
                    input = processEqual(input, index, instruction[2] == '1', instruction[1] == '1');
                    index += 4;
                }
                else if (instruction.EndsWith("99"))
                    break;
                else
                    throw new Exception();
            }
            return input[0];
        }

        private static int processJump(int[] input, int index, bool firstMode, bool secondMode, bool target)
        {
            int first, dest;
            first = firstMode ? input[index + 1] : input[input[index + 1]];
            dest = secondMode ? input[index + 2] : input[input[index + 2]];
            return target ? first != 0 ? dest : index + 3 : first == 0 ? dest : index + 3; 
        }
        private static int[] processLess(int[] input, int index, bool firstMode, bool secondMode)
        {
            int first, second, dest;
            first = firstMode ? input[index + 1] : input[input[index + 1]];
            second = secondMode ? input[index + 2] : input[input[index + 2]];
            dest = input[index + 3];
            input[dest] = first < second ? 1 : 0;
            return input;
        }
        private static int[] processEqual(int[] input, int index, bool firstMode, bool secondMode)
        {
            int first, second, dest;
            first = firstMode ? input[index + 1] : input[input[index + 1]];
            second = secondMode ? input[index + 2] : input[input[index + 2]];
            dest = input[index + 3];
            input[dest] = first == second ? 1 : 0;
            return input;
        }

        static void processOutput(int[] input, int index, bool firstMode)
        {
            if (firstMode)
                Console.WriteLine(input[index + 1]);
            else
                Console.WriteLine(input[input[index + 1]]);
        }

        static int[] processSaveInput(int[] input, int index)
        {
            input[input[index + 1]] = inputParam;
            return input;
        }


        static int[] processAdd(int[] input, int index,bool firstMode,bool secondMode)
        {
            int first, second, dest;
            first = firstMode ? input[index + 1] : input[input[index + 1]];
            second = secondMode ? input[index + 2] : input[input[index + 2]];
            dest = input[index + 3];
            input[dest] = first + second;
            //Console.WriteLine(first);
            //Console.WriteLine(second);
            //Console.WriteLine(input[dest]);
            return input;
        }

        static int[] processMult(int[] input, int index, bool firstMode, bool secondMode)
        {
            int first, second, dest;
            first = firstMode ? input[index + 1] : input[input[index + 1]];
            second = secondMode ? input[index + 2] : input[input[index + 2]];
            dest = input[index + 3];
            input[dest] = first * second;
            //Console.WriteLine(input[dest]);
            return input;
        }
    }
}

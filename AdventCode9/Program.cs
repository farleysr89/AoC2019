﻿using System;
using System.Collections.Generic;

namespace AventCode9
{
    class Program
    {
        static Stack<int> inputParam = new Stack<int> { };

        static void Main(string[] args)
        {
            var input = new long[] { 1102,34463338,34463338,63,1007,63,34463338,63,1005,63,53,1101,3,0,1000,109,988,209,12,9,1000,209,6,209,3,203,0,1008,1000,1,63,1005,63,65,1008,1000,2,63,1005,63,904,1008,1000,0,63,1005,63,58,4,25,104,0,99,4,0,104,0,99,4,17,104,0,99,0,0,1101,0,708,1029,1101,1,0,1021,1102,38,1,1015,1101,25,0,1004,1101,21,0,1018,1102,1,34,1016,1101,0,713,1028,1101,735,0,1024,1101,31,0,1003,1102,1,24,1010,1101,20,0,1011,1101,0,27,1005,1102,726,1,1025,1101,426,0,1027,1101,0,777,1022,1102,1,32,1001,1101,37,0,1009,1101,429,0,1026,1102,1,36,1019,1101,0,0,1020,1101,0,30,1012,1101,0,770,1023,1101,0,35,1014,1101,0,33,1007,1102,23,1,1002,1101,0,28,1017,1102,1,22,1013,1102,39,1,1006,1101,0,26,1000,1101,29,0,1008,109,6,2102,1,-1,63,1008,63,27,63,1005,63,203,4,187,1106,0,207,1001,64,1,64,1002,64,2,64,109,-15,2108,26,9,63,1005,63,225,4,213,1106,0,229,1001,64,1,64,1002,64,2,64,109,9,21101,40,0,10,1008,1010,40,63,1005,63,251,4,235,1106,0,255,1001,64,1,64,1002,64,2,64,109,11,21108,41,40,0,1005,1011,271,1106,0,277,4,261,1001,64,1,64,1002,64,2,64,109,-7,1207,3,32,63,1005,63,297,1001,64,1,64,1105,1,299,4,283,1002,64,2,64,109,3,1201,-1,0,63,1008,63,42,63,1005,63,323,1001,64,1,64,1105,1,325,4,305,1002,64,2,64,109,2,2102,1,-7,63,1008,63,24,63,1005,63,345,1106,0,351,4,331,1001,64,1,64,1002,64,2,64,109,-6,21107,42,43,8,1005,1011,369,4,357,1106,0,373,1001,64,1,64,1002,64,2,64,109,-7,2108,30,7,63,1005,63,393,1001,64,1,64,1106,0,395,4,379,1002,64,2,64,109,18,21108,43,43,-3,1005,1011,413,4,401,1106,0,417,1001,64,1,64,1002,64,2,64,109,17,2106,0,-4,1105,1,435,4,423,1001,64,1,64,1002,64,2,64,109,-29,2107,26,2,63,1005,63,451,1105,1,457,4,441,1001,64,1,64,1002,64,2,64,109,20,1206,-2,471,4,463,1105,1,475,1001,64,1,64,1002,64,2,64,109,-9,1205,8,489,4,481,1105,1,493,1001,64,1,64,1002,64,2,64,109,-12,1202,-1,1,63,1008,63,26,63,1005,63,515,4,499,1105,1,519,1001,64,1,64,1002,64,2,64,109,25,1205,-6,531,1106,0,537,4,525,1001,64,1,64,1002,64,2,64,109,-31,1208,8,31,63,1005,63,555,4,543,1106,0,559,1001,64,1,64,1002,64,2,64,109,13,1207,1,38,63,1005,63,577,4,565,1106,0,581,1001,64,1,64,1002,64,2,64,109,4,21101,44,0,1,1008,1013,47,63,1005,63,605,1001,64,1,64,1106,0,607,4,587,1002,64,2,64,109,-6,2107,38,0,63,1005,63,629,4,613,1001,64,1,64,1106,0,629,1002,64,2,64,109,13,21102,45,1,-7,1008,1012,45,63,1005,63,655,4,635,1001,64,1,64,1105,1,655,1002,64,2,64,109,9,1206,-7,667,1106,0,673,4,661,1001,64,1,64,1002,64,2,64,109,-27,2101,0,7,63,1008,63,29,63,1005,63,699,4,679,1001,64,1,64,1106,0,699,1002,64,2,64,109,17,2106,0,10,4,705,1106,0,717,1001,64,1,64,1002,64,2,64,109,14,2105,1,-8,4,723,1001,64,1,64,1106,0,735,1002,64,2,64,109,-21,1202,-8,1,63,1008,63,34,63,1005,63,755,1105,1,761,4,741,1001,64,1,64,1002,64,2,64,109,18,2105,1,-6,1001,64,1,64,1106,0,779,4,767,1002,64,2,64,109,-15,1201,-6,0,63,1008,63,29,63,1005,63,801,4,785,1105,1,805,1001,64,1,64,1002,64,2,64,109,-14,1208,0,24,63,1005,63,825,1001,64,1,64,1106,0,827,4,811,1002,64,2,64,109,15,21102,46,1,-2,1008,1013,49,63,1005,63,847,1106,0,853,4,833,1001,64,1,64,1002,64,2,64,109,-17,2101,0,2,63,1008,63,23,63,1005,63,873,1106,0,879,4,859,1001,64,1,64,1002,64,2,64,109,16,21107,47,46,2,1005,1016,899,1001,64,1,64,1105,1,901,4,885,4,64,99,21101,0,27,1,21101,0,915,0,1106,0,922,21201,1,55486,1,204,1,99,109,3,1207,-2,3,63,1005,63,964,21201,-2,-1,1,21102,942,1,0,1105,1,922,22102,1,1,-1,21201,-2,-3,1,21101,0,957,0,1105,1,922,22201,1,-1,-2,1105,1,968,22101,0,-2,-2,109,-3,2106,0,0 };
            //var input = new long[] { 109, 1, 204, -1, 1001, 100, 1, 100, 1008, 100, 16, 101, 1006, 101, 0, 99 };
            Array.Resize(ref input, 10000);
            Computer comp = new Computer(input);
            comp.stackPush(2);
            comp.start();

        }
    }

        public class Computer
    {
        public long[] instructions;
        public Stack<long> input = new Stack<long>();
        public int index = 0;
        public int relativeBase = 0;

        public Computer(long[] instructions)
        {
            this.instructions = instructions;
        }

        public void start()
        {
            processInput();
        }

        public void stackPush(int i)
        {
            input.Push(i);
        }

        public void processInput()
        {
            while (true)
            {
                var instruction = instructions[index].ToString("D5");
                if (instruction[4] == '1')
                    processAdd(instruction[2], instruction[1], instruction[0]);
                else if (instruction[4] == '2')
                    processMult(instruction[2], instruction[1], instruction[0]);
                else if (instruction[4] == '3')
                    processSaveInput(instruction[2]);
                else if (instruction[4] == '4')
                    processOutput(instruction[2]);
                else if (instruction[4] == '5')
                    processJump(instruction[2], instruction[1], true);
                else if (instruction[4] == '6')
                    processJump(instruction[2], instruction[1], false);
                else if (instruction[4] == '7')
                    processLess(instruction[2], instruction[1], instruction[0]);
                else if (instruction[4] == '8')
                    processEqual(instruction[2], instruction[1], instruction[0]);
                else if (instruction.EndsWith("09"))
                    processRelInc(instruction[2]);
                else if (instruction.EndsWith("99"))
                    break;
                else
                    throw new Exception();
            }
        }

        private void processRelInc(char firstMode)
        {
            if (firstMode == '1')
                relativeBase += (int)(instructions[index + 1]);
            else if (firstMode == '2')
                relativeBase += (int)(instructions[instructions[index + 1] + relativeBase]);
            else
                relativeBase += (int)(instructions[instructions[index + 1]]);
            index += 2;
        }

        private void processJump(char firstMode, char secondMode, bool target)
        {
            long first, dest;
            first = firstMode == '1' ? instructions[index + 1] : firstMode == '0' ? instructions[instructions[index + 1]] : instructions[instructions[index + 1]+ relativeBase];
            dest = secondMode == '1' ? instructions[index + 2] : secondMode == '0' ? instructions[instructions[index + 2]] : instructions[instructions[index + 2] + relativeBase];
            index = (int)(target ? first != 0 ? dest : index + 3 : first == 0 ? dest : index + 3);
        }
        private void processLess(char firstMode, char secondMode, char thirdMode)
        {
            long first, second, dest;
            first = firstMode == '1' ? instructions[index + 1] : firstMode == '0' ? instructions[instructions[index + 1]] : instructions[instructions[index + 1] + relativeBase];
            second = secondMode == '1' ? instructions[index + 2] : secondMode == '0' ? instructions[instructions[index + 2]] : instructions[instructions[index + 2] + relativeBase];
            dest = thirdMode == '0' ? instructions[index + 3] : instructions[index + 3] + relativeBase;
            instructions[dest] = first < second ? 1 : 0;
            index += 4;
        }
        private void processEqual(char firstMode, char secondMode, char thirdMode)
        {
            long first, second, dest;
            first = firstMode == '1' ? instructions[index + 1] : firstMode == '0' ? instructions[instructions[index + 1]] : instructions[instructions[index + 1] + relativeBase];
            second = secondMode == '1' ? instructions[index + 2] : secondMode == '0' ? instructions[instructions[index + 2]] : instructions[instructions[index + 2] + relativeBase];
            dest = thirdMode == '0' ? instructions[index + 3] : instructions[index + 3] + relativeBase;
            instructions[dest] = first == second ? 1 : 0;
            index += 4;
        }

        void processOutput(char firstMode)
        {
            if (firstMode == '1')
                Console.WriteLine(instructions[index + 1]);
            if (firstMode == '2')
                Console.WriteLine(instructions[instructions[index + 1] + relativeBase]);
            else
                Console.WriteLine(instructions[instructions[index + 1]]);
            index += 2;
        }

        void processSaveInput(char firstMode)
        {
            if (firstMode == '0')
                instructions[instructions[index + 1]] = input.Pop();
            else
                instructions[instructions[index + 1] + relativeBase] = input.Pop();
            index += 2;
        }


        void processAdd(char firstMode, char secondMode, char thirdMode)
        {
            long first, second, dest;
            first = firstMode == '1' ? instructions[index + 1] : firstMode == '0' ? instructions[instructions[index + 1]] : instructions[instructions[index + 1] + relativeBase];
            second = secondMode == '1' ? instructions[index + 2] : secondMode == '0' ? instructions[instructions[index + 2]] : instructions[instructions[index + 2] + relativeBase];
            dest = thirdMode == '0' ? instructions[index + 3] : instructions[index + 3] + relativeBase;
            instructions[dest] = first + second;
            index += 4;
        }

        void processMult(char firstMode, char secondMode, char thirdMode)
        {
            long first, second, dest;
            first = firstMode == '1' ? instructions[index + 1] : firstMode == '0' ? instructions[instructions[index + 1]] : instructions[instructions[index + 1] + relativeBase];
            second = secondMode == '1' ? instructions[index + 2] : secondMode == '0' ? instructions[instructions[index + 2]] : instructions[instructions[index + 2] + relativeBase];
            dest = thirdMode == '0' ? instructions[index + 3] : instructions[index + 3] + relativeBase;
            instructions[dest] = first * second;
            index += 4;
        }
    }
}


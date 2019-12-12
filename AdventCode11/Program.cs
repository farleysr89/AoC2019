using System;
using System.Collections.Generic;

namespace AventCode11
{
    class Program
    {
        static Stack<int> inputParam = new Stack<int> { };

        static void Main(string[] args)
        {
            var input = new long[] { 3, 8, 1005, 8, 311, 1106, 0, 11, 0, 0, 0, 104, 1, 104, 0, 3, 8, 1002, 8, -1, 10, 101, 1, 10, 10, 4, 10, 108, 0, 8, 10, 4, 10, 1002, 8, 1, 28, 2, 103, 7, 10, 3, 8, 1002, 8, -1, 10, 101, 1, 10, 10, 4, 10, 1008, 8, 1, 10, 4, 10, 1001, 8, 0, 55, 2, 3, 6, 10, 1, 101, 5, 10, 1, 6, 7, 10, 3, 8, 1002, 8, -1, 10, 101, 1, 10, 10, 4, 10, 1008, 8, 0, 10, 4, 10, 1001, 8, 0, 89, 1, 1108, 11, 10, 2, 1002, 13, 10, 1006, 0, 92, 1, 2, 13, 10, 3, 8, 102, -1, 8, 10, 1001, 10, 1, 10, 4, 10, 1008, 8, 0, 10, 4, 10, 101, 0, 8, 126, 3, 8, 1002, 8, -1, 10, 101, 1, 10, 10, 4, 10, 108, 1, 8, 10, 4, 10, 1002, 8, 1, 147, 1, 7, 0, 10, 3, 8, 1002, 8, -1, 10, 1001, 10, 1, 10, 4, 10, 108, 0, 8, 10, 4, 10, 101, 0, 8, 173, 1006, 0, 96, 3, 8, 102, -1, 8, 10, 101, 1, 10, 10, 4, 10, 108, 0, 8, 10, 4, 10, 1001, 8, 0, 198, 1, 3, 7, 10, 1006, 0, 94, 2, 1003, 20, 10, 3, 8, 102, -1, 8, 10, 1001, 10, 1, 10, 4, 10, 1008, 8, 1, 10, 4, 10, 102, 1, 8, 232, 3, 8, 102, -1, 8, 10, 101, 1, 10, 10, 4, 10, 108, 1, 8, 10, 4, 10, 102, 1, 8, 253, 1006, 0, 63, 1, 109, 16, 10, 3, 8, 1002, 8, -1, 10, 101, 1, 10, 10, 4, 10, 1008, 8, 1, 10, 4, 10, 101, 0, 8, 283, 2, 1107, 14, 10, 1, 105, 11, 10, 101, 1, 9, 9, 1007, 9, 1098, 10, 1005, 10, 15, 99, 109, 633, 104, 0, 104, 1, 21102, 837951005592, 1, 1, 21101, 328, 0, 0, 1105, 1, 432, 21101, 0, 847069840276, 1, 21101, 0, 339, 0, 1106, 0, 432, 3, 10, 104, 0, 104, 1, 3, 10, 104, 0, 104, 0, 3, 10, 104, 0, 104, 1, 3, 10, 104, 0, 104, 1, 3, 10, 104, 0, 104, 0, 3, 10, 104, 0, 104, 1, 21102, 179318123543, 1, 1, 21102, 386, 1, 0, 1106, 0, 432, 21102, 1, 29220688067, 1, 21102, 1, 397, 0, 1106, 0, 432, 3, 10, 104, 0, 104, 0, 3, 10, 104, 0, 104, 0, 21102, 709580567396, 1, 1, 21102, 1, 420, 0, 1105, 1, 432, 21102, 1, 868498694912, 1, 21102, 431, 1, 0, 1106, 0, 432, 99, 109, 2, 22101, 0, -1, 1, 21101, 40, 0, 2, 21101, 0, 463, 3, 21101, 0, 453, 0, 1105, 1, 496, 109, -2, 2106, 0, 0, 0, 1, 0, 0, 1, 109, 2, 3, 10, 204, -1, 1001, 458, 459, 474, 4, 0, 1001, 458, 1, 458, 108, 4, 458, 10, 1006, 10, 490, 1102, 1, 0, 458, 109, -2, 2105, 1, 0, 0, 109, 4, 1202, -1, 1, 495, 1207, -3, 0, 10, 1006, 10, 513, 21102, 0, 1, -3, 21201, -3, 0, 1, 21202, -2, 1, 2, 21101, 0, 1, 3, 21101, 0, 532, 0, 1106, 0, 537, 109, -4, 2106, 0, 0, 109, 5, 1207, -3, 1, 10, 1006, 10, 560, 2207, -4, -2, 10, 1006, 10, 560, 22102, 1, -4, -4, 1105, 1, 628, 21201, -4, 0, 1, 21201, -3, -1, 2, 21202, -2, 2, 3, 21101, 0, 579, 0, 1105, 1, 537, 22101, 0, 1, -4, 21102, 1, 1, -1, 2207, -4, -2, 10, 1006, 10, 598, 21102, 1, 0, -1, 22202, -2, -1, -2, 2107, 0, -3, 10, 1006, 10, 620, 22102, 1, -1, 1, 21101, 0, 620, 0, 106, 0, 495, 21202, -2, -1, -2, 22201, -4, -2, -4, 109, -5, 2106, 0, 0 };
            //var input = new long[] { 3,100,104,1,104,0,3,100,104,0,104,0,3,100,104,1,104,0,3,100,104,1,104,0,3,100,104,0,104,1,3,100,104,1,104,0,3,100,104,1,104,0,99 };
            Array.Resize(ref input, 10000);
            Computer comp = new Computer(input);
            comp.stackPush(1);
            comp.start();

        }
    }

    public class Computer
    {
        public long[] instructions;
        public Stack<long> input = new Stack<long>();
        public int index = 0;
        public int relativeBase = 0;
        public int x = 50;
        public int y = 50;
        public int[,] squares = new int[100,100];
        int dir = 0;
        bool flag = false;
        //string path = "";
        HashSet<(int, int)> painted = new HashSet<(int, int)>();
        HashSet<(int, int)> whiteSpaces = new HashSet<(int, int)>();


        public Computer(long[] instructions)
        {
            this.instructions = instructions;
        }

        public void start()
        {
            processInput();
            Console.WriteLine(painted.Count);
            //Console.WriteLine(path);
            foreach(int i in squares)
            {
                Console.Write(i);
            }
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
            first = firstMode == '1' ? instructions[index + 1] : firstMode == '0' ? instructions[instructions[index + 1]] : instructions[instructions[index + 1] + relativeBase];
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
            int a;
            if (firstMode == '1')
                a = ((int)(instructions[index + 1]));
            else if (firstMode == '2')
                a = ((int)(instructions[instructions[index + 1] + relativeBase]));
            else
                a = ((int)(instructions[instructions[index + 1]]));
            if (flag)
            {
                flag = false;
                if(a == 0)
                    a = -1;
                //Console.WriteLine("Change = " + a);
                dir += a;
                if (dir < 0)
                    dir = 3;
                if(dir > 3)
                    dir = 0;
                //Console.WriteLine("NewDir = " + dir);
                switch (dir)
                {
                    case 0:
                        y += 1;
                        break;
                    case 1:
                        x += 1;
                        break;
                    case 2:
                        y -= 1;
                        break;
                    case 3:
                        x -= 1;
                        break;
                    default:
                        Console.WriteLine("BROKEN");
                        break;
                }
                //path += x + " " + y + " | ";
                stackPush(whiteSpaces.Contains((x, y)) ? 1 : 0);
            }
            else
            {
                flag = true;
                if(a == 1)
                {
                    whiteSpaces.Add((x, y));
                    squares[x, y] = 1;
                }
                else
                {
                    if (whiteSpaces.Contains((x, y)))
                        whiteSpaces.Remove((x, y));
                    squares[x, y] = 0;
                }
                painted.Add((x, y));
            }
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


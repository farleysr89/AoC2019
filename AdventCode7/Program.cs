using System;
using System.Collections.Generic;

namespace AventCode7
{
    class Program
    {
        static Stack<int> inputParam = new Stack<int> { };

        static void Main(string[] args)
        {
            var input = new int[] { 3,8,1001,8,10,8,105,1,0,0,21,34,51,68,89,98,179,260,341,422,99999,3,9,1001,9,4,9,102,4,9,9,4,9,99,3,9,1002,9,5,9,1001,9,2,9,1002,9,2,9,4,9,99,3,9,1001,9,3,9,102,3,9,9,101,4,9,9,4,9,99,3,9,102,2,9,9,101,2,9,9,1002,9,5,9,1001,9,2,9,4,9,99,3,9,102,2,9,9,4,9,99,3,9,101,2,9,9,4,9,3,9,102,2,9,9,4,9,3,9,1002,9,2,9,4,9,3,9,1002,9,2,9,4,9,3,9,1001,9,2,9,4,9,3,9,1001,9,2,9,4,9,3,9,102,2,9,9,4,9,3,9,1002,9,2,9,4,9,3,9,1002,9,2,9,4,9,3,9,1001,9,1,9,4,9,99,3,9,1001,9,1,9,4,9,3,9,102,2,9,9,4,9,3,9,1001,9,1,9,4,9,3,9,1001,9,1,9,4,9,3,9,1001,9,1,9,4,9,3,9,1001,9,2,9,4,9,3,9,101,1,9,9,4,9,3,9,1002,9,2,9,4,9,3,9,101,1,9,9,4,9,3,9,1001,9,2,9,4,9,99,3,9,101,2,9,9,4,9,3,9,1002,9,2,9,4,9,3,9,1002,9,2,9,4,9,3,9,1001,9,2,9,4,9,3,9,1002,9,2,9,4,9,3,9,1001,9,1,9,4,9,3,9,1001,9,1,9,4,9,3,9,1002,9,2,9,4,9,3,9,1002,9,2,9,4,9,3,9,102,2,9,9,4,9,99,3,9,1001,9,1,9,4,9,3,9,102,2,9,9,4,9,3,9,1001,9,1,9,4,9,3,9,1002,9,2,9,4,9,3,9,1001,9,1,9,4,9,3,9,1001,9,1,9,4,9,3,9,1001,9,2,9,4,9,3,9,102,2,9,9,4,9,3,9,101,2,9,9,4,9,3,9,101,2,9,9,4,9,99,3,9,1002,9,2,9,4,9,3,9,1001,9,2,9,4,9,3,9,101,2,9,9,4,9,3,9,102,2,9,9,4,9,3,9,1001,9,2,9,4,9,3,9,101,2,9,9,4,9,3,9,1001,9,2,9,4,9,3,9,102,2,9,9,4,9,3,9,1002,9,2,9,4,9,3,9,101,1,9,9,4,9,99 };
            //int maxThrust = 0;
            ////var input = new int[] { 3, 15, 3, 16, 1002, 16, 10, 16, 1, 16, 15, 15, 4, 15, 99, 0, 0 };

            //inputParam.Push(0);

            //inputParam.Push(4);

            ////Console.WriteLine(input[31]);
            //processInput((int[])input.Clone());
            ////int tmp = inputParam.Pop();
            ////Console.WriteLine(tmp);
            ////inputParam.Push(tmp);
            //inputParam.Push(3);
            ////Console.WriteLine(input[31]);
            //processInput((int[])input.Clone());
            ////tmp = inputParam.Pop();
            ////Console.WriteLine(tmp);
            ////inputParam.Push(tmp);
            //inputParam.Push(2);
            ////Console.WriteLine(input[31]);
            //processInput((int[])input.Clone());
            ////tmp = inputParam.Pop();
            ////Console.WriteLine(tmp);
            ////inputParam.Push(tmp);
            //inputParam.Push(1);
            ////Console.WriteLine(input[31]);
            //processInput((int[])input.Clone());
            ////tmp = inputParam.Pop();
            ////Console.WriteLine(tmp);
            ////inputParam.Push(tmp);
            //inputParam.Push(0);
            ////Console.WriteLine(input[31]);
            //processInput((int[])input.Clone());

            ////Console.WriteLine(input[31]);

            //Console.WriteLine(inputParam.Pop());
            ////Console.WriteLine(input[2]);
            Console.WriteLine(testAmps((int[])input.Clone()));
        }

        static int testAmps(int[] input)
        {
            int maxThrust = 0;
            for(int i = 0;i < 5; i++){
                inputParam.Push(0);
                inputParam.Push(i);
                processInput((int[])input.Clone());
                int iOut = inputParam.Pop();
                for(int j = 0;j < 5; j++)
                {
                    if(j==i)
                        continue;
                    inputParam.Push(iOut);
                    inputParam.Push(j);
                    processInput((int[])input.Clone());
                    int jOut = inputParam.Pop();
                    for (int k = 0; k < 5; k++)
                    {
                        if (k == i || k == j)
                            continue;
                        inputParam.Push(jOut);
                        inputParam.Push(k);
                        processInput((int[])input.Clone());
                        int kOut = inputParam.Pop();
                        for (int l = 0; l < 5; l++)
                        {
                            if (l == i || l == j || l == k)
                                continue;
                            inputParam.Push(kOut);
                            inputParam.Push(l);
                            processInput((int[])input.Clone());
                            int lOut = inputParam.Pop();
                            for (int m = 0; m < 5; m++)
                            {
                                if (m == i || m == j || m == k || m == l)
                                    continue;
                                inputParam.Push(lOut);
                                inputParam.Push(m);
                                processInput((int[])input.Clone());
                                int tmpMax = inputParam.Pop();
                                if (tmpMax > maxThrust)
                                    maxThrust = tmpMax;
                            }
                        }
                    }
                }
            }
            return maxThrust;
        }

        public static int processInput(int[] input)
        {
            var index = 0;

            while (true)
            {
                var instruction = input[index].ToString("D5");
                if (instruction[4] == '1')
                {
                    input = processAdd(input, index, instruction[2] == '1', instruction[1] == '1');
                    index += 4;
                }
                else if (instruction[4] == '2')
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
                    index = processJump(input, index, instruction[2] == '1', instruction[1] == '1', true);
                }
                else if (instruction[4] == '6')
                {
                    index = processJump(input, index, instruction[2] == '1', instruction[1] == '1', false);
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
            //foreach(int i in input)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine("________________");
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
                inputParam.Push(input[index + 1]);
            else
                inputParam.Push(input[input[index + 1]]);
        }

        static int[] processSaveInput(int[] input, int index)
        {
            input[input[index + 1]] = inputParam.Pop();
            return input;
        }


        static int[] processAdd(int[] input, int index, bool firstMode, bool secondMode)
        {
            int first, second, dest;
            first = firstMode ? input[index + 1] : input[input[index + 1]];
            second = secondMode ? input[index + 2] : input[input[index + 2]];
            dest = input[index + 3];
            input[dest] = first + second;
            return input;
        }

        static int[] processMult(int[] input, int index, bool firstMode, bool secondMode)
        {
            int first, second, dest;
            first = firstMode ? input[index + 1] : input[input[index + 1]];
            second = secondMode ? input[index + 2] : input[input[index + 2]];
            dest = input[index + 3];
            input[dest] = first * second;
            //Console.WriteLine(first + " " + second);
            return input;
        }
    }

    public class Amp
    {
        public int[] instructions;
        public Stack<int> input;
        public Amp child;
        public int index = 0;

        public Amp(int[] instructions, Stack<int> input)
        {
            this.instructions = instructions;
            this.input = input;            
        }

        public void setChild(Amp child)
        {
            this.child = child;
        }

        public int processInput(int[] input)
        {
            int tmp = 0;
            while (true)
            {
                var instruction = input[index].ToString("D5");
                if (instruction[4] == '1')
                {
                    processAdd(instruction[2] == '1', instruction[1] == '1');
                    index += 4;
                }
                else if (instruction[4] == '2')
                {
                    processMult(instruction[2] == '1', instruction[1] == '1');
                    index += 4;
                }
                else if (instruction[4] == '3')
                {
                    processSaveInput();
                    index += 2;
                }
                else if (instruction[4] == '4')
                {
                    tmp = processOutput(instruction[2] == '1');
                    index += 2;

                }
                else if (instruction[4] == '5')
                {
                    index = processJump(instruction[2] == '1', instruction[1] == '1', true);
                }
                else if (instruction[4] == '6')
                {
                    index = processJump(instruction[2] == '1', instruction[1] == '1', false);
                }
                else if (instruction[4] == '7')
                {
                    processLess(instruction[2] == '1', instruction[1] == '1');
                    index += 4;
                }
                else if (instruction[4] == '8')
                {
                    processEqual(instruction[2] == '1', instruction[1] == '1');
                    index += 4;
                }
                else if (instruction.EndsWith("99"))
                    break;
                else
                    throw new Exception();
            }
            return tmp;
        }

        private int processJump(bool firstMode, bool secondMode, bool target)
        {
            int first, dest;
            first = firstMode ? instructions[index + 1] : instructions[instructions[index + 1]];
            dest = secondMode ? instructions[index + 2] : instructions[instructions[index + 2]];
            return target ? first != 0 ? dest : index + 3 : first == 0 ? dest : index + 3;
        }
        private void processLess(bool firstMode, bool secondMode)
        {
            int first, second, dest;
            first = firstMode ? instructions[index + 1] : instructions[instructions[index + 1]];
            second = secondMode ? instructions[index + 2] : instructions[instructions[index + 2]];
            dest = instructions[index + 3];
        }
        private void processEqual(bool firstMode, bool secondMode)
        {
            int first, second, dest;
            first = firstMode ? instructions[index + 1] : instructions[instructions[index + 1]];
            second = secondMode ? instructions[index + 2] : instructions[instructions[index + 2]];
            dest = instructions[index + 3];
            instructions[dest] = first == second ? 1 : 0;
        }

        int processOutput(bool firstMode)
        {
            if (firstMode)
                return (instructions[index + 1]);
            else
                return (instructions[instructions[index + 1]]);
        }

        void processSaveInput()
        {
            instructions[instructions[index + 1]] = input.Pop();
        }


        void processAdd(bool firstMode, bool secondMode)
        {
            int first, second, dest;
            first = firstMode ? instructions[index + 1] : instructions[instructions[index + 1]];
            second = secondMode ? instructions[index + 2] : instructions[instructions[index + 2]];
            dest = instructions[index + 3];
            instructions[dest] = first + second;
        }

        void processMult(bool firstMode, bool secondMode)
        {
            int first, second, dest;
            first = firstMode ? instructions[index + 1] : instructions[instructions[index + 1]];
            second = secondMode ? instructions[index + 2] : instructions[instructions[index + 2]];
            dest = instructions[index + 3];
            instructions[dest] = first * second;
            //Console.WriteLine(first + " " + second);
        }
    }
}


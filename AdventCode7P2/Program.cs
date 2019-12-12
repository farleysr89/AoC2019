using System;
using System.Collections.Generic;

namespace AventCode7P2
{
    class Program
    {
        static Stack<int> inputParam = new Stack<int> { };

        static void Main(string[] args)
        {
            var input = new int[] { 3, 8, 1001, 8, 10, 8, 105, 1, 0, 0, 21, 34, 51, 68, 89, 98, 179, 260, 341, 422, 99999, 3, 9, 1001, 9, 4, 9, 102, 4, 9, 9, 4, 9, 99, 3, 9, 1002, 9, 5, 9, 1001, 9, 2, 9, 1002, 9, 2, 9, 4, 9, 99, 3, 9, 1001, 9, 3, 9, 102, 3, 9, 9, 101, 4, 9, 9, 4, 9, 99, 3, 9, 102, 2, 9, 9, 101, 2, 9, 9, 1002, 9, 5, 9, 1001, 9, 2, 9, 4, 9, 99, 3, 9, 102, 2, 9, 9, 4, 9, 99, 3, 9, 101, 2, 9, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9, 1001, 9, 2, 9, 4, 9, 3, 9, 1001, 9, 2, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9, 1001, 9, 1, 9, 4, 9, 99, 3, 9, 1001, 9, 1, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 1001, 9, 1, 9, 4, 9, 3, 9, 1001, 9, 1, 9, 4, 9, 3, 9, 1001, 9, 1, 9, 4, 9, 3, 9, 1001, 9, 2, 9, 4, 9, 3, 9, 101, 1, 9, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9, 101, 1, 9, 9, 4, 9, 3, 9, 1001, 9, 2, 9, 4, 9, 99, 3, 9, 101, 2, 9, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9, 1001, 9, 2, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9, 1001, 9, 1, 9, 4, 9, 3, 9, 1001, 9, 1, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 99, 3, 9, 1001, 9, 1, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 1001, 9, 1, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9, 1001, 9, 1, 9, 4, 9, 3, 9, 1001, 9, 1, 9, 4, 9, 3, 9, 1001, 9, 2, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 101, 2, 9, 9, 4, 9, 3, 9, 101, 2, 9, 9, 4, 9, 99, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9, 1001, 9, 2, 9, 4, 9, 3, 9, 101, 2, 9, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 1001, 9, 2, 9, 4, 9, 3, 9, 101, 2, 9, 9, 4, 9, 3, 9, 1001, 9, 2, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9, 101, 1, 9, 9, 4, 9, 99 };
            //var input = new int[] {3,52,1001,52,-5,52,3,53,1,52,56,54,1007,54,5,55,1005,55,26,1001,54,
            //-5,54,1105,1,12,1,53,54,53,1008,54,0,55,1001,55,1,55,2,53,55,53,4,
            //53,1001,56,-1,56,1005,56,6,99,0,0,0,0,10 };
            int maxThrust = 0;
            for(int i = 5;i < 10; i++)
            {
                for (int j = 5; j < 10; j++)
                {
                    if (j == i)
                        continue;
                    for (int k = 5; k < 10; k++)
                    {
                        if (k == j || k == i)
                            continue;
                        for (int l = 5; l < 10; l++)
                        {
                            if (l == i || l == k || l == j)
                                continue;
                            for (int m = 5; m < 10; m++)
                            {
                                if (m == i || m == j || m == k || m == l)
                                    continue;
                                int tmp = testAmpCombo(i, j, k, l, m, (int[])input.Clone());
                                maxThrust = Math.Max(tmp, maxThrust);
                            }
                        }
                    }
                }
            }
            Console.WriteLine(maxThrust);

        }        

        public static int testAmpCombo(int i,int j, int k, int l, int m, int[] input)
        {
            Amp a = new Amp((int[])input.Clone());
            a.stackPush(0);
            a.stackPush(i);
            Amp b = new Amp((int[])input.Clone());
            Amp c = new Amp((int[])input.Clone());
            Amp d = new Amp((int[])input.Clone());
            Amp e = new Amp((int[])input.Clone());
            a.setChild(b);
            b.setChild(c);
            c.setChild(d);
            d.setChild(e);
            e.setChild(a);

            int ret = 0;
            ret = a.start();
            a.child.stackPush(ret);
            b.stackPush(j);
            ret = b.start();
            b.child.stackPush(ret);
            c.stackPush(k);
            ret = c.start();
            c.child.stackPush(ret);
            d.stackPush(l);
            ret = d.start();
            d.child.stackPush(ret);
            e.stackPush(m);
            ret = e.start();
            e.child.stackPush(ret);


            while (!e.hit99)
            {
                ret = a.start();
                a.child.stackPush(ret);
                ret = b.start();
                b.child.stackPush(ret);
                ret = c.start();
                c.child.stackPush(ret);
                ret = d.start();
                d.child.stackPush(ret);
                ret = e.start();
                e.child.stackPush(ret);
            }
            return ret;
        }

    }

    public class Amp
    {
        public int[] instructions;
        public Stack<int> input = new Stack<int>();
        public Amp child;
        public int index = 0;
        public int output;
        public bool hit99 = false;

        public Amp(int[] instructions)
        {
            this.instructions = instructions;
        }

        public int start()
        {
            processInput();
            //Console.WriteLine(output);
            return output;
        }

        public void stackPush(int i)
        {
            input.Push(i);
        }
        public void setChild(Amp child)
        {
            this.child = child;
        }

        public void processInput()
        {
            while (true)
            {
                //Console.WriteLine(index);
                var instruction = instructions[index].ToString("D5");
                if (instruction[4] == '1')
                    processAdd(instruction[2] == '1', instruction[1] == '1');
                else if (instruction[4] == '2')
                    processMult(instruction[2] == '1', instruction[1] == '1');
                else if (instruction[4] == '3')
                    processSaveInput();
                else if (instruction[4] == '4')
                {
                    processOutput(instruction[2] == '1');
                    break;
                }
                else if (instruction[4] == '5')
                    processJump(instruction[2] == '1', instruction[1] == '1', true);
                else if (instruction[4] == '6')
                    processJump(instruction[2] == '1', instruction[1] == '1', false);
                else if (instruction[4] == '7')
                    processLess(instruction[2] == '1', instruction[1] == '1');
                else if (instruction[4] == '8')
                    processEqual(instruction[2] == '1', instruction[1] == '1');
                else if (instruction.EndsWith("99"))
                {
                    hit99 = true;
                    //Console.WriteLine("DONE");
                    break;
                }
                else
                    throw new Exception();
            }
            //Console.WriteLine(output);
        }

        private void processJump(bool firstMode, bool secondMode, bool target)
        {
            int first, dest;
            first = firstMode ? instructions[index + 1] : instructions[instructions[index + 1]];
            dest = secondMode ? instructions[index + 2] : instructions[instructions[index + 2]];
            index = target ? first != 0 ? dest : index + 3 : first == 0 ? dest : index + 3;
        }
        private void processLess(bool firstMode, bool secondMode)
        {
            int first, second, dest;
            first = firstMode ? instructions[index + 1] : instructions[instructions[index + 1]];
            second = secondMode ? instructions[index + 2] : instructions[instructions[index + 2]];
            dest = instructions[index + 3];
            instructions[dest] = first < second ? 1 : 0;
            index += 4;
        }
        private void processEqual(bool firstMode, bool secondMode)
        {
            int first, second, dest;
            first = firstMode ? instructions[index + 1] : instructions[instructions[index + 1]];
            second = secondMode ? instructions[index + 2] : instructions[instructions[index + 2]];
            dest = instructions[index + 3];
            instructions[dest] = first == second ? 1 : 0;
            index += 4;
        }

        void processOutput(bool firstMode)
        {
            if (firstMode)
                output = instructions[index + 1];
            else
                output = instructions[instructions[index + 1]];
            index += 2;
        }

        void processSaveInput()
        {
            instructions[instructions[index + 1]] = input.Pop();
            index += 2;
        }


        void processAdd(bool firstMode, bool secondMode)
        {
            int first, second, dest;
            first = firstMode ? instructions[index + 1] : instructions[instructions[index + 1]];
            second = secondMode ? instructions[index + 2] : instructions[instructions[index + 2]];
            dest = instructions[index + 3];
            instructions[dest] = first + second;
            index += 4;
        }

        void processMult(bool firstMode, bool secondMode)
        {
            int first, second, dest;
            first = firstMode ? instructions[index + 1] : instructions[instructions[index + 1]];
            second = secondMode ? instructions[index + 2] : instructions[instructions[index + 2]];
            dest = instructions[index + 3];
            instructions[dest] = first * second;
            index += 4;
            //Console.WriteLine(first + " " + second);
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventCode10
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new string[] {"#...##.####.#.......#.##..##.#.",
                                      "#.##.#..#..#...##..##.##.#.....",
                                      "#..#####.#......#..#....#.###.#",
                                      "...#.#.#...#..#.....#..#..#.#..",
                                      ".#.....##..#...#..#.#...##.....",
                                      "##.....#..........##..#......##",
                                      ".##..##.#.#....##..##.......#..",
                                      "#.##.##....###..#...##...##....",
                                      "##.#.#............##..#...##..#",
                                      "###..##.###.....#.##...####....",
                                      "...##..#...##...##..#.#..#...#.",
                                      "..#.#.##.#.#.#####.#....####.#.",
                                      "#......###.##....#...#...#...##",
                                      ".....#...#.#.#.#....#...#......",
                                      "#..#.#.#..#....#..#...#..#..##.",
                                      "#.....#..##.....#...###..#..#.#",
                                      ".....####.#..#...##..#..#..#..#",
                                      "..#.....#.#........#.#.##..####",
                                      ".#.....##..#.##.....#...###....",
                                      "###.###....#..#..#.....#####...",
                                      "#..##.##..##.#.#....#.#......#.",
                                      ".#....#.##..#.#.#.......##.....",
                                      "##.##...#...#....###.#....#....",
                                      ".....#.######.#.#..#..#.#.....#",
                                      ".#..#.##.#....#.##..#.#...##..#",
                                      ".##.###..#..#..#.###...#####.#.",
                                      "#...#...........#.....#.......#",
                                      "#....##.#.#..##...#..####...#..",
                                      "#.####......#####.....#.##..#..",
                                      ".#...#....#...##..##.#.#......#",
                                      "#..###.....##.#.......#.##...##"};
            //var input = new string[] {".#..#",
            //                          ".....",
            //                          "#####",
            //                          "....#",
            //                          "...##",};
            //var input = new string[] {"......#.#.",
            //                          "#..#.#....",
            //                          "..#######.",
            //                          ".#.#.###..",
            //                          ".#..#.....",
            //                          "..#....#.#",
            //                          "#..#....#.",
            //                          ".##.#..###",
            //                          "##...#..#.",
            //                          ".#....####"};
            //var input = new string[] {".#..#..###",
            //                          "####.###.#",
            //                          "....###.#.",
            //                          "..###.##.#",
            //                          "##.##.#.#.",
            //                          "....###..#",
            //                          "..#.#..#.#",
            //                          "#..#.#.###",
            //                          ".##...##.#",
            //                          ".....#.#.."};
            //var input = new string[] {".#..##.###...#######",
            //                          "##.############..##.",
            //                          ".#.######.########.#",
            //                          ".###.#######.####.#.",
            //                          "#####.##.#.##.###.##",
            //                          "..#####..#.#########",
            //                          "####################",
            //                          "#.####....###.#.#.##",
            //                          "##.#################",
            //                          "#####.##.###..####..",
            //                          "..######..##.#######",
            //                          "####.##.####...##..#",
            //                          ".#####..#.######.###",
            //                          "##...#.##########...",
            //                          "#.##########.#######",
            //                          ".####.#.###.###.#.##",
            //                          "....##.##.###..#####",
            //                          ".#.#.###########.###",
            //                          "#.#.#.#####.####.###",
            //                          "###.##.####.##.#..##"};
            var asteroids = new List<Asteroid>();
            int row = 0;
            int count = 0;
            foreach(string line in input)
            {
                int col = 0;
                foreach(char a in line)
                {
                    if (a == '#')
                    {
                        asteroids.Add(new Asteroid(col, row, count));
                        count++;
                    }
                    col++;
                }
                row++;
            }

            foreach(Asteroid a in asteroids)
            {
                foreach(Asteroid b in asteroids.FindAll(x => x.index > a.index))
                {
                    double ab = Math.Atan2(b.x - a.x, a.y - b.y) * (180 / Math.PI);
                    double ba = Math.Atan2(a.x - b.x, b.y - a.y) * (180 / Math.PI);
                    if (ab < 0)
                        ab += 360;
                    if (ba < 0)
                        ba += 360;
                    a.atans.Add(ab);
                    b.atans.Add(ba);
                    a.others.Add(new Other(b.x,b.y,ab));
                    b.others.Add(new Other(a.x,a.y,ba));
                }
            }
            int max = 0;
            Asteroid most = null;
            foreach(Asteroid a in asteroids)
            {
                if (a.atans.Count > max)
                {
                    most = a;
                    max = a.atans.Count;
                }
            }
            //Console.WriteLine(most.ToString());
            //Console.WriteLine(most.atans.ElementAt(199));
            double angle = most.atans.ElementAt(199);
            foreach(Other o in most.others.FindAll(x => x.angle == angle))
            {
                Console.WriteLine(o.ToString() + " " + o.getDistance(most));
            }


        }
    }

    public class Asteroid
    {
        public int x;
        public int y;
        public int visibleCount = 0;
        public int index;
        public SortedSet<double> atans = new SortedSet<double>();
        public List<Other> others = new List<Other>();
        public Asteroid(int x, int y, int index)
        {
            this.x = x;
            this.y = y;
            this.index = index;
        }
        public override string ToString()
        {
            return ("x = " + x + " y = " + y + " count = " + atans.Count);
        }



    }

    public class Other
    {
        public int x;
        public int y;
        public double angle;

        public Other(int x, int y, double angle)
        {
            this.x = x;
            this.y = y;
            this.angle = angle;
        }

        public override bool Equals(object obj)
        {
            return obj is Other other &&
                   x == other.x &&
                   y == other.y &&
                   angle == other.angle;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(x, y, angle);
        }
        public int getDistance(Asteroid other)
        {
            return Math.Abs(this.x - other.x) + Math.Abs(this.y - other.y);
        }

        public override string ToString()
        {
            return "x = " + x + " y = " + y + " angle = " + angle;
        }
    }
}

using System;
using System.Linq;

namespace AdventCode12
{
    class Program
    {
        static void Main(string[] args)
        {
            Moon[] moons = new Moon[] {
            new Moon(new Axes(-5,6,-11),0),
            new Moon(new Axes(-8,-4,-2),1),
            new Moon(new Axes(1,16,4),2),
            new Moon(new Axes(11,11,-4),3) };

            Moon[] moonsOrig = new Moon[] {
            new Moon(new Axes(-5,6,-11),0),
            new Moon(new Axes(-8,-4,-2),1),
            new Moon(new Axes(1,16,4),2),
            new Moon(new Axes(11,11,-4),3) };
            long turnsX = 0;

            while(true)
            {
                foreach(Moon moon in moons)
                {
                    foreach(Moon moon2 in moons)
                    {
                        if (moon2.index <= moon.index)
                            continue;
                        moon.compare(moon2);
                    }
                }
                foreach (Moon moon in moons)
                {
                    moon.update();
                }
                turnsX++;
                if (moons[0].velocity.x == moonsOrig[0].velocity.x
                    && moons[1].velocity.x == moonsOrig[1].velocity.x
                    && moons[2].velocity.x == moonsOrig[2].velocity.x
                    && moons[3].velocity.x == moonsOrig[3].velocity.x
                    && moons[0].position.x == moonsOrig[0].position.x
                    && moons[1].position.x == moonsOrig[1].position.x
                    && moons[2].position.x == moonsOrig[2].position.x
                    && moons[3].position.x == moonsOrig[3].position.x)
                    break;
            }
            Console.WriteLine("X = " + turnsX);

            moons = new Moon[] {
            new Moon(new Axes(-5,6,-11),0),
            new Moon(new Axes(-8,-4,-2),1),
            new Moon(new Axes(1,16,4),2),
            new Moon(new Axes(11,11,-4),3) };

            long turnsY = 0;

            while (true)
            {
                foreach (Moon moon in moons)
                {
                    foreach (Moon moon2 in moons)
                    {
                        if (moon2.index <= moon.index)
                            continue;
                        moon.compare(moon2);
                    }
                }
                foreach (Moon moon in moons)
                {
                    moon.update();
                }
                turnsY++;
                if (moons[0].velocity.y == moonsOrig[0].velocity.y
                    && moons[1].velocity.y == moonsOrig[1].velocity.y
                    && moons[2].velocity.y == moonsOrig[2].velocity.y
                    && moons[3].velocity.y == moonsOrig[3].velocity.y
                    && moons[0].position.y == moonsOrig[0].position.y
                    && moons[1].position.y == moonsOrig[1].position.y
                    && moons[2].position.y == moonsOrig[2].position.y
                    && moons[3].position.y == moonsOrig[3].position.y)
                    break;
            }
            Console.WriteLine("Y = " + turnsY);

            moons = new Moon[] {
            new Moon(new Axes(-5,6,-11),0),
            new Moon(new Axes(-8,-4,-2),1),
            new Moon(new Axes(1,16,4),2),
            new Moon(new Axes(11,11,-4),3) };

            long turnsZ = 0;

            while (true)
            {
                foreach (Moon moon in moons)
                {
                    foreach (Moon moon2 in moons)
                    {
                        if (moon2.index <= moon.index)
                            continue;
                        moon.compare(moon2);
                    }
                }
                foreach (Moon moon in moons)
                {
                    moon.update();
                }
                turnsZ++;
                if (moons[0].velocity.z == moonsOrig[0].velocity.z
                    && moons[1].velocity.z == moonsOrig[1].velocity.z
                    && moons[2].velocity.z == moonsOrig[2].velocity.z
                    && moons[3].velocity.z == moonsOrig[3].velocity.z
                    && moons[0].position.z == moonsOrig[0].position.z
                    && moons[1].position.z == moonsOrig[1].position.z
                    && moons[2].position.z == moonsOrig[2].position.z
                    && moons[3].position.z == moonsOrig[3].position.z)
                    break;
            }
            Console.WriteLine("Z = " + turnsZ);

            Console.WriteLine("Total = " + LCM( new long[] { turnsX, turnsY, turnsZ }));
        }

        static long LCM(long[] numbers)
        {
            return numbers.Aggregate(lcm);
        }
        static long lcm(long a, long b)
        {
            return Math.Abs(a * b) / GCD(a, b);
        }
        static long GCD(long a, long b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }

        static void SimulateTurns()
        {
            Moon[] moons = new Moon[] {
            new Moon(new Axes(-5,6,-11),0),
            new Moon(new Axes(-8,-4,-2),1),
            new Moon(new Axes(1,16,4),2),
            new Moon(new Axes(11,11,-4),3) };

            int turns = 1000;

            for (int i = 0; i < turns; i++)
            {
                foreach (Moon moon in moons)
                {
                    foreach (Moon moon2 in moons)
                    {
                        if (moon2.index <= moon.index)
                            continue;
                        moon.compare(moon2);
                    }
                }
                foreach (Moon moon in moons)
                {
                    moon.update();
                }
            }

            int total = 0;
            foreach (Moon moon in moons)
            {
                Console.WriteLine(moon.ToString());
                total += moon.Energy();
            }
            Console.WriteLine("Energy = " + total);
        }
    }

    public class Moon
    {
        public Axes position;
        public Axes velocity = new Axes(0, 0, 0);
        public int index;

        public Moon(Axes position,int index)
        {
            this.position = position;
            this.index = index;
        }

        public override string ToString()
        {
            return position.ToString() + velocity.ToString() + "\n";
        }

        public void compare(Moon other)
        {
            if(this.position.x > other.position.x)
            {
                this.velocity.x -= 1;
                other.velocity.x += 1;
            }
            else if (this.position.x < other.position.x)
            {
                this.velocity.x += 1;
                other.velocity.x -= 1;
            }
            if (this.position.y > other.position.y)
            {
                this.velocity.y -= 1;
                other.velocity.y += 1;
            }
            else if (this.position.y < other.position.y)
            {
                this.velocity.y += 1;
                other.velocity.y -= 1;
            }
            if (this.position.z > other.position.z)
            {
                this.velocity.z -= 1;
                other.velocity.z += 1;
            }
            else if (this.position.z < other.position.z)
            {
                this.velocity.z += 1;
                other.velocity.z -= 1;
            }
        }

        public void update()
        {
            position.x += velocity.x;
            position.y += velocity.y;
            position.z += velocity.z;
        }

        public int Energy()
        {
            return (Math.Abs(position.x) + Math.Abs(position.y) + Math.Abs(position.z)) * (Math.Abs(velocity.x) + Math.Abs(velocity.y) + Math.Abs(velocity.z));
        }
    }

    public class Axes
    {
        public int x, y, z;

        public Axes(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return "x = " + x + " y = " + y + " z = " + z + "\n";
        }
        
    }
}


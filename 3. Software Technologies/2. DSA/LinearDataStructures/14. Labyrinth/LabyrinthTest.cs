namespace Labyrinth
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class LabyrinthTest
    {
        static readonly ICollection<Coordinates> Directions = new Coordinates[]
        {
            new Coordinates(0,1),
            new Coordinates(1, 0),
            new Coordinates(0,-1),
            new Coordinates(-1,0)
        };

        static void Main()
        {
            string[,] labyrinth =  
            {
                { "_", "_", "_", "#", "_", "#" },
                { "_", "#", "_", "#", "_", "#" },
                { "_", "X", "#", "_", "#", "_" },
                { "_", "#", "_", "_", "_", "_" },
                { "_", "_", "_", "#", "#", "_" },
                { "_", "_", "_", "#", "_", "#" },
            };

            var currentQueue = new Queue<Coordinates>();
            currentQueue.Enqueue(labyrinth.GetIndex("X"));

            int level = 0;

            while (currentQueue.Count != 0)
            {
                var nextQueue = new Queue<Coordinates>();

                level++;

                while (currentQueue.Count != 0)
                {
                    Coordinates currentCoordinates = currentQueue.Dequeue();

                    foreach (Coordinates currentDirection in Directions)
                    {
                        Coordinates nextCoordinates = currentCoordinates + currentDirection;

                        if (!labyrinth.IsInRange(nextCoordinates))
                        {
                            continue;
                        }

                        if (labyrinth[nextCoordinates.Row, nextCoordinates.Col] != "_")
                        {
                            continue;
                        }

                        labyrinth[nextCoordinates.Row, nextCoordinates.Col] = level.ToString();
                        nextQueue.Enqueue(nextCoordinates);
                    }
                }

                currentQueue = nextQueue;
            }

            Console.WriteLine(labyrinth.Replace("_", "0").AsString());
        }
    }
}

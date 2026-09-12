
    using System;
{
    Console.WriteLine("Press Enter");
    string start = Console.ReadLine();
    while (start == "" +
        "")
    {
        
        int play;
        string[] notes = new string[] { "A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#" };
        Random random = new Random();

        play = random.Next(0, 11);
        int[] strings = new int[6];
        Console.Write("Play " + notes[play]+": ");
        for (int i = 0; i < strings.Length; i++)
        {
            bool organized = false;
            while (!organized)
            {
                int order = random.Next(1, 7);
                int allGood = 0;
                int bad = 0;
                for (int j = 0; j < i + 1; j++)
                {
                    if (!(strings[j] == order))
                    {
                        allGood++;
                    }
                    else { bad++; }

                }

                if (bad > 0) { organized = false; }
                else
                {
                    strings[i] = order;
                    organized = true;
                    Console.Write(order + ", ");
                }

            }


        }


        Console.WriteLine("");

        start = Console.ReadLine();
    }

}




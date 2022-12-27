
            int input, counter, control, prime;
            long[] series = new long[99999];
            int mycounter = -1;
            Console.WriteLine("Prime Number Programs ");
            Console.Write("enter a number ");
            input = Convert.ToInt32(Console.ReadLine());

            for (control = 2; control <= input; control++)
            {
                prime = 1;
                for (counter = 2; counter < control; counter++)
                {
                    if (control % counter == 0)
                    {
                        prime = 0;
                    }
                }
                if (prime == 0)
                {

                }
                else
                {

                    mycounter++;
                    series[mycounter] = control;
                }
            }
            for (int i = 0; i <= mycounter; i++)
            {
                Console.WriteLine(series[i]);
            }

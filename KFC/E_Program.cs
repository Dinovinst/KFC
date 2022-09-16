public class Program
    {
        static void Main(string[] args)
        {
            int Finish = 0;
            while (Finish == 0)
            {
                string[] answer = new string[4];

                Console.WriteLine
                    ("Would you like to see the store's information?" +
                    "(see input Yes),(don't see input No) : ");
                answer[0] = Console.ReadLine();

                Console.WriteLine
                    ("Would you like to see the store co-founder information?" + 
                    "(see input Yes),(don't see input No) : ");
                answer[1] = Console.ReadLine();

                Console.WriteLine
                    ("Would you like to see store staff information?" + 
                    "(see input Yes),(don't see input No) : ");
                answer[2] = Console.ReadLine();

                Console.WriteLine
                    ("Would you like to see the store's income and expenses?" + 
                    "(see input Yes),(don't see input No) : ");
                answer[3] = Console.ReadLine();

                int ans = StoreFinish(answer);

                Console.WriteLine("You want to see {0}", ans);
                Console.WriteLine("Would you like to see more information? (see type 0),(don't see type 1) : ");
                Finish = int.Parse(Console.ReadLine());
            }
        }
        static int StoreFinish(string[] answer)
        {
            int[] A = new int[4];
            if (answer[0] == "Yes")
            {
                A[0] = 1;
            }
            else 
            {
                A[0] = 0;
            }

            if (answer[1] == "Yes")
            {
                A[1] = 2;
            }
            else 
            {
                A[1] = 0;
            }

            if (answer[2] == "Yes")
            {
                A[2] = 3;
            }
            else
            {
                A[2] = 0;

            }
            if (answer[3] == "Yes")
            {
                A[3] = 4;
            }
            else
            {
                A[3] = 0;
            }


            return A[0] + A[1] + A[2] + A[3];
        }
    }
namespace CodeWars
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(FindShort("bitcoin take over the world maybe who knows perhaps"));

        }


        static double ArrSum(double[] arr)
        {
            return arr.Sum();
        }

        public static int StringToNumber(String str)
        {
          return  Convert.ToInt32(str);

        }

        public static string RepeatStr(int n, string s)
        {

            string result = "";
            for (int i = 0; i < n; i++)
                result += s;
            return result;
        }

        public static string Bmi(double weight, double height)
        {             
            double bmi = weight / (height * height);
            if (bmi <= 18.5) return "Underweight";

            if (bmi <= 25.0) return "Normal";

            if (bmi <= 30.0) return "Overweight";

            if (bmi > 30) return "Obese";

            return "";
        }

        public string Rps(string p1, string p2)
        {

            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>
            {

                {"scissors paper","Player 1 won!"},
                {"paper scissors","Player 2 won!"},

                {"rock scissors","Player 1 won!"},
                {"scissors rock","Player 2 won!"},

                {"paper rock","Player 1 won!"},
                {"rock paper","Player 2 won!"},

            };


            if (p1 == p2)
                return "Draw!"; 
            


            return keyValuePairs[p1 + " "+ p2];
        }

        public static string AbbrevName(string name)
        {
            var names = name.ToUpper().Split('.',' ');
            return $"{names[0][0]}.{names[1][0]}";
        }

        public static int Multiply(int x)
        {

            return  x * ( x % 2 == 0 ? 8:9 );
        }
        public static int[] InvertValues(int[] input)
        {

            return input.Select(a=>-a).ToArray();

        }



        public static bool Hero(int bullets, int dragons)
        {
            return dragons * 2 <= bullets;
        }

        public static int FindSmallestInt(int[] args)
        {
            return args.Min();
        }

        public static int Past(int h, int m, int s)
        {
            return (h * 60 * 60 + m * 60 + s) * 1000;
        }

        public static int Number(List<int[]> peopleListInOut)
        {
            var peopleIn = 0;
            var peopleOut = 0;
            foreach(var v in peopleListInOut)
            {
                peopleIn += v[0];
                peopleOut += v[1];
            }

           
            return peopleIn - peopleOut;
        }

        public static int FindShort(string s)
        {
            return s.Split(" ").Min(x => x.Length);
        }

        public static int[] Maps(int[] x)
        {
            return x;
        }
    }
}
namespace CodeWars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ArrSum(new double[] {1.5,-0.4} ));
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
            return "";
        }



    }
}
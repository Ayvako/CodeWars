using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;






namespace CodeWars
{


    internal class Program
    {
        static void Main(string[] args)
        {

            IsValidWalk(new string[] { "n", "w", "w", "e", "n", "s", "n", "s", "n", "s" });


        }



        static double ArrSum(double[] arr)
        {
            return arr.Sum();
        }

        public static int StringToNumber(String str)
        {
            return Convert.ToInt32(str);

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



            return keyValuePairs[p1 + " " + p2];
        }

        public static string AbbrevName(string name)
        {
            var names = name.ToUpper().Split('.', ' ');
            return $"{names[0][0]}.{names[1][0]}";
        }

        public static int Multiply(int x)
        {

            return x * (x % 2 == 0 ? 8 : 9);
        }
        public static int[] InvertValues(int[] input)
        {

            return input.Select(a => -a).ToArray();

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
            foreach (var v in peopleListInOut)
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
            return x.Select(x => x *= 2).ToArray();
        }


        public static int DescendingOrder(int num)
        {

            return Convert.ToInt32(string.Concat($"{num}".OrderByDescending((a) => a)));
        }

        static void PrintArr<T>(IEnumerable<T> arr)
        {
            foreach (var v in arr)
                Console.Write($"{v} ");
            Console.WriteLine();
        }

        public static long[] Digitize(long n)
        {
            return $"{n}"
                .Reverse()
                .Select(item => (long)item - '0')
                .ToArray();
        }

        public static int sumTwoSmallestNumbers(int[] numbers)
        {
            return numbers.OrderBy(a => a).Take(2).Sum();
        }

        public static int summation(int num)
        {
            return num * (1 + num) / 2;

        }
        public static long RowSumOddNumbers(long n)
        {
            return n * n * n;
        }


        public static string AreYouPlayingBanjo(string name)
        {
            return name.ToLower()[0].Equals('r') ? name + " plays banjo" : name + " does not play banjo";
        }

        public static string MakeComplement(string dna)
        {
            return new string(dna.Select(change).ToArray());
        }

        public static char change(char c)
        {

            var temp = $"{c}";
            switch (temp)
            {
                case "A":
                    temp = "T";
                    break;

                case "T":
                    temp = "A";
                    break;

                case "G":
                    temp = "C";
                    break;

                case "C":
                    temp = "G";
                    break;
            }
            return temp[0];
        }

        public static bool XO(string input)
        {

            //return input.ToLower().Count(a => a == 'x') == input.ToLower().Count(a => a == 'o');

            return input.ToLower().Where(a => a == 'x').Count() == input.ToLower().Where(a => a == 'o').Count();
        }

        public static long FindNextSquare(long num)
        {
            long sqrt = (long)Math.Sqrt(num);
            return num / decimal.Floor(sqrt) - decimal.Floor(sqrt) <= 0 ? (sqrt + 1) * (sqrt + 1) : -1;
        }

        public static bool IsSquare(int n)
        {
            return Math.Sqrt(n) % 1 == 0;
        }

        public static string alphabetPosition(string str)
        {


            return string.Join(" ", Regex.Replace(str, @"[^a-zA-Z]+", "").ToLower().Select(a => a - 96));
        }
        public static int[] CountPositivesSumNegatives(int[] input)
        {


            if (input == null || input.Length == 0)
            {
                return Array.Empty<int>();
            }
            else
            {
                int count = 0;
                int sum = 0;
                foreach (var i in input)
                {
                    _ = i > 0 ? count++ : i < 0 ? sum += i : 0;
                }

                //int countPositives = input.Count(n => n > 0);
                //int sumNegatives = input.Where(n => n < 0).Sum();



                return new[] { count, sum };
            }



        }

        public static string ReverseWords(string str)
        {
            string newStr = "";
            foreach (var s in str.Split(" "))
            {
                Console.WriteLine(s);
                newStr += new string(s.Reverse().ToArray()) + " ";
                //		return string.Join(" ", str.Split(' ').Select(i => new string(i.Reverse().ToArray())));

            }
            return newStr.Trim();
        }


        public static string HighAndLow(string numbers)
        {

            var arr = numbers.Split(" ").Select(i => int.Parse(i));

            return $"{arr.Max()} {arr.Min()}";
        }

        public static bool lovefunc(int flower1, int flower2)
        {
            return (flower1 + flower2) % 2 == 1;
        }

        public static int СenturyFromYear(int year)
        {

            return year % 100 == 0 ? year / 100 : year / 100 + 1;
        }

        public static string CountSheep(int n)
        {
            string res = "";
            for (int i = 1; i <= n; i++)
            {

                res += $"{i} sheep...";
            }
            //return string.Concat(Enumerable.Range(1, n).Select(i => $"{i} sheep..."));

            return res;
        }

        public static int[] CountBy(int x, int n)
        {
            return Enumerable.Range(1, n).Select(i => i * x).ToArray();
        }
        public static int Paperwork(int n, int m)
        {
            return n < 0 || m < 0 ? 0 : n * m;
        }


        public static int DuplicateCount(string str)
        {
            Dictionary<char, int> pairs = new();

            foreach (char c in str.ToLower())
            {
                if (pairs.ContainsKey(c))
                    pairs[c]++;
                else
                    pairs.Add(c, 1);
            }
            //    return str.ToLower().GroupBy(c => c).Where(g => g.Count() > 1).Count();

            return pairs.Count((k) => k.Value > 1);
        }

        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {

            return iterable.Where((a, index) => !a.Equals(iterable.ElementAtOrDefault(index + 1)));

        }


        public static bool ValidatePin(string pin)
        {


            return (pin.Length == 6 || pin.Length == 4) && Regex.IsMatch(pin, @"^[\d]+\z");


        }
        public static int Find(int[] integers)
        {


            return integers.Count(a => a % 2 == 0) == 1 ? integers.First(a => a % 2 == 0) : integers.First(a => a % 2 == 1);

        }


        public static string FindNeedle(object[] haystack)
        {

            return $"found the needle at position {Array.IndexOf(haystack, "needle")}";
        }
        public static int PositiveSum(int[] arr)
        {

            return arr.Sum(a => a > 0 ? a : 0);
        }


        public static string NumberToString(int num)
        {
            return Convert.ToString(num);
        }


        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {


            //listOfItems.OfType<int>();

            return listOfItems.Where(a => (a is int)).Select(a => (int)a);
        }
        public static int Opposite(int number)
        {
            return -number;
        }

        public static string FakeBin(string x)
        {
            return new string(x.Select(c => c >= '5' ? '1' : '0').ToArray());
        }

        public static int[] ReverseSeq(int n)
        {
            return Enumerable.Range(1, n).Reverse().ToArray();
        }

        public static int SquareSum(int[] numbers)
        {
            //    return n.Sum(x => x*x);

            return numbers.Aggregate((acc, cur) => acc + (cur * cur));
        }


        public static string Solution(string str)
        {
            return string.Concat(str.Reverse());
        }
        public static bool IsPangram(string str)
        {
            return Regex.Replace(str.ToLower(), @"[^a-z]+", "").Distinct().Count() == 26;
        }
        public static IEnumerable<string> FriendOrFoe(string[] names)
        {

            return names.Where(a => a.Length == 4);

        }

        public static int NbYear(int p0, double percent, int aug, int p)
        {
            var year = 0;

            while (p0 < p)
            {

                p0 = (int)(p0 * (1 + percent / 100) + aug);
                year++;
            }

            return year;
        }

        public static bool Solution(string str, string ending)
        {
            return str.EndsWith(ending);
        }
        public static string EvenOrOdd(int number)
        {
            return number % 2 == 0 ? "Even" : "Odd";
        }


        public static long findNb(long m)
        {
            long sum = 0;
            int n = 0;
            while (sum < m)
            {
                n++;
                sum += (long)Math.Pow(n, 3);
            }

            return sum == m ? n : -1;
        }

        public static int[] SortArray(int[] array)
        {
            var arr = array.Select(a => a % 2 == 1 ? -1 : a).ToArray();
            var oddArr = array.Where(a => a % 2 == 1).ToArray();
            Array.Sort(oddArr);

            int n = 0;
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] == -1)
                {
                    arr[i] = oddArr[n];
                    n++;
                }

            }

            return arr;
        }

        public static string Order(string words)
        {
            var arr = words.Split(" ");
            Array.Sort(arr, (a, b) => Convert.ToInt32(Regex.Match(a, @"\d").Value) - Convert.ToInt32(Regex.Match(b, @"\d").Value));
            return string.Join(" ", arr);
        }


        public static string Longest(string s1, string s2)
        {
            //return new string((s1 + s2).Distinct().OrderBy(x => x).ToArray());

            return string.Join("", s1.Union(s2).OrderBy(a => a).Distinct().ToArray());
        }

        public static string[] TowerBuilder(int nFloors)
        {
            string[] s = new string[nFloors];

            for (int i = 0; i < s.Length; i++)
            {
                s[i] = new string(' ', nFloors - i - 1) + new string('*', i * 2 + 1) + new string(' ', nFloors - i - 1);
            }

            return s;
        }
        public static int binaryArrayToNumber(int[] BinaryArray)
        {



            //Convert.ToInt32(string.Join("", BinaryArray),2);

            return (int)BinaryArray.Reverse().Select((s, ind) => s == 1 ? Math.Pow(2, ind) : 0).Sum();


        }

        public static string NoSpace(string input)
        {
            return input.Replace(" ", "");
        }
        public static string greet()
        {
            return "hello world!";
        }


        public static string boolean_to_string(bool b)
        {
            //Please don't delete me!
            return Convert.ToString(b);
        }



        public static bool Check(object[] a, object x)
        {
            return a.Contains(x);
        }

        public static int GetUnique(IEnumerable<int> numbers)
        {

            //return numbers.GroupBy(x => x).Single(x => x.Count() == 1).Key;


            return numbers.GroupBy(a => a).Where(a => a.Count() == 1).ElementAt(0).Key;
        }

        public static int GetVowelCount(string str)
        {
            int vowelCount = 0;

            str.Count(a => Regex.IsMatch((a).ToString(), @"a|e|i|o|u"));

            return vowelCount;
        }

        public static int MakeNegative(int number)
        {
            return number < 0 ? number : -number;
        }
        public static int Persistence(long n)
        {
            int c = 0;
            string s = n.ToString();
            while (s.Length > 1)
            {
                s = Convert.ToString(s.Select(n => Convert.ToInt32(n.ToString())).Aggregate((acc, cur) => ((acc) * (cur))));
                c++;
            }
            return c;
        }



        public static int FindEvenIndex(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {

                int[] arr1 = new int[arr.Length - i - 1];
                int[] arr2 = new int[i];
                Array.ConstrainedCopy(arr, i + 1, arr1, 0, arr.Length - i - 1);
                Array.ConstrainedCopy(arr, 0, arr2, 0, i);

                if (arr1.Sum() == arr2.Sum())
                    return i;

            }
            return -1;



            //for (var i = 0; i < arr.Length; i++)
            //{
            //    if (arr.Take(i).Sum() == arr.Skip(i + 1).Sum()) { return i; }
            //}
            //return -1;



        }
        public static int SumMix(object[] x)
        {

            return (int)x.Aggregate((a, b) => Convert.ToInt32(a) + Convert.ToInt32(b));


            //return x.Sum(Convert.ToInt32);


        }


        public static int CountSheeps(bool[] sheeps)
        {

            return sheeps.Where(a => a == true).Count();
        }

        public static int[] minMax(int[] lst)
        {
            return new int[] { lst.Min(), lst.Max() };
        }
        public static bool SetAlarm(bool employed, bool vacation)
        {
            //    return employed & !vacation;

            return employed == true && vacation == false;
        }


        public static string[] StringToArray(string str)
        {
            return str.Split(" ");
        }

        public static string ExpandedForm(long num)
        {

            return string.Join(" + ", num.ToString().Select((a, ind) => a + new string('0', num.ToString().Length - ind - 1)).Where(a => a.ElementAt(0) != '0'));

        }
        public static int MaxSequence(int[] arr)
        {
            int sum = 0, maxsum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    sum += arr[j];
                    if (sum > maxsum)
                    {
                        maxsum = sum;

                    }
                }

                sum = 0;
                Math.Max(0, 5);
            }
            return maxsum;
        }


        public static bool IsIsogram(string str)
        {


            //return str.ToLower().Distinct().Count() == str.Length;

            return str.ToLower().Distinct().ToArray().Length == str.Length;
        }


        public static int CockroachSpeed(double x)
        {
            return (int)Math.Floor(x * 1000 * 100 / 60 / 60);

        }
        public static List<int> RemoveSmallest(List<int> numbers)
        {
            List<int> res = new(numbers);

            var obj = res.FirstOrDefault(o => o == res.Min());
            if (res.Capacity != 0)
            {
                int index = res.IndexOf(obj);
                res.RemoveAt(index);
                return res;
            }
            else return new List<int>();
        }

        public static int Sum(int[] numbers)
        {
            if (numbers != null || numbers.Count() > 1)
            {
                var list = numbers.ToList();
                list.Remove(numbers.Min());
                list.Remove(numbers.Max());
                return list.Sum();
            }
            else return 0;
        }


        public static int[] Take(int[] arr, int n)
        {
            return arr.Take(n).ToArray();
        }
        public static string UpdateLight(string current)
        {
            Dictionary<string, string> map = new()
            {
                { "yellow", "red" },
                { "red", "green" },
                { "green", "yellow" }
            };

            return map[current];
        }




        public static List<string> wave(string str)
        {

            //str
            //.Select((c, i) => str.Substring(0, i) + Char.ToUpper(c) + str.Substring(i + 1))
            //.Where(x => x != str)
            //.ToList();

            var list = new List<string>();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ') continue;
                list.Add(new string(str.Take(i).ToArray()) + char.ToUpper(str[i]) + new string(str.TakeLast(str.Length - i - 1).ToArray()));
            }
            return list;
        }


        public static string ToJadenCase(string phrase)
        {
            return string.Join(' ', phrase.Split(' ').Select(a => char.ToUpper(a[0]) + a[1..]));
        }


        public static string Smash(string[] words)
        {
            return string.Join(' ', words);
        }

        public static string DnaToRna(string dna)
        {
            //return dna.Replace('T', 'U');

            return string.Join("",dna.Select(a => a == 'T' ? a = 'U' : a));
        }



        public static double[] Tribonacci(double[] signature, int n)
        {

            if (n < 3)
                return signature.Take(n).ToArray();

            List<double> l = new List<double>(signature);
            for(int i = 3;i<n;i++)
                l.Add(l.TakeLast(3).Sum());

            return l.ToArray();
        }

        public static bool Comp(int[] a, int[] b)
        {
            Console.WriteLine(a);
            Console.WriteLine(b);

            if (a == null || b == null)
                return false;
            if (a.Length != b.Length)
                return false;
            Array.Sort(a);
            Array.Sort(b);
            for (int i = 0; i < a.Length; i++)
                if (a[i] * a[i] != b[i])
                {
                    return false;
                }

            return true;
        }



        public static int[] TwoSum(int[] numbers, int target)
        {
            int[] sum = new int[2];
            for(int i = 0; i < numbers.Length; i++)
            {
                sum[0] = numbers[i];
                for (int j = i+1; j < numbers.Length; j++)
                {
                    sum[1] = numbers[j];
                    if (sum.Sum() == target)
                        return new[] { i , j};
                }
            }
            return Array.Empty<int>();
        }




        public static List<int> FindIndexes(int[] arr, int targetSum)
        {
            var result = new List<int>();
            var map = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                int complement = targetSum - arr[i];
                if (map.ContainsKey(complement))
                {
                    result.Add(map[complement]);
                    result.Add(i);
                    return result;
                }
                map[arr[i]] = i;
            }
            return result;
        }

        public static bool IsValidWalk(string[] walk)
        {
            var dict = walk.GroupBy(
                 dir => dir, (dir, dirs) => new
                 {
                     Key = dir,
                     Count = dirs.Count(),
                 }).ToDictionary(a=>a.Key,b=>b.Count);
            //return walk.Count(x => x == "n") == walk.Count(x => x == "s") && walk.Count(x => x == "e") == walk.Count(x => x == "w") && walk.Length == 10;


            return dict.GetValueOrDefault("w") == dict.GetValueOrDefault("e") && dict.GetValueOrDefault("s") == dict.GetValueOrDefault("n") && walk.Length == 10;
        }


        public static int find_it(int[] seq)
        {
            var dict = seq.GroupBy(
                a => a, (a, count) => new
                {
                    Key = a,
                    Count = count.Count(),
                });
                
            return dict.Where(a => a.Count % 2 == 1).Single().Key;
        }

        public static int GetGoals(int laLigaGoals, int copaDelReyGoals, int championsLeagueGoals)
        {
            return laLigaGoals + copaDelReyGoals + championsLeagueGoals;
        }

















        private static void Print<T>(T t)
        {
            Console.WriteLine(t);
        }




    }

}
namespace ListNumsActions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string[] cmd = Console.ReadLine().Split().ToArray();
                string command = cmd[0];
                if (command.ToLower() == "finish")
                {
                    break;
                }
                switch (command)
                {
                    case "ins": int index= int.Parse(cmd[1]);
                        int num = int.Parse(cmd[2]);
                        nums.Insert(index,num);
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", nums));
                        break;

                    case "contains":
                        int searchNum = int.Parse(cmd[1]);
                        if (nums.Contains(searchNum))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No");
                        }
                        break;

                    case "add":
                        int num1 = int.Parse(cmd[1]);
                        int num2 = int.Parse(cmd[2]);
                        nums.Add(num1 + num2);
                        break;

                    case "del":
                        int valueToRemove = int.Parse(cmd[1]);
                        nums.Remove(valueToRemove);
                        break;

                    case "remove":
                        int indexToRemove = int.Parse(cmd[1]);
                        nums.RemoveAt(indexToRemove);
                        break;

                    case "countl":
                        int target = int.Parse(cmd[1]);
                        int greaterCount = nums.Count(x => x > target);
                        Console.WriteLine(greaterCount);
                        break;

                    case "countOdds":
                        int oddCount = nums.Count(x => x % 2 != 0);
                        Console.WriteLine($"CountOdds={oddCount}");
                        break;

                    case "countEvens":
                        int evenCount = nums.Count(x => x % 2 == 0);
                        Console.WriteLine($"CountEvens={evenCount}");
                        break;

                    case "sumAll":
                        int sum = nums.Sum();
                        Console.WriteLine(sum);
                        break;
                }
            }
        }
    }
}

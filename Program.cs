namespace G_NET_42_ADV_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1: Student Grade Manager
            //List<int> grades = new() { 85, 92, 78, 95, 88, 70, 100, 65 };

            //Console.WriteLine("Original Grades:");
            //Console.WriteLine(string.Join(", ", grades));

            //Console.WriteLine($"Count: {grades.Count}");
            //Console.WriteLine($"First: {grades.First()}");
            //Console.WriteLine($"Last: {grades.Last()}");

            //grades.Sort();
            //Console.WriteLine("\nSorted Grades:");
            //Console.WriteLine(string.Join(", ", grades));

            //var firstAbove90 = grades.FirstOrDefault(g => g > 90);
            //Console.WriteLine($"First grade above 90: {firstAbove90}");

            //var failing = grades.Where(g => g < 75).ToList();
            //Console.WriteLine("Failing Grades:");
            //Console.WriteLine(string.Join(", ", failing));

            //grades.RemoveAll(g => g < 75);
            //Console.WriteLine("After removing failing:");
            //Console.WriteLine(string.Join(", ", grades));

            //Console.WriteLine($"Any 100? {grades.Any(g => g == 100)}");

            //List<string> gradeStrings = grades.Select(g => $"Grade: {g}").ToList();
            //Console.WriteLine("String List:");
            //gradeStrings.ForEach(Console.WriteLine);
            #endregion

            #region Exercise 2: Leaderboard
            //SortedDictionary<int, string> board = new SortedDictionary<int, string>()
            //{
            //    {500,"Ahmed"},
            //    {200,"Sara"},
            //    {800,"Ali"},
            //    {350,"Mona"}
            //};

            //    Console.WriteLine("\nLeaderboard:");
            //    foreach (var item in board)
            //        Console.WriteLine($"{item.Key} : {item.Value}");

            //    Console.WriteLine($"First Key: {board.First().Key}");
            //    Console.WriteLine($"First Value: {board.First().Value}");

            //    Console.WriteLine($"Contains 500? {board.ContainsKey(500)}");

            //    if (board.TryGetValue(999, out string player))
            //        Console.WriteLine(player);
            //    else
            //        Console.WriteLine("Score 999 not found");

            //    board.Remove(200);
            //    Console.WriteLine("After removing 200:");
            //    foreach (var item in board)
            //        Console.WriteLine($"{item.Key} : {item.Value}"); 
            #endregion

            #region Exercise 3: Phone Book
            //Dictionary<string, string> phoneBook = new Dictionary<string, string>()
            //{
            //    {"Ahmed","123"},
            //    {"Sara","456"},
            //    {"Ali","789"},
            //    {"Mona","000"}
            //};

            //    phoneBook["Omar"] = "999"; // add or update

            //    try
            //    {
            //        phoneBook.Add("Ahmed", "111");
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine($"Error: {ex.Message}");
            //    }

            //    bool added = phoneBook.TryAdd("Ahmed", "222");
            //    Console.WriteLine($"TryAdd success? {added}");

            //    if (!phoneBook.ContainsKey("Youssef"))
            //        Console.WriteLine("Youssef not found");

            //    string result = phoneBook.GetValueOrDefault("Youssef", "Not Found");
            //    Console.WriteLine($"Search result: {result}");

            //    Console.WriteLine("Keys:");
            //    Console.WriteLine(string.Join(", ", phoneBook.Keys));

            //    Console.WriteLine("Values:");
            //    Console.WriteLine(string.Join(", ", phoneBook.Values)); 
            #endregion
        }
    }
}

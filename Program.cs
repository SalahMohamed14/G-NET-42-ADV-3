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

            #region Exercise 4: Unique Email Validator
            //HashSet<string> emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            //{
            //    "ahmed@test.com",
            //    "AHMED@test.com",
            //    "sara@test.com",
            //    "Sara@Test.Com"
            //};

            //    Console.WriteLine($"Email Count: {emails.Count}");
            //    Console.WriteLine("Because HashSet ignores duplicates (case-insensitive)");

            //    HashSet<int> A = new HashSet<int> { 1, 2, 3, 4, 5 };
            //    HashSet<int> B = new HashSet<int> { 4, 5, 6, 7, 8 };

            //    var union = new HashSet<int>(A);
            //    union.UnionWith(B);
            //    Console.WriteLine("Union: " + string.Join(", ", union));

            //    var intersect = new HashSet<int>(A);
            //    intersect.IntersectWith(B);
            //    Console.WriteLine("Intersect: " + string.Join(", ", intersect));

            //    var except = new HashSet<int>(A);
            //    except.ExceptWith(B);
            //    Console.WriteLine("Except: " + string.Join(", ", except));
            //    Console.WriteLine($"Is {{1,2}} subset of A? {new HashSet<int> { 1, 2 }.IsSubsetOf(A)}");
            #endregion

            #region Exercise 5: Print Queue
            //Queue<string> queue = new Queue<string>();

            //queue.Enqueue("Report.pdf");
            //queue.Enqueue("Invoice.pdf");
            //queue.Enqueue("Letter.docx");
            //queue.Enqueue("Resume.pdf");
            //queue.Enqueue("Photo.jpg");

            //Console.WriteLine("Queue:");
            //Console.WriteLine(string.Join(", ", queue));
            //Console.WriteLine($"Count: {queue.Count}");

            //Console.WriteLine($"Next: {queue.Peek()}");

            //while (queue.Count > 0)
            //{
            //    Console.WriteLine($"Printing: {queue.Dequeue()}");
            //}

            //bool success = queue.TryDequeue(out string doc);
            //Console.WriteLine($"TryDequeue success? {success}"); 
            #endregion

            #region Exercise 6: Browser History
            //Stack<string> history = new Stack<string>();

            //history.Push("google.com");
            //history.Push("github.com");
            //history.Push("stackoverflow.com");
            //history.Push("youtube.com");
            //history.Push("claude.ai");

            //Console.WriteLine($"Current Page: {history.Peek()}");

            //Console.WriteLine("Going Back:");
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Leaving: {history.Pop()}");
            //}

            //Console.WriteLine($"Current Page: {history.Peek()}");

            //history.Clear();
            //bool success = history.TryPop(out string page);
            //Console.WriteLine($"TryPop success? {success}"); 
            #endregion
        }
    }
}

namespace G_NET_42_ADV_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1: Student Grade Manager
            List<int> grades = new() { 85, 92, 78, 95, 88, 70, 100, 65 };

            Console.WriteLine("Original Grades:");
            Console.WriteLine(string.Join(", ", grades));

            Console.WriteLine($"Count: {grades.Count}");
            Console.WriteLine($"First: {grades.First()}");
            Console.WriteLine($"Last: {grades.Last()}");

            grades.Sort();
            Console.WriteLine("\nSorted Grades:");
            Console.WriteLine(string.Join(", ", grades));

            var firstAbove90 = grades.FirstOrDefault(g => g > 90);
            Console.WriteLine($"First grade above 90: {firstAbove90}");

            var failing = grades.Where(g => g < 75).ToList();
            Console.WriteLine("Failing Grades:");
            Console.WriteLine(string.Join(", ", failing));

            grades.RemoveAll(g => g < 75);
            Console.WriteLine("After removing failing:");
            Console.WriteLine(string.Join(", ", grades));

            Console.WriteLine($"Any 100? {grades.Any(g => g == 100)}");

            List<string> gradeStrings = grades.Select(g => $"Grade: {g}").ToList();
            Console.WriteLine("String List:");
            gradeStrings.ForEach(Console.WriteLine);
            #endregion
        }
    }
}

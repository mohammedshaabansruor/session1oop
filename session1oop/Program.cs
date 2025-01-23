namespace session1oop
{
    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1
            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}
            #endregion
            #region Q2
            Console.Write("Enter a season (Spring, Summer, Autumn, Winter): ");
            string input = Console.ReadLine();

            if (Enum.TryParse(input, true, out Season season))
            {
                
                switch (season)
                {
                    case Season.Spring:
                        Console.WriteLine("Spring: March to May");
                        break;
                    case Season.Summer:
                        Console.WriteLine("Summer: June to August");
                        break;
                    case Season.Autumn:
                        Console.WriteLine("Autumn: September to November");
                        break;
                    case Season.Winter:
                        Console.WriteLine("Winter: December to February");
                        break;
                    default:
                        Console.WriteLine("Invalid season entered.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid season entered.");
            }
            #endregion
        }
    }
}

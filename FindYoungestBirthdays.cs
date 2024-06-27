namespace Find_Youngest_By_DOB;

public class FindYoungestBirthdays
{
    public static T[] FindTwoYoungestBirthdays<T>(T[] birthdays) where T : struct, IComparable<T>
    {
        if (birthdays == null || birthdays.Length < 2)
        {
            throw new ArgumentException("Массив должен содержать как минимум два элемента.");
        }

        return birthdays.OrderByDescending(d => d).Take(2).ToArray();
    }
}
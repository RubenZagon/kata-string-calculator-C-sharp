global using NUnit.Framework;


class StringCalculator
{
    public int Add(string numbers)
    {
        int result = 0;
        foreach (string number in numbers.Split(","))
        {
            result += Convert.ToInt32(number);
        }
        return result;
    }
}
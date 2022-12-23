namespace KataStringCalculator;

public class Tests
{
    private StringCalculator _calculator;
    [SetUp]
    public void Setup()
    {
        _calculator = new StringCalculator();
    }

    [Test]
    public void for_empty_input_must_return_a_zero()
    {
        Assert.AreEqual(0, _calculator.Add("0"));
    }

    [Test]
    public void return_the_input_for_one_number()
    {
        Assert.AreEqual(1, _calculator.Add("1"));
    }
    
    [Test]
    public void will_return_the_sum_of_two_numbers()
    {
        Assert.AreEqual(3, _calculator.Add("1,2"));
    }
}
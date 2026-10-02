public class Counter
{
    public int Value { get; set; }
    public Counter(int value)
    {
        Value = value;
    }
    public Counter()
    {
        Value = 0;
    }
    public void Increase()
    {
        Value++;
    }
    public void Decrease()
    {
        Value--;
    }
    public void Increase(int x)
    {
        if(x > 0) Value += x;
    }
    public void Decrease(int x)
    {
        if(x > 0) Value -= x;
    }
    
}
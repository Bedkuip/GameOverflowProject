public class MockableCoinClicker
{
    public int money;
    public virtual int GetMoneyCount()
    {
        return money;
    }
    public virtual void OnClick()
    {
        money++;
    }
}
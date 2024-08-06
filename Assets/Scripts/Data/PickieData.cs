public struct PickieData
{
    public int PointsCount;
    public bool InGame;
    public int Number { get; private set; }

    public PickieData(int number)
    {
        PointsCount = 0;
        Number = number;
        InGame = false;
    }

    public void TakeFromGame()
    {
        InGame = false;
    }

    public void ThrowToGame()
    {
        InGame = true;
    }

    public void SetCount(int count)
    {
        PointsCount = count;
    }
}
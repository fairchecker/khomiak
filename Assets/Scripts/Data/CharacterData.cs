
public struct CharacterData
{
    public string SpriteName;
    public int PointsCount;

    public CharacterData(string spriteName, int pointsCount)
    {
        SpriteName = spriteName;
        PointsCount = pointsCount;
    }

    public void AddPoints(int count)
    {
        PointsCount += count;
    }

    public void TakePoints(int count)
    {
        PointsCount -= count;
    }
}
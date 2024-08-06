using Unity.VisualScripting;
using UnityEngine;

public class PickieView : MonoBehaviour
{
    private int PointsCount;
    public bool InGame { get; private set; }

    private CharacterData _data;

    public void Initialise(int pointsCount, Sprite sprite)
    {
        PointsCount = pointsCount;
        GetComponent<SpriteRenderer>().sprite = sprite;
    }

    public void SetData(CharacterData data)
    {
        _data = data;
    }

    private void OnMouseDown()
    {
        InGame = false;
        _data.AddPoints(PointsCount);
    }

    public void Spawn(Vector2 position)
    {
        transform.position = position;
        InGame = true;
    }
}
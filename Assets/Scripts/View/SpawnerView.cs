using UnityEngine;

public class SpawnerView : MonoBehaviour
{
    public float Cooldown { get; private set; }

    public GameObject[] Pickies;
    private Spawner _spawner;

    private void SpawnPickie(Vector2 position)
    {
        int number = _spawner.FindFreePickie().Data.Number;
        Pickies[number].transform.position = position;

    }

    public void Awake()
    {
        Pickies = new GameObject[100];
        _spawner = new(100);
    }

    
}
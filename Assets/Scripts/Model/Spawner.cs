using UnityEngine;

public class Spawner
{
    public Pickie[] Pickies;

    public Spawner(int count)
    {
        Pickies = new Pickie[count];
        for(int i = 0; i < count; i++)
        {
            Pickies[i] = new Pickie(i); 
        }
    }

    public Pickie FindFreePickie()
    {
        for(int i = 0; i < Pickies.Length; i++)
        {
            if(!Pickies[i].Data.InGame) return Pickies[i];
        }
        return null;
    }
}
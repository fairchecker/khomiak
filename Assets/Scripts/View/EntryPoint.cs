using UnityEngine;

public class EntryPoint : MonoBehaviour
{
    private void Awake()
    {
        var data = new CharacterData("kent", 0);
        var character = new Character(data);

        var view = GetComponent<CharacterView>();
        view.Initialise(character);

        


    }
}

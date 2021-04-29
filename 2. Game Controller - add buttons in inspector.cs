using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public List<Sprite> gamePuzzles = new List<Sprite>();
    
    void Start()
    {
        GetButtons();

    }
    void GetButtons()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("PuzzleButton");

        for(int i=0; i<objects.Length; i++)
        {
            btns.Add(objects[i].GetComponent<Button>());
        }
    }
}

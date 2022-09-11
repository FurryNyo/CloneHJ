using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelNumberNext : MonoBehaviour
{
    public Text Text;
    public Game Game;

    private void Start()
    {
        Text.text = (Game.LevelIndex + 2).ToString();
    }
}

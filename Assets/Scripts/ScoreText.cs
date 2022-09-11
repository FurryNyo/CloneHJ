using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public Text Text;
    public Player Player;

    private void Update()
    {
        Text.text = (Player.Score).ToString();
    }
}

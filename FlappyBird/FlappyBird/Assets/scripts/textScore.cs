using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textScore : MonoBehaviour
{
    public int Score = 0;
    public Text text;

    public void addScore()
    {
        Score++;
        text.text = Score.ToString();
    }
}

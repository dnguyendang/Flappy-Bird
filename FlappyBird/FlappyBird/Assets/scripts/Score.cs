using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public AudioSource aus;
    public AudioClip pointSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(aus && pointSound)
        {
            aus.PlayOneShot(pointSound);
        }
        FindObjectOfType<textScore>().addScore();
    }
}

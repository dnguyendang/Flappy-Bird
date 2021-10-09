using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyBird : MonoBehaviour
{
    Rigidbody2D rg;
    public float speed;
    public GameObject gameOverObj;

    public AudioSource aus;
    public AudioClip dieSound;
    public AudioClip hitSound;
    public AudioClip wingSound;
    public AudioClip swooshSound;

    private void Start()
    {
        Time.timeScale = 1;
        rg = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            rg.AddForce(Vector2.up * speed);
            if (aus && wingSound)
            {
                aus.PlayOneShot(wingSound);
            }
        }
    }

    public void resetGame()
    {
        if(aus && swooshSound)
        {
            aus.PlayOneShot(swooshSound);
        }
        SceneManager.LoadScene(0);
    }

    void GameOver()
    {
        gameOverObj.SetActive(true);
        if(aus && dieSound)
        {
            aus.PlayOneShot(dieSound);
        }
        Time.timeScale = 0;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(aus && hitSound)
        {
            aus.PlayOneShot(hitSound);
        }
        GameOver();
    }
}

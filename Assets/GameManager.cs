using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{


    public static GameManager instance = null;
    public int eggsCollected = 0;
    AudioSource collectSFX;
    public AudioSource winSFX, LoseSFX;
    public Text winText, loseText;


    // Start is called before the first frame update
    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        } else if(instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
        collectSFX = GetComponent<AudioSource>();
        winText.enabled = false;
        loseText.enabled = false;

    }

    public void CollectEgg()
    {
        eggsCollected++;
        collectSFX.Play();
        if (eggsCollected == 15) WinGame();
    }

    public void WinGame()
    {
        winSFX.Play();
        winText.enabled = true;
        Invoke("QuitGame", 5);
        Application.Quit();
    }

    public void LoseGame()
    {
        LoseSFX.Play();
        loseText.enabled = true;
        Invoke("QuitGame", 5);
        Application.Quit();
    }

    private void QuitGame()
    {
        Application.Quit();
    }
}

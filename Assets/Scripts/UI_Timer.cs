using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Timer : MonoBehaviour
{

    public float maxTime;
    public Slider slider;

    private float timeRemaining;

    // Start is called before the first frame update
    void Start()
    {
        timeRemaining = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        timeRemaining -= Time.deltaTime;
        Debug.Log(timeRemaining);
        if(timeRemaining <= 0f)
        {
            Debug.Log("Quit The Game");
            GameManager.instance.LoseGame();
        }
        slider.value = getSliderVal();
    }

    float getSliderVal()
    {
        return timeRemaining / maxTime;
    }
}

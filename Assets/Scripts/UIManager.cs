using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject StartMenuUI;
    public Text timeText;

    private void Start()
    {
        Time.timeScale = 0;
    }

    private void Update()
    {
        float t = Time.time;
        float minutes = (t / 60);
        float seconds = (t % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void StartTheGame()
    {
        StartMenuUI.SetActive(false);
        Time.timeScale = 1;
    }
}

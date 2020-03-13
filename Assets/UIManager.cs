using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject StartMenuUI;
    public Text ScoreText;
    private BlockMovement bm;

    private void Start()
    {
        Time.timeScale = 0;
        bm = GetComponent<BlockMovement>();
    }

    private void Update()
    {
        ScoreText.text = bm.score.ToString();
    }

    public void StartTheGame()
    {
        StartMenuUI.SetActive(false);
        Time.timeScale = 1;
    }
}

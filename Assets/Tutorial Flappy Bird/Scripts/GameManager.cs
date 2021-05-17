using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    static public GameManager instance;
    private void Awake()
    {
        instance = this;
        gameOverUI.SetActive(false);
    }
    // 기둥 통과할때마다 점수 100점씩 올리자
    // 새가 죽으면 게임 종료 UI표시하자.
    // Start is called before the first frame update
    public GameObject gameOverUI;
    public Text scoreUI;

    bool isGameOver;

    internal void SetGameOver()
    {
        isGameOver = true;
        ShowGameOver(true);
    }

    private void Update()
    {
        if (isGameOver)
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }

    internal void ShowGameOver(bool acitve)
    {
        gameOverUI.SetActive(acitve);
    }

    int score;
    internal void AddScore()
    {
        score += 100;
        scoreUI.text = "Score : " + score;
    }
}

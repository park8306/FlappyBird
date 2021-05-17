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
    // ��� ����Ҷ����� ���� 100���� �ø���
    // ���� ������ ���� ���� UIǥ������.
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

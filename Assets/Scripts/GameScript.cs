using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameScript : MonoBehaviour {

    public GameObject gameOverPanel;
    public TMP_Text scoreText;

    public void GameOver() {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0;
    }
}

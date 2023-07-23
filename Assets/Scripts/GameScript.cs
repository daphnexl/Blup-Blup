using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour {

    public GameObject gameOverPanel;

    public void GameOver() {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0;
    }
}

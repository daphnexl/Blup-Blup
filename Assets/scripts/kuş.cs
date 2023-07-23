using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class kuş : MonoBehaviour
{

    Rigidbody2D rb;
    GameScript gameScript;

    public float zıplama;
    public TMP_Text skor_text;
    public TMP_Text scoreTextGameOver;
    public float skor;

    void Start() {
        gameScript = GetComponent<GameScript>();
        skor = 0;
        rb = GetComponent<Rigidbody2D>();
        
    }

    
    void Update() {
        if(Input.GetMouseButtonDown(0)) {
            rb.velocity = Vector2.up * zıplama;
        }
        skor_text.text = "Score: " + skor.ToString();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Zemin") || other.gameObject.CompareTag("Boru"))
        {
            scoreTextGameOver.text = "Score: " + skor.ToString();
            gameScript.GameOver();
        }
        else if (other.gameObject.CompareTag("Scorer"))
        {
            skor++;
        }
    }
        

}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class kuş : MonoBehaviour
{
    public float zıplama;

    Rigidbody2D rb;
    GameScript gameScript;
    public TMP_Text skor_text;
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
        skor_text.text = skor.ToString();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Zemin") || other.gameObject.CompareTag("Boru"))
        {
            gameScript.GameOver();
        }
        else if (other.gameObject.CompareTag("Scorer"))
        {
            skor++;
        }
    }
        

}

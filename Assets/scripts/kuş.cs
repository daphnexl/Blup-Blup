using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kuş : MonoBehaviour
{
    public float zıplama;

    Rigidbody2D rb;
    GameScript gameScript;

    void Start() {
        gameScript = GetComponent<GameScript>();
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update() {
        if(Input.GetMouseButtonDown(0)) {
            rb.velocity = Vector2.up * zıplama;
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Zemin") || other.gameObject.CompareTag("Boru")) {
            gameScript.GameOver();
        }
    }
}

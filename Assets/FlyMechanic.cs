using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyMechanic : MonoBehaviour{

    public GameManager gameManager;
    public float velocity = 1;
    private Rigidbody2D rb;
    private bool collidied = false;
    // Start is called before the first frame update
    void Start(){
        rb =GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update(){
        if(collidied==false){
            // Detects mouse button click, 0 being left click
            if(Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)){
                SoundManagerScript.PlaySound(1);
                // Jump
                rb.velocity = Vector2.up * velocity;
            }

        }
    }

    private void OnCollisionEnter2D(Collision2D collision){
        collidied=true;
        SoundManagerScript.PlaySound(2);

        gameManager.GameOver();
    }
}

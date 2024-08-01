using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControls : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody2D rb;

    public float downSpeed = 20f;

    public float movementSpeed = 10f;

    public float movement = 0f;

    public Text scoreText;

    private float topScore = 0.0f;

    public void OnCollisionEnter2D(Collision2D collision){
        Vector2 velocity = rb.velocity;

        if (velocity.y <= 0){
            rb.velocity = new Vector3(rb.velocity.x, downSpeed, 0);
        }

    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal") * movementSpeed;

        if (movement < 0){
            this.GetComponent<SpriteRenderer>().flipX = false;
        }
        else{
            this.GetComponent<SpriteRenderer>().flipX = true;
        }

        if (rb.velocity.y > 0 && transform.position.y > topScore){
            topScore = transform.position.y;
        }
        scoreText.text = "Score: " + Mathf.Round(topScore).ToString();
    }
}

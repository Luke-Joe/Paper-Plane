using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public GameManager gameManager;
    public float speed = 2;
    private bool goingRight;
    public Sprite planeDown;
    public Sprite planeDefault;
    void Start()
    {
        goingRight = true;
    }

    // Update is called once per frame
    void Update()
    {   

        if (Input.GetMouseButtonDown(0)) {
            FindObjectOfType<audioManager>().Play("Flip");
            goingRight = !goingRight;
        }

        if (Input.GetMouseButton(0)) {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = planeDown;
        } else {
            if (goingRight == true) {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = planeDefault;
                transform.Translate(Vector2.right * speed * Time.deltaTime);
                transform.localScale = new Vector2(1, 1);
            } else {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = planeDefault;
                transform.Translate(Vector2.left * speed * Time.deltaTime);
                transform.localScale = new Vector2(-1, 1);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        FindObjectOfType<audioManager>().Play("PlayerDeath");
        gameManager.GameOver();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 2;
    private bool goingRight;
    //Animator anim;
    void Start()
    {
        //anim = gameObject.GetComponent<Animator>();
        goingRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (goingRight == true) {
            //anim.setTrigger("Active");
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            transform.localScale = new Vector2(1, 1);
        } else {
            //anim.setTrigger("Active");
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            transform.localScale = new Vector2(-1, 1);
        }
        
        if (Input.GetMouseButtonDown(0)) {
            goingRight = !goingRight;
        }
    }
}

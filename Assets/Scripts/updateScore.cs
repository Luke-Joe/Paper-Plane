using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updateScore : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "Player") {
            score.count++;
            FindObjectOfType<audioManager>().Play("Point");
        }
    }
}

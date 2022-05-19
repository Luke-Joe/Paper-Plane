using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePipe : MonoBehaviour
{
    public float speed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)) {
            speed = 4f;
        } else {
            speed = 3f;
        }
        
        transform.position += Vector3.up * speed * Time.deltaTime;
    }
}

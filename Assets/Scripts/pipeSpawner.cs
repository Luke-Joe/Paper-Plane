using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSpawner : MonoBehaviour
{
    public float spawnTime = 1f;
    private float timer = 0;
    public GameObject pipe;
    public float width;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)) {
            spawnTime = 0.66f;
        } else {
            spawnTime = 1f;
        }
        if (timer > spawnTime) {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = transform.position + new Vector3(Random.Range(-width, width), 0, 0);
            Destroy(newPipe, 15);
            timer = 0;
        }

        timer += Time.deltaTime;
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSpawner : MonoBehaviour
{
    public float spawnTime = 1f;
    private float timer = 0;
    public GameObject pipe;
    public float width;

    // Update is called once per frame
    void Update()
    {
        if (timer > spawnTime)
        {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = transform.position + new Vector3(Random.Range(-width, width), 0, 0);
            Destroy(newPipe, 15);
            timer = 0;
        }

        timer += Time.deltaTime;

    }
}

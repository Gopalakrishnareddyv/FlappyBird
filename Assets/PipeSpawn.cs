using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    public GameObject[] pipe;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("PipeSpawns",1.0f, 1.5f);
    }
    void PipeSpawns()
    {
        int value = Random.Range(0, pipe.Length);
        GameObject pipes = Instantiate(pipe[value]);
        pipes.transform.position = new Vector2(12.0f, 0.28f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBg : MonoBehaviour
{
    public float offsetvalue;
    Material bg;
    // Start is called before the first frame update
    void Start()
    {
        bg = GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        bg.mainTextureOffset = new Vector2(offsetvalue * Time.time, 0);
    }
}

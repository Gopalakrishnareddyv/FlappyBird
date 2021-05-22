using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPipes : MonoBehaviour
{
    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}

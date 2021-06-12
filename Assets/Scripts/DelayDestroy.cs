using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayDestroy : MonoBehaviour
{

    public float time = 1.3f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Romove", time);
    }

    
    void Romove()
    {
        Destroy(gameObject);
    }
}

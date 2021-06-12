using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMove : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public float speed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();    
    }

    // Update is called once per frame
    void Update()
    {
        spriteRenderer.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0);
    }
}

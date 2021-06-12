using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnSprite : MonoBehaviour
{
    public float speed = 10;
    public Transform prefabExplosion;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-1 * speed * Time.deltaTime, 0, 0);
    }

    // private void OnTriggerEnter2D(Collider2D collision)
    // {
    //     if (collision.gameObject.layer == LayerMask.NameToLayer("PlayerBullet"))
    //     {
    //         Transform trans = Instantiate(prefabExplosion, transform.position, Quaternion.identity);
    //         Destroy(gameObject);
    //     }
    // }
}

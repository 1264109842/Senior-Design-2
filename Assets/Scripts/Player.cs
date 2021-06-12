using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 6;
    public Transform prefabBullet;
    public Transform prefabExplosion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Move(h, v);

        if(Input.GetKeyDown("space")||Input.GetButtonDown("Fire1"))
        {
            Fire();
        }
    }

    void Move(float h, float v)
    {
        Vector3 newPos = transform.position + new Vector3(h, v, 0) * speed * Time.deltaTime;

        if (newPos.x > 10.6 || newPos.x < -10.6)
        {
            newPos.x = transform.position.x;
        }
        if (newPos.y > 4.75 || newPos.y < -4.75)
        {
            newPos.y = transform.position.y;
        }
        transform.position = newPos;
    }

    void Fire()
    {
        Transform bullet = Instantiate(prefabBullet, transform.position, Quaternion.identity);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == LayerMask.NameToLayer("Enemy") ||
            collision.gameObject.layer == LayerMask.NameToLayer("EnemyBullet"))
        {
            Transform trans = Instantiate(prefabExplosion, transform.position, Quaternion.identity);
            //Player Dead
            //Debug.Log("Player dead");
            Destroy(gameObject);
            GameMode.Instance.GameOver();
        }
    }
}

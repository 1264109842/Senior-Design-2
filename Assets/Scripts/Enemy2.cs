using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    public float speed = 7;
    public Transform prefabExplosion;
    public Transform prefabBullet;
    public float fireTimer = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Fire()
    {
        Transform bullet = Instantiate(prefabBullet, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-1 * speed * Time.deltaTime, 0, 0);
        fireTimer -= Time.deltaTime;
        if (fireTimer <= 0)
        {
            fireTimer = 1;
            Fire();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("PlayerBullet"))
        {
            Transform trans = Instantiate(prefabExplosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
            ScoreScript.scoreValue += 2;
            if (ScoreScript.scoreValue >= 20)
            {
                GameMode.Instance.GameWin();
            }
        }
    }
}
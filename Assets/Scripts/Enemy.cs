using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 7;
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == LayerMask.NameToLayer("PlayerBullet"))
        {
            Transform trans = Instantiate(prefabExplosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
            ScoreScript.scoreValue += 1;
            if (ScoreScript.scoreValue >= 20)
            {
                GameMode.Instance.GameWin();
            }
        }
    }
}

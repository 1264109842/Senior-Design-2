using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform prefab;
    public float timeGap = 1f;
    public int num = 1; //enemy #
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Logic());
    }

    // Update is called once per frame
    IEnumerator Logic()
    {
        while(true)
        {
            for(int i = 0; i < num; i++)
            {
                Transform trans = Instantiate(prefab);
                float y = Random.Range(-4.5f, 4.5f);
                trans.position = new Vector3(13.5f, y, 0);
            }
            

            yield return new WaitForSeconds(timeGap);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner2 : MonoBehaviour
{
    public Transform prefab;
    public float speed = 8;
    public float timeGap = 2f;
    public float minOffSet = -8;
    public float maxOffSet = -5;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Logic());
    }

    // Update is called once per frame
    IEnumerator Logic()
    {
        while (true)
        {
            Transform trans = Instantiate(prefab);
            float y = Random.Range(minOffSet, maxOffSet);
            trans.position = new Vector3(13.5f, y, 0);

            yield return new WaitForSeconds(timeGap);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public GameObject Boom;
    public float times;
    float count;
    void Start()
    {
        count = times;
    }

    // Update is called once per frame
    void Update()
    {
        if (times > 2)
            times -= 0.0001f;
        Spawn();
    }
    void Spawn()
    {
        if (count > 0)
            count -= Time.deltaTime;
        if (count <= 0) {
            count = times;
            Instantiate(Boom, new Vector3(Random.Range(-9, 9), 0, Random.Range(-9, 9)), transform.rotation);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject Bullet;
    public float spawnRateMin = 0.5f;
    public float spawnRateMax = 3f;

    public Transform Point;
    Transform target;
    float time;

    void Start()
    {
        target = GameObject.Find("Player").GetComponent<Transform>();
        time = 1;
    }
    void Update()
    {
        if(spawnRateMax>1.5f)
            spawnRateMax -= 0.00005f;

        Point.LookAt(target);

        time -= Time.deltaTime;

        if (time < 0)
        {
            GameObject bullet = Instantiate(Bullet, Point.position, Point.rotation);
            time = Random.Range(spawnRateMin, spawnRateMax);
        }
    }
}

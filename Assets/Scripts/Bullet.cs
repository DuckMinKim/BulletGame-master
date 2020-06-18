using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed;
        Destroy(gameObject, 3f);
    }
    void Update()
    {
    }
    void OnTriggerEnter(Collider obj)
    {
        if (obj.tag == "Player")
        {
            PlayerController playerController = obj.GetComponent<PlayerController>();
            if (playerController != null)
            {
                playerController.Die();
                Destroy(gameObject);
            }
        }
        if(obj.tag == "Line")
            Destroy(gameObject);
    }
}

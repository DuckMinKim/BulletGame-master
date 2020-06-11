using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody playerRigidbody;
    public float speed = 8f;  

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        h *= speed;
        v *= speed;

        playerRigidbody.velocity = new Vector3(h, 0f, v);
    }

    public void Die()
    {
        gameObject.SetActive(false);
    }
}
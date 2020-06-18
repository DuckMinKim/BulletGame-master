using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatPlayer : MonoBehaviour
{
    Rigidbody RB;

    void Start()
    {
        RB = GetComponent<Rigidbody>();

        Cat kitty = new Cat("kitty");
        kitty.PlaySound();
        kitty.Go();
    }

    

    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow)){
            transform.position = new Vector3(transform.position.x, transform.position.y
            ,transform.position.z+ 3f*Time.deltaTime);
		}
        if(Input.GetKey(KeyCode.DownArrow)){
            transform.position = new Vector3(transform.position.x, transform.position.y
            ,transform.position.z- 3f*Time.deltaTime);
		}
    }
}

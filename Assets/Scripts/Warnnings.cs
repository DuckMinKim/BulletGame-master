using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warnnings : MonoBehaviour
{
    public GameObject boom;
    void Start()
    {
        StartCoroutine(Wait());
    }


    void Update()
    {
        
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);
        Instantiate(boom, transform.position, transform.rotation);
        Destroy(this.gameObject);
    }
}

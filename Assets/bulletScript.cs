using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.forward*Time.deltaTime*-50);
        if (transform.position.z < -1000)
        {
            transform.gameObject.SetActive(false);
        }
    }
   
}

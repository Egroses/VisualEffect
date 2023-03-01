using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunScript : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] float timeCount;
    void Start()
    {
        StartCoroutine(fireGun());
    }

   IEnumerator fireGun()
    {
        GameObject bulletObj = Instantiate(bullet,transform.position,Quaternion.identity);
        yield return new WaitForSeconds(timeCount);
        StartCoroutine(fireGun());
    }
}

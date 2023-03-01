using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;
public class ballScript : MonoBehaviour
{
    [SerializeField] float instantHealt;
    [SerializeField] float moveSpeed;
    [SerializeField] float turnSpeed;
    [SerializeField] float jumpAmount;
    [SerializeField] float healtAmount;
    [SerializeField] float damageAmount;
    [SerializeField] GameObject Door;
    [SerializeField] GameObject Ball;
    [SerializeField] GameObject energyBall;
    [SerializeField] TextMeshProUGUI textMesh;

    float turnAmount;
    private void OnEnable()
    {
        instantHealt = healtAmount;
        turnAmount = 0;
        textMesh.text = instantHealt + "";
    }

    void Update()
    {
        moveBall();   
    }
    void moveBall()
    {
        turnAmount += turnSpeed;
        transform.position += moveSpeed*Time.deltaTime*Vector3.forward;
        Ball.transform.rotation=Quaternion.Euler(Ball.transform.rotation.x+turnAmount,0,0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("bullet"))
        {
            takeDamage(other.gameObject);
        }
    }

    void takeDamage(GameObject bulletObj)
    {
        if (instantHealt > 0)
        {
            instantHealt -= damageAmount;
            bulletObj.SetActive(false);
            textMesh.text = instantHealt + "";
        }
        if (instantHealt <= 0)
        {
            textMesh.enabled = false;
            Ball.transform.gameObject.SetActive(false);
            StartCoroutine(openDoor());
        }
        
            
        
    }

    IEnumerator openDoor()
    {
        GameObject energyObj = Instantiate(energyBall, transform.position, Quaternion.identity);
        energyObj.transform.DOJump(transform.position - jumpAmount * Vector3.forward-3.5f*Vector3.up,2f,1,1);
        yield return new WaitForSeconds(1);
        GameObject doorObj = Instantiate(Door, energyObj.transform.position, Quaternion.identity);
        energyObj.SetActive(false);
        doorObj.transform.localScale = Vector3.zero;
        doorObj.transform.DOScale(1, 0.3f);
        yield return new WaitForSeconds(0.5f);
        transform.gameObject.SetActive(false);
    }
}

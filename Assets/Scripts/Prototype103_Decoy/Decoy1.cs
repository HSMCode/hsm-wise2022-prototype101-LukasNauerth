using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decoy1 : MonoBehaviour
{
    public GameObject Roboter;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(gameObject.name + " GOT HIT BY " + other.name);
            Debug.Log("Oops! This wasn't the one !");
                Destroy(this.gameObject);
                
        
    }
}
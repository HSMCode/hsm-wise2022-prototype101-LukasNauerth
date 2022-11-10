using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decoy1 : MonoBehaviour
{
    public GameObject Roboter;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(gameObject.name + " GOT SMASHED BY " + other.name);

        if(other.name == Roboter.name)
        {
            Debug.Log("Oops! THis wasn't the one !");
        }
    }
}
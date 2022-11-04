using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roboter : MonoBehaviour
{
    public float stepForward =1f;
    public float stepBack= -1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // transform.Translate(0,stebLeft,stepBack);

        if(Input.GetKeyDown("w"))
        transform.Translate(0,0,stepForward);

         if(Input.GetKeyDown("s"))
        transform.Translate(0,0,stepBack);

         if(Input.GetKeyDown("d"))
        transform.Translate(stepForward,0,0);

         if(Input.GetKeyDown("a"))
        transform.Translate(stepBack,0,0);


    }
}

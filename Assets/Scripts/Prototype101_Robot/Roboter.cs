using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roboter : MonoBehaviour
{
    public float stepForward =1f;

    public float turn= 90;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // transform.Translate(0,stebLeft,stepBack);

        if(Input.GetKeyDown("s"))
        transform.Translate(0,0,stepForward);

         if(Input.GetKeyDown("w"))
        transform.Translate(0,0,-stepForward);

         if(Input.GetKeyDown("a"))
        transform.Translate(stepForward,0,0);

         if(Input.GetKeyDown("d"))
        transform.Translate(-stepForward,0,0);

        if(Input.GetKeyDown("q"))
        transform.Rotate(0,-turn,0);

         if(Input.GetKeyDown("e"))
        transform.Rotate(0,turn,0);
    }
}

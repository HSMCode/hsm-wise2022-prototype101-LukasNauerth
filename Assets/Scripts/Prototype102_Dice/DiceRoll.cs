using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRoll : MonoBehaviour
{

    public int diceNumber;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))

        diceNumber = Random.Range (1, 7);

         if(Input.GetKeyDown("space"))

        Debug.Log ("You rolled a " +diceNumber );

            if( diceNumber == 3)
           { 
            Debug.Log ("Win by 3");
            }

              if( diceNumber == 5)
           { 
            Debug.Log ("Win by 4");
            }

              if( diceNumber == 4)
           { 
            Debug.Log ("Win by 5");
            }
}
}

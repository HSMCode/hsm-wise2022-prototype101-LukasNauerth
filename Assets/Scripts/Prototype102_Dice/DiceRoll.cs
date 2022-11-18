using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRoll : MonoBehaviour

{
AudioSource WinSound;

    public float diceNumber =0f;
    // Start is called before the first frame update
    void Start()
    {
         WinSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
        diceNumber = Random.Range (1, 51);

         if(Input.GetKeyDown("space"))

        Debug.Log ("You rolled a " +diceNumber );

            if( diceNumber == 3 || diceNumber == 4|| diceNumber == 10 || diceNumber == 5
            || diceNumber == 6|| diceNumber == 7|| diceNumber == 8|| diceNumber == 9)
           { 
            Debug.Log ("Win by " +diceNumber);
            diceNumber = 0;
            WinSound.Play ();
            }
            else
            {
                Debug.Log ("Sorry, you lost!");
                
            }
        }
}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TryVariables : MonoBehaviour
{
    public int AmountOfApples =2;
    public int AmountOfPears = 4;
    public int AmountOfBananas =3;
    public int AmountOfGrapes=20;
    public int AmountOfOranges=3;
    public int Result;
    // Start is called before the first frame update
    void Start()
    {
        Result= (AmountOfApples+ AmountOfBananas+AmountOfGrapes+
        AmountOfPears+AmountOfOranges)/3;

        Debug.Log("Es gibt " +Result+ " Stuecke Obst");
        Debug.Log(Result);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

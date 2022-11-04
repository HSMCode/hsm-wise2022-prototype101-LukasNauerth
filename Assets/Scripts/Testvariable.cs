using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testvariable : MonoBehaviour
{
    public int numberOne = 1;
    public int numberTwo = 2;
    public int result;
    public float numberThree = 3.8f;
    public string stringOne ="slayy";

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(numberThree);

        result = numberOne + numberTwo;

        Debug.Log("Das Resultat: " + result);

        Debug.Log(stringOne);

        //transform.position += new Vector3(0, 2, 0);
    }

    // Update is called once per frame
    void Update()
    {
     
    }
}

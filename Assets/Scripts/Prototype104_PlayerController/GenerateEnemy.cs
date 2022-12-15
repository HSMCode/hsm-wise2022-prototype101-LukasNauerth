using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemy : MonoBehaviour
{
    public GameObject theEnemy;
    public int xPos;
    public int zPos;
    public int enemyCount;
    void Start()
    {
        StartCoroutine(EnemyDrop());
    }

    IEnumerator EnemyDrop()
    {
        while (enemyCount < 10)
        { 
            xPos = Random.Range(-69, 69);
            zPos = Random.Range(-74, 65);
            Instantiate(theEnemy, new Vector3(xPos,0,zPos), Quaternion.identity);
            yield return new WaitForSeconds (1f);
            enemyCount += 1;
        }
        
    }


}
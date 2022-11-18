using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateDecoys : MonoBehaviour
{
    public GameObject Decoy;
    public GameObject[] Decoys;
    public float spawnPositionX=15f;
    public float spawnPositionZ=15f;
    public int spawnAmount=20;
    // Start is called before the first frame update
    void Start()
    {
        SpawningDecoy();
    }

    // Update is called once per frame
   void Update()
    {
        if(Input.GetKeyDown("space"))
        {               
           // Vector3 spawnPosition = new Vector3(Random.Range(-spawnPositionX,spawnPositionX),0.5f,Random.Range(-spawnPositionZ,spawnPositionZ));

            //for( int i=0; i<spawnAmount; i++)
           // {
            //Vector3 spawnPosition = new Vector3(Random.Range(-spawnPositionX,spawnPositionX),0.5f,Random.Range(-spawnPositionZ,spawnPositionZ));

          //  Instantiate(Decoy, spawnPosition, transform.rotation);


            //}

            SpawningDecoy();
        }
    }


    void SpawningDecoy()
    {
         for (int i=0; i<spawnAmount; i++)
        {
            int decoysIndex = Random.Range(0,Decoys.Length);

            Vector3 spawnPosition = new Vector3(Random.Range(-spawnPositionX,spawnPositionX),0.5f,Random.Range(-spawnPositionZ,spawnPositionZ));

            Instantiate(Decoys[decoysIndex], spawnPosition, transform.rotation);
        }
}


    void SpawningDecoyParam(int amount)
    {
         for (int i=0; i<spawnAmount; i++)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnPositionX,spawnPositionX),0.5f,Random.Range(-spawnPositionZ,spawnPositionZ));

            Instantiate(Decoy, spawnPosition, transform.rotation);
        }
}


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerGoal : MonoBehaviour
{

    public ParticleSystem playParticlesSystem;
    public ParticleSystem emitParticlesSystem;

      public GameObject Roboter;

  
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(gameObject.name + " GOT SMASHED BY " + other.name);

        if(other.name == Roboter.name)
        {
            Debug.Log("Victory !");
            EmitParticles();
        
        }
    }


    void EmitParticles()
    {
        emitParticlesSystem.Emit(500);
    }

    void PlayParticles(bool on)
    {
        if(on)
        {
        playParticlesSystem.Play();
        }
        else if(!on)
        {
        playParticlesSystem.Stop();
        }
    }

 private void OnTriggerExit(Collider other)
 {
     Debug.Log(other.name + "triggered into" + gameObject.name);
     if (other.name == Roboter.name)
     {
         Debug.Log("Exit");
         PlayParticles(false);
     }
 }

}




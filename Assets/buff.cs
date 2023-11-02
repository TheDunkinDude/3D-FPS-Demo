using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buff : MonoBehaviour
{
 
  public float multiplier = 2f;
  
  void OnTriggerEnter(Collider Other)
   {
        if (Other.CompareTag("Player"))
        {
            StartCoroutine(Pickup(Other));
        }
   }
  IEnumerator Pickup(Collider player){


        player.transform.localScale *= multiplier;

        yield return new WaitForSeconds(10);

        player.transform.localScale /= multiplier;

  }
}

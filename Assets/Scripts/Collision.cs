using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public Character character;

    public bool collidesPlayer = false;

      private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == character.gameObject)
        {
          print("chocando");
          collidesPlayer = true;
        } 
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject == character.gameObject)
        {
          collidesPlayer = false;
        } 
    }

   // private void OnTriggerStay(Collider other)
    //{
      //  if(other.gameObject == character.gameObject)
        //{
          //collidesPlayer = true;
        //} 
   // }
}

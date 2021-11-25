using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : InteractiveObject
{
    public UsableObjects asset_in_hand;
        public Transform posicionAparecer;

   void Update()
    {
        
        this.transform.position = posicionAparecer.transform.position; 
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class IdleState : State
{
        public ChaseState chaseState;
        public Character Character;

        
    public override State RunCurrentState()
    {
        
        var ver = Character.GetComponent<ViewHer>().viendo;
  
        if(ver == true)
        {
            return chaseState;
        } else {
            return this;
        }
    }
}

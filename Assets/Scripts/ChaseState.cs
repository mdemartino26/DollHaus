using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseState : State
{
     public Character Character;

    public AttackState attackState;

    public IdleState idleState;
    public bool inAttackRange;
   
    public Collision col;

    public float tempo;

    public float tempoMax;



    public override State RunCurrentState()
    {
        tempo += Time.deltaTime;

        if (tempo >= tempoMax)
        {
            var ver = Character.GetComponent<ViewHer>().viendo;
            var choca = col.collidesPlayer;

            if (ver == false && choca == true)
            {
                print("ataque");
                return attackState;
            }
            else
            {
                print("idle");
                tempo = 0;
                return this;
            }
        }
        else
        {
            return this;
        }

    }
}



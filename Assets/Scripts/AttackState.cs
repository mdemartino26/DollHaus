using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AttackState : State
{

    public GameOverScreen gameOverScreen;
    public override State RunCurrentState()
    {
        gameOverScreen.Setup();
        return this;
    }


}
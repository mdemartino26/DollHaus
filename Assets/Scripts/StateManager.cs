using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    
   public State currentState;

    // Update is called once per frame
    void Update()
    {
        RunStateMachine();
    }

    private void RunStateMachine()
    {
        State nextState = currentState?.RunCurrentState(); //el ? es para saber que la variable no es null, si es null lo ignora

        if( nextState != null)
        {
            //pasar al siguiente state
            SwitchToNextState(nextState);
        }
    }

    private void SwitchToNextState(State nextState)
    { //cambia el state que tenia al que va a venir
        currentState = nextState;
    }
    
}

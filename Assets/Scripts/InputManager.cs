using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{

    public Character character;
    public float verticalAxis;
    public float horizontalAxis;
    public bool buttonSkill;

    public float horizontalMouse;
    public float verticalMouse;


    //Acceder por ID
    void Update()
    {
        verticalAxis = Input.GetAxis("Vertical");
        horizontalAxis = Input.GetAxis("Horizontal");
        buttonSkill = Input.GetMouseButtonDown(0);

        horizontalMouse = Input.GetAxis("Mouse Y");
        verticalMouse = Input.GetAxis("Mouse X");

        character.Move(horizontalAxis, verticalAxis);
    }
}


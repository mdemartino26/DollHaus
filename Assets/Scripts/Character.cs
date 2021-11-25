using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float maxSpeed = 5;
    public float rotationSpeed;
    public InteractiveObject ioActive = null;
    public Inventory inventory;
    public float speed;

    public InputManager inputManager;

    public ActionsManager actions;



    public void Move(float _horizontal, float _vertical)
    {
    }

    public void Update()
    {
       Vector3 moveVector = (Vector3.forward * inputManager.verticalAxis) + (Vector3.right * inputManager.horizontalAxis);

       transform.Translate(moveVector * speed * Time.deltaTime);

       
    }

    // public void OnInteract()
    // {

    //     if (ioActive != null)
    //         ioActive.OnInteract(this);
    // }
    // private void OnTriggerEnter(Collider other)
    // {
    //     InteractiveObject io = other.gameObject.GetComponent<InteractiveObject>();
    //     if (io != null)  { ioActive = io; }
    // }
    // private void OnTriggerExit(Collider other)
    // {
    //     InteractiveObject io = other.gameObject.GetComponent<InteractiveObject>();
    //     if (io != null) { ioActive = null; }
    // }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : InteractiveObject
{
    public Vector3 openPosition;
    Vector3 originalPosition;
    public bool open =false ;
    public float speed = 5;

    public Transform puertaChild;

    private void Start()
    {
        originalPosition = transform.localPosition;
        puertaChild = transform.GetChild(0);
        originalPosition = puertaChild.localPosition;
    }
    private void Update()
    {
        Vector3 dest = Vector3.zero;
        if(open && puertaChild.localPosition != openPosition)
        {
            dest = openPosition;
        }
        else if (!open && puertaChild.localPosition != originalPosition)
        {
            dest = originalPosition;
        }
        if(dest != Vector3.zero)
            puertaChild.localPosition = Vector3.Lerp(puertaChild.localPosition, dest, speed*Time.deltaTime);
    }
    private void OnTriggerEnter(Collider collision)
    {
        Character character = collision.gameObject.GetComponent<Character>();
        /* if(character != null)
        {
            character.inventory.HasItem("Bla");
        } */
        print("choca");
        if(collision.gameObject == character.gameObject)
        {
        open = true; 
        }
    } 

    private void OnTriggerExit(Collider collision)
    {
        Character character = collision.gameObject.GetComponent<Character>();
        /* if(character != null)
        {
            character.inventory.HasItem("Bla");
        } */
        print("chau");
        if(collision.gameObject == character.gameObject)
        {
        open = false; 
        }
    } 
    public void Open()
    {
        open = true;
    }
    public void Close()
    {
        open = false;
    }
}

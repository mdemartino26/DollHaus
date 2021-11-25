using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionsManager : MonoBehaviour
{
    public Animator anim;
    public Transform hand;
    public UsableObjects grabbedObject = null;
    string usableObjectName = "";


    public void GetObject(UsableObjects usableObject)
    {
        if (grabbedObject != null && usableObject.name == usableObjectName)
        {
            ResetGrabbedItems();
            return;
        }
        ResetGrabbedItems();
        usableObjectName = usableObject.name;
        grabbedObject = Instantiate(usableObject, hand);
        grabbedObject.transform.localPosition = Vector3.zero;
    }
    void ResetGrabbedItems()
    {
        if (grabbedObject != null)
            Destroy(grabbedObject.gameObject);
        grabbedObject = null;
    }
    public UsableObjects HasSomethingUsableInHand()
    {
        return hand.GetComponentInChildren<UsableObjects>();
    }
}

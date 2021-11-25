using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsableObjects : MonoBehaviour
{
    public type types;
    public bool flaslightenabled;
    public GameObject Luz;
    public enum type
    {
        WEAPON,
        FLASHLIGHT,
        SHELTER
    }

    public void UseIt()
    {
        print("Me usaron " + gameObject.name);
         
    if (types == type.FLASHLIGHT)
    {flaslightenabled =! flaslightenabled; 
     print("tocaste e para " + gameObject.name);
    if (flaslightenabled)
            Luz.SetActive(true);
        else 
            Luz.SetActive(false);
    }

    
    }
    }


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryButton : MonoBehaviour
{
    public InteractiveObject io;
    public Image thumb;

    public void Init(InteractiveObject io)
    {
        this.io = io;
        thumb.sprite = io.thumb;
    }
    public void Clicked()
    {
        io.UseIt();
    }
}

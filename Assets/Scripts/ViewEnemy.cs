using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewEnemy : MonoBehaviour
{
    
    public Camera cam;
    public GameObject muñeco;

    private bool IsVisible(Camera c, GameObject muñeco)
    {
    var planes =  GeometryUtility.CalculateFrustumPlanes(c);
    var point = muñeco.transform.position;

    foreach (var plane in planes)
    {
        if (plane.GetDistanceToPoint(point) < 0 )
        {
            return false;
        }
    }
    return true;

    }

    private void Update()
    {
        var muñecoRender= muñeco.GetComponent<Renderer>();

        if (IsVisible(cam, muñeco))
        {
            print("enemigo detectado");
        }

    }

}
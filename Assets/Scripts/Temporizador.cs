using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temporizador : MonoBehaviour
{

    public Transform posicionAparecer;

    public float tempo = 0;
    public float tempoMax; 

    public float tempoBye; 

    public Transform posicionDesaparecer;

    public AudioSource AudioSource;




    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        tempo += Time.deltaTime;

        if(tempo >= tempoMax) {
            
            this.transform.position = posicionAparecer.transform.position; 
            AudioSource.Play();
            tempo = 0;
        } else {
             
        }

        if(tempo >= tempoBye){

             this.transform.position = posicionDesaparecer.transform.position; 
        }


    }
}

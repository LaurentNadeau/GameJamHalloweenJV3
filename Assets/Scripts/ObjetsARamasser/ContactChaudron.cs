using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactChaudron : MonoBehaviour
{
    public AudioSource Son;
    private void OnTriggerEnter(Collider other)
        {
            if(other.gameObject.tag == "Objet"){
                GetComponent<AudioSource>().Play();
                Destroy(gameObject);       
            }
        }        
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactChaudron : MonoBehaviour
{
    public AudioSource Son;
    
    private void OnCollisionEnter(Collision other)
        {
            
            if(other.gameObject.tag == "Chaudron"){
                Son.Play();
                Destroy(gameObject);  
            }
        }        
}

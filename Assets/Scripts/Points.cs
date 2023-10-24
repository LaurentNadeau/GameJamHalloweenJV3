using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Points : MonoBehaviour
{
    [SerializeField]
    private InfosJoueur _joueur;

    [SerializeField]
    private int _valeur;

    [SerializeField]
    private GameObject _obstacle;

    void Start()
    {

    }

    void OnCollisionEnter(Collision other){
        if(other.transform.tag == "Chaudron"){
            _joueur.nbPoints += _valeur;
        }
    }
}
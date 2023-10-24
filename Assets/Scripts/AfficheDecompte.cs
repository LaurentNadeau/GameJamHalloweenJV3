using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class AfficheDecompte : MonoBehaviour
{
    [SerializeField] private InfosNiveau _decompte;

    [SerializeField] private TMP_Text _champTexteTemps;

    [SerializeField] private TMP_Text messageFin;

    public void AfficheTemps(){
        float temps = _decompte.temps;

        if(temps < 0){
            temps = 0;
        }

        TimeSpan ts = TimeSpan.FromSeconds(temps);

        _champTexteTemps.text = string.Format("{0:00}:{1:00}:{2:000}", ts.Minutes, ts.Seconds, ts.Milliseconds);

        if(temps == 0){
            messageFin.enabled = true;
        }
        else{
            messageFin.enabled = false;
        }
    }
}

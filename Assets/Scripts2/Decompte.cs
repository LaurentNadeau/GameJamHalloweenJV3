using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Decompte : MonoBehaviour
{
    [SerializeField] private InfosNiveau _decompte;

    private bool _decompteActif = false;

    public UnityEvent auChangementDuTemps;
    public UnityEvent aLaFinDuTemps;

    // Start is called before the first frame update
    void Start()
    {
        DemarrerDecompte();
    }

    // Update is called once per frame
    void Update()
    {
        if(_decompteActif){
            if(_decompte.temps > 0){
                _decompte.temps -= Time.deltaTime;
                auChangementDuTemps.Invoke();
            }
            else{
                _decompte.temps = 0;
                _decompteActif = false;
                aLaFinDuTemps.Invoke();
            }
        }
    }

    public void DemarrerDecompte(){
        _decompte.temps = _decompte.tempsInitial;
        _decompteActif = true;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ToogleSecurity : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject securityZone;
    public bool toogleBool = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void updateSecurity()
    {
        toogleBool = !toogleBool;
        securityZone.SetActive(toogleBool);
    }    
        
}

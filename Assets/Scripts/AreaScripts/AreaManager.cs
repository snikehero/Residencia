using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject securityArea;
    public bool toogleBool = false;
    public static AreaManager instance;
    private void Awake()
    {
        if (instance != null && instance != this)
            Destroy(this);
        else
            instance = this;
    }
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
        securityArea.SetActive(toogleBool);
    }
    public void TurnOff()
    {
        securityArea.SetActive(false);
    }
}

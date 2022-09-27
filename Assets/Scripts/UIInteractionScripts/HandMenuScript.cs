using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandMenuScript : MonoBehaviour
{
    // Start is called before the first frame update 
    public GameObject instructions;
    public static HandMenuScript instance;
    public int i = 0;
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
    public void Next()
    {
        Debug.Log("Next Presionado");
        i++;
        InitialInstructions.instance.Step(i);
        
    }
    public void Last()
    {
        Debug.Log("Last Presionado");
        i--;
        InitialInstructions.instance.Step(i);
        
    }
    public void Test()
    {
        Debug.Log("Test");
    }
}

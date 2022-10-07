using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandMenuScript : MonoBehaviour
{
    // Start is called before the first frame update 
    public GameObject instructions;
    public static HandMenuScript instance;
    public int i = 0;
    public int j = 0;
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
        if (i<19)
        {
            i++;
            InitialInstructions.instance.Step(i);
        }
        if (i >= 19)
        {
            Debug.Log("Ya no avanza");
        }


    }
    public void Last()
    {
        Debug.Log("Last Presionado");
        if(i>0)
        {
            i--;
            InitialInstructions.instance.Step(i);
        }
        if (i<=0)
        {
            Debug.Log("Ya no avanza");
        }
        
        
    }
    public void Test()
    {
        Debug.Log("Test");
    }
    public void NextOnOFF()
    {
        j++;
        OnOffProcess.instance.Step(j);


        
    }
    public void LastOnOFF()
    {
        j--;
        OnOffProcess.instance.Step(j);
    }
}

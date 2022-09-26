using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandMenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator robotAnimator;
    public GameObject instructions;
    public int i = 0;

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
        InitialInstructions.instance.Step(i);
        robotAnimator.Play("MoveRobotOn");
        
        i++;
    }
    public void Last()
    {
        Debug.Log("Last Presionado");
        InitialInstructions.instance.Step(i);
        i--;
    }

    //public void Button1()
    //{
    //    Debug.Log("Boton 1 presionado");
    //    InitialInstructions.instance.Paso1();
    //}
    //public void Button2()
    //{
    //    Debug.Log("Boton 2 presionado");
    //    InitialInstructions.instance.Paso2();
    //}
    //public void Button3()
    //{
    //    Debug.Log("Boton 3 presionado");
    //    InitialInstructions.instance.Paso3();
    //}

}

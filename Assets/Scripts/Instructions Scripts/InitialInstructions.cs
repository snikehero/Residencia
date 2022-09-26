using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InitialInstructions : MonoBehaviour
{
    // Start is called before the first frame update
    
    public TextMeshProUGUI title;
    public TextMeshProUGUI content;
    public static InitialInstructions instance;
    public GameObject[] tooltips;
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
    public void Step(int step)
    {
        switch(step)
        {
            case 1:
                Clear();
                tooltips[0].SetActive(true);
               
                title.text = "Paso 1";
                content.text = "Este es el paso 1";
                
                break;
            case 2:
                Clear();
                tooltips[1].SetActive(true);
                title.text = "Paso 2";
                content.text = "Este es el paso 2";
                
                break;
            case 3:
                Clear();
                tooltips[2].SetActive(true);
                title.text = "Paso 3";
                content.text = "Este es el paso 3";        
                break;
      
            case 4:
                Clear();
                tooltips[3].SetActive(true);
                title.text = "Paso 4";
                content.text = "Este es el paso 4";
                
                break;

        }
    }
    public void Clear()
    {
        tooltips[0].SetActive(false);
        tooltips[1].SetActive(false);
        tooltips[2].SetActive(false);
        tooltips[3].SetActive(false);
    }
    public void Paso1()
    {
        title.text = "Paso 1";
        content.text = "Este es el paso 1";
        
    }
   public void Paso2()
    {
        title.text = "Paso 2";
        content.text = "Este es el paso 2";
    }
    public void Paso3()
    {
        title.text = "Paso 3";
        content.text = "Este es el paso 3";
    }
    public void Paso4()
    {
        title.text = "Paso 4";
        content.text = "Este es el paso 4";
    }
}

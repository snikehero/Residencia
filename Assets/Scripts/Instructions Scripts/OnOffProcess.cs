using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class OnOffProcess : MonoBehaviour
{
    // Start is called before the first frame update
    public static OnOffProcess instance;
    public TextMeshProUGUI title;
    public TextMeshProUGUI content;
    public GameObject[] tooltips;
    public Animator keyAnimator;
   

    public int i;
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
        switch (step)
        {
            case 1:
                Clear();
                title.text = "Botón de Encendido";
                content.text = "Se debe encender la unidad de control presionando el botón verde de encendido.";
                tooltips[0].SetActive(true);
                
                break;
            case 2:
                Clear();
                title.text = "Fuente de Energía PLC";
                content.text = "Se enciende la fuente de energía del PLC de los drivers y relevadores.";
                tooltips[1].SetActive(true);

                break;
            case 3:
                Clear();
                title.text = "Llave en el conmutador";
                content.text = "Insertar la llave en el conmutador den el PLC y girarla a la derecha para activar los drivers y relevadores del robot. ";
                tooltips[2].SetActive(true);
                keyAnimator.Play("MoveKey");
                break;
            case 4:
                Clear();
                title.text = "TeachPendant";
                content.text = "Acerca y Toca el teachPentand";
                keyAnimator.Play("idle");
                break;
            case 5:
                Clear();
                title.text = "Activar Teach Pendant";
                content.text = "Coloque la llave en el Teach Pendant";
                break;
            case 6:
                Clear();
                title.text = "TeachPendant";
                content.text = "Acerca y Toca el teachPentand";
                break;
            case 7:
                Clear();
                title.text = "TeachPendant";
                content.text = "Acerca y Toca el teachPentand";
                break;



        }

    }
    
    public void Clear()
    {
        tooltips[0].SetActive(false);
        tooltips[1].SetActive(false);
        tooltips[2].SetActive(false);
       
    }
    public void FullClear()
    {
        HandMenuScript.instance.j = 0;
        for (int i = 0; i < tooltips.Length; i++)
        {
            tooltips[i].SetActive(false);
        }
    }
}

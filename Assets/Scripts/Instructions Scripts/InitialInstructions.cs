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
    public Animator robotAnimator;
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
                title.text = "Unidad de Control";
                content.text = "Unidad de control";
                robotAnimator.Play("MoveRobotOn");
                break;
            case 2:
                Clear();
                tooltips[1].SetActive(true);
                title.text = "TeachPendant";
                content.text = "Estos es el teach pendant";
                break;
            case 3:
                Clear();
                tooltips[2].SetActive(true);
                title.text = "Cable de Conexion";
                content.text = "cable";        
                break;
      
            case 4:
                Clear();
                tooltips[3].SetActive(true);
                title.text = "Cables de Conexion con el Robot";
                content.text = "Cables de Conexion con el Robot";
                break;
            case 5:
                Clear();
                tooltips[4].SetActive(true);
                title.text = "Manipulador";
                content.text = "Este es el Robot Kuka Agilus KRC 6 R700 SIXX";
                break;
            case 6:
                Clear();
                tooltips[5].SetActive(true);
                title.text = "Ejes";
                content.text = "Estos son los ejes del robot";
                break;
            case 7:
                Clear();
                tooltips[6].SetActive(true);
                title.text = "Eje A1";
                content.text = "Eje A1";
                break;
            case 8:
                Clear();
                tooltips[7].SetActive(true);
                title.text = "Eje A2";
                content.text = "Eje A2";
                break;
            case 9:
                Clear();
                tooltips[8].SetActive(true);
                title.text = "Eje A3";
                content.text = "Eje A3";
                break;
            case 10:
                Clear();
                tooltips[9].SetActive(true);
                title.text = "Eje A4";
                content.text = "Eje A4";
                break;
            case 11:
                Clear();
                tooltips[10].SetActive(true);
                title.text = "Eje A5";
                content.text = "Eje A5";
                break;
            case 12:
                Clear();
                tooltips[11].SetActive(true);
                title.text = "Eje A6";
                content.text = "Eje A6";
                break;
            case 13:
                Clear();
                tooltips[12].SetActive(true);
                title.text = "Componentes";
                content.text = "A continuacion se mostraran las partes del root";
                break;
            case 14:
                Clear();
                tooltips[13].SetActive(true);
                title.text = "Bastidor Base";
                content.text = "El marco base es la base del robot. La interfaz A1 se encuentra en la parte trasera del marco base. ";
                break;
            case 15:
                Clear();
                tooltips[14].SetActive(true);
                title.text = "Columna Giratoria";
                content.text = "La columna giratoria alberga los motores de los ejes 1 y 2. El movimiento de rotación del eje 1 lo realiza la columna giratoria";
                break;
            case 16:
                Clear();
                tooltips[15].SetActive(true);
                title.text = "Brazo de Enlace";
                content.text = "El brazo de enlace es el conjunto ubicado entre el brazo y la columna giratoria. Aloja el motor y el reductor del eje 2. Las líneas de alimentación del sistema de suministro de energía y el juego de cables para los ejes 2 a 6 pasan por el brazo articulado.";
                break;
            case 17:
                Clear();
                tooltips[16].SetActive(true);
                title.text = "Brazo";
                content.text = "El brazo es el vínculo entre la muñeca en línea y el brazo de enlace. El brazo es accionado por el motor del eje 3.";
                break;
            case 18:
                Clear();
                tooltips[17].SetActive(true);
                title.text = "Muñeca";
                content.text = "El robot está equipado con una muñeca en línea de 3 ejes. La muñeca en línea consta de los ejes 4, 5 y 6.";
                break;



        }
    }
    public void Clear()
    {
        tooltips[0].SetActive(false);
        tooltips[1].SetActive(false);
        tooltips[2].SetActive(false);
        tooltips[3].SetActive(false);
        tooltips[4].SetActive(false);
        tooltips[5].SetActive(false);
        tooltips[6].SetActive(false);
        tooltips[7].SetActive(false);
        tooltips[8].SetActive(false);
        tooltips[9].SetActive(false);
        tooltips[10].SetActive(false);
        tooltips[11].SetActive(false);
    }
    public void FullClear()
    {
      
        HandMenuScript.instance.i = 0;
        for (int i = 0; i < tooltips.Length; i++)
        { 
                tooltips[i].SetActive(false);
        }
    }

}

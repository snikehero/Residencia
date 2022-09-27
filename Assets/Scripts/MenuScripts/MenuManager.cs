using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static MenuManager instance;
    [Header("Menu Entrenamiento")]
    public GameObject menuEntrenamiento;
    [Header("Menu Simulacion")]
    public GameObject menuSimulacion;
    [Header("boton operacion")]
    public GameObject buttonOperation;
    [Header("Boton posicion inicial")]
    public GameObject buttonInitialPos;
    [Header("Boton seguridad")]
    public GameObject buttonSecurity;

    public GameObject trainingButton;
    public GameObject simulationButton;

    public GameObject nextButton;
    public GameObject lastButton;




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
    public void ButtonTrainingEnabled()
    {
        menuEntrenamiento.SetActive(true);
        menuSimulacion.SetActive(false);
        simulationButton.SetActive(false);
        trainingButton.SetActive(false);
        InitialInstructions.instance.title.text = "Menu de Entrenamiento";
        InitialInstructions.instance.content.text = "Bienvenido al Menu de Entrenamiento";
    }
    public void SecurityAreaEnabled()
    {
        AreaManager.instance.updateSecurity();
        InitialInstructions.instance.title.text = "Area de Seguridad";
        InitialInstructions.instance.content.text = "Aqui se Muestra el Area de Seguridad";
    }
    public void OperationEnabled()
    {
        nextButton.SetActive(true);
        lastButton.SetActive(true);
        InitialInstructions.instance.title.text = "Encendido/Apagado";
        InitialInstructions.instance.content.text = "Bienvenido a Encendido/Apagado del robot Kuka, mediante las flechas de avance y retroceso conoceras el proceso de encedido y apagado del robot";
        InitialInstructions.instance.FullClear();
    }
    public void InitialPosEnabled()
    {
        nextButton.SetActive(false);
        lastButton.SetActive(false);
        InitialInstructions.instance.FullClear();
        InitialInstructions.instance.title.text = "Posicion inicial";
        InitialInstructions.instance.content.text = "Esta es la posicion inicial";
    }
    public void ButtonSimulationEnabled()
    {
        menuEntrenamiento.SetActive(false);
        menuSimulacion.SetActive(true);
        simulationButton.SetActive(false);
        trainingButton.SetActive(false);
        InitialInstructions.instance.title.text = "Menu de Simulacion";
        InitialInstructions.instance.content.text = "Este es el Menu de Simulacion";
    }
    public void ReturnToMenu()
    {
        menuEntrenamiento.SetActive(false);
        menuSimulacion.SetActive(false);
        simulationButton.SetActive(true);
        trainingButton.SetActive(true);
        InitialInstructions.instance.title.text = "Simulacion de robot KUKA";
        InitialInstructions.instance.content.text = "Bienvenido al sistema de simulacion del robot KUKA";
        InitialInstructions.instance.FullClear();
        AreaManager.instance.TurnOff();
    }
    


}

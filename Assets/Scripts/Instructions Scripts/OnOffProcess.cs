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
                
                break;


        }
          
    }
}

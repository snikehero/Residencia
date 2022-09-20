using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cubo;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
      if(other.tag.Equals("player"))
        {
            cubo.SetActive(true);   
            Debug.Log("Has collided");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.tag.Equals("player"))
        {
            cubo.SetActive(false);
        }
    }


}

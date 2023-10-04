using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveQizeObj : MonoBehaviour
{
    public GameObject qize_compo;  
    public GameObject welcom; 
    
    public GameObject Lose; 
    public float delayInSeconds = 3f;

    void Start()
    {
       
        qize_compo.SetActive(false);
        welcom.SetActive(true);
       
        Lose.SetActive(false);
    }
    void Update()
    {
        Invoke("ActivateObjects", delayInSeconds);
        
        
    }
    void ActivateObjects()
    {
        qize_compo.SetActive(true);
        welcom.SetActive(false);
    }

    
}

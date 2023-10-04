using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;
using UnityEngine.Windows.WebCam;

public class pont : MonoBehaviour
{
    public GameObject qize_compo;
    public GameObject cong;

    private int valueToIncrement = 0;
    private int moon = 0;
    private int earth = 0;
    public int total = 0;

    void Start()
    {
        qize_compo.SetActive(true);
        cong.SetActive(false);
    }



    void Update()
    {
        total = moon + valueToIncrement + earth;
       
        if (total == 3)
        {
          
          Invoke("CongObjects",1);
        }
    }
    public void Sunbutton()
    {
       if (Input.GetMouseButtonUp(0))
       {
            valueToIncrement = 1;

       }
    } 
    public void Moonbutton()
    {
       if (Input.GetMouseButtonUp(0))
       {
            moon = 1;
       }
    }
    public void Earthbutton()
    {
       if (Input.GetMouseButtonUp(0))
       {
            earth = 1;

       }
    }
    void CongObjects()
    {
        qize_compo.SetActive(false);
        cong.SetActive(true);
    }
}

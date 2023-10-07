using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buttonManager : MonoBehaviour
{
    public GameObject LavelMenu;
    public GameObject Lavel1;
    public GameObject FB_G;
    public GameObject catagory;
    public GameObject catagory2;
    public GameObject catagory3;
    public GameObject YearList;
    public GameObject Interct_E_B;
    public GameObject Map;
    public GameObject Start_G;
    public GameObject PazzleVdo;
    public GameObject slkY;
    public GameObject e20211; 
    public GameObject e2021M;
    public GameObject Sylect; 
    public GameObject ExitB;

    private void Start()
    {
        YearList.SetActive(false);
        // Ensure the initial state is set correctly.
        LavelMenu.SetActive(false);
        PazzleVdo.SetActive(false);
        catagory.SetActive(false);
        Interct_E_B.SetActive(true);
        Map.SetActive(true);
        Start_G.SetActive(true);
        catagory2.SetActive(false);
        slkY.SetActive(false);
        Lavel1.SetActive(false);
        FB_G.SetActive(false);
        e20211.SetActive(false);
       // e2021M.SetActive(false);
        catagory3.SetActive(false);
        Sylect.SetActive(false);
        ExitB.SetActive(true);
    }

    public void OnStart_GClick()
    {
        LavelMenu.SetActive(false);
        catagory.SetActive(true);

        Interct_E_B.SetActive(false);
        Map.SetActive(false);
        Start_G.SetActive(false);
        ExitB.SetActive(false);
    }

    public void OnInterct_E_BClick()
    {
        SceneManager.LoadScene(1);
    }
    public void OnMapClick()
    {
        SceneManager.LoadScene(2);
    } 
    public void OnVRClick()
    {
        SceneManager.LoadScene(3);
    }
    public void OnVideoClick()
    {
        SceneManager.LoadScene(4);

    }public void OnPazzleClick()
    {
        SceneManager.LoadScene(5);
    }
    public void OnBackClick()
    {
        LavelMenu.SetActive(false);

        Interct_E_B.SetActive(true);
        Map.SetActive(true);
        Start_G.SetActive(true);
        Lavel1.SetActive(true);
    }
    public void OnBackL1Click()
    {
        LavelMenu.SetActive(true);

        Interct_E_B.SetActive(false);
        Map.SetActive(false);
        Start_G.SetActive(false);
        PazzleVdo.SetActive(false);
        Lavel1.SetActive(true);
    }
    public void OnLavel1Click()
    {
        LavelMenu.SetActive(false);
        PazzleVdo.SetActive(true);
        Interct_E_B.SetActive(false);
        Map.SetActive(false);
        Start_G.SetActive(false);
        Lavel1.SetActive(false);
        catagory2.SetActive(false);
        YearList.SetActive(false);
        slkY.SetActive(false);
        catagory3.SetActive(false);
        e20211.SetActive(false);
        Sylect.SetActive(false);

    } 
    public void OncatagorySolerClick()
    {
        catagory.SetActive(false);
        LavelMenu.SetActive(false);
        PazzleVdo.SetActive(false);
        Interct_E_B.SetActive(false);
        Map.SetActive(false);
        Start_G.SetActive(false);
        slkY.SetActive(true);
        
    } 
    public void OncatagorySoler22Click()
    {
        catagory.SetActive(false);
        LavelMenu.SetActive(false);
        PazzleVdo.SetActive(false);
        Interct_E_B.SetActive(false);
        Map.SetActive(false);
        Start_G.SetActive(false);
        Sylect.SetActive(true);
        e20211.SetActive(false);
        e2021M.SetActive(true);

    }
    public void OncatagorySolerClick2()
    {
        catagory.SetActive(false);
        LavelMenu.SetActive(true);
        PazzleVdo.SetActive(false);
        Interct_E_B.SetActive(false);
        Map.SetActive(false);
        Start_G.SetActive(false);
        slkY.SetActive(false);
        Lavel1.SetActive(true);
        YearList.SetActive(true);
        catagory2.SetActive(false);
        YearList.SetActive(false);
        e20211.SetActive(true);
        e2021M.SetActive(false);
    }
    public void SelectYear()
    {
        YearList.SetActive(true);
        e20211.SetActive(true);
    }
    public void SelectYear2()
    {
        YearList.SetActive(true);
        e20211.SetActive(false);
        e2021M.SetActive(true);
    }
    public void Year21()
    {
        catagory2.SetActive(true);
        catagory.SetActive(false);
      
    }
    public void Year211()
    {
        catagory3.SetActive(true);
        catagory2.SetActive(false);
    }
    public void Poke()
    {
        FB_G.SetActive(true);
    }
}


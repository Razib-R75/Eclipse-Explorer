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
    public GameObject YearList;
    public GameObject Interct_E_B;
    public GameObject Map;
    public GameObject Start_G;
    public GameObject PazzleVdo;
    public GameObject slkY;

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
    }

    public void OnStart_GClick()
    {
        LavelMenu.SetActive(false);
        catagory.SetActive(true);

        Interct_E_B.SetActive(false);
        Map.SetActive(false);
        Start_G.SetActive(false);
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
    }
    public void SelectYear()
    {
        YearList.SetActive(true);
    }
    public void Year21()
    {
        catagory2.SetActive(true);
    }
    public void Poke()
    {
        FB_G.SetActive(true);
    }
}


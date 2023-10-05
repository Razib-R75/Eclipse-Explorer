using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buttonManager : MonoBehaviour
{
    public GameObject LavelMenu;

    public GameObject catagory;
    
    public GameObject Interct_E_B;
    public GameObject Map;
    public GameObject Start_G;
    public GameObject PazzleVdo;

    private void Start()
    {
        // Ensure the initial state is set correctly.
        LavelMenu.SetActive(false);
        PazzleVdo.SetActive(false);
        catagory.SetActive(false);
        Interct_E_B.SetActive(true);
        Map.SetActive(true);
        Start_G.SetActive(true);
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
    }
    public void OnLavel1Click()
    {
        LavelMenu.SetActive(false);
        PazzleVdo.SetActive(true);
        Interct_E_B.SetActive(false);
        Map.SetActive(false);
        Start_G.SetActive(false);
    } 
    public void OncatagorySolerClick()
    {
        catagory.SetActive(false);
        LavelMenu.SetActive(true);
        PazzleVdo.SetActive(false);
        Interct_E_B.SetActive(false);
        Map.SetActive(false);
        Start_G.SetActive(false);
    }
}


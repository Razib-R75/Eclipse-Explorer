using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Backclike : MonoBehaviour
{
    public GameObject Image;


     void Start()
     {
       Image.SetActive(false);
     }
    public void OnBackClick()
    {
        SceneManager.LoadScene(0);
    }
    public void ImageA()
    {
        Image.SetActive(true);
    }
}

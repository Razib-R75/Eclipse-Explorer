using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Backclike : MonoBehaviour
{
    public void OnBackClick()
    {
        SceneManager.LoadScene(0);
    }
}

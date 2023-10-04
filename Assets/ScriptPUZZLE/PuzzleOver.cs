using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.WebCam;
using TMPro;
public class PuzzleOver : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI displayBalance;
    public int valueToIncrement = 6;
    public GameObject qize_compo;
    public GameObject welcom;
    public GameObject cong;
    public GameObject Lose;

    void Update()
    {
        
        displayBalance.text = "Move: " + valueToIncrement;
        if (Input.GetMouseButtonUp(0))
        {
            valueToIncrement--;
            
        }
        if (valueToIncrement == 0)
        {
            Invoke("LossObjects", 1);
        }
    }
    void LossObjects()
    {
        qize_compo.SetActive(false);
        welcom.SetActive(false);
        cong.SetActive(false);
        Lose.SetActive(true);
    }
    
}

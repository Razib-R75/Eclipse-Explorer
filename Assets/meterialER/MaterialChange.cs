using UnityEngine;
using UnityEngine.UI;

public class MaterialChange : MonoBehaviour
{
    public GameObject objectToChange; 
    public GameObject year; 
    public GameObject objectToChange2;
    public GameObject earth1;
    public GameObject earth2;// Reference to the GameObject with the material you want to change.
    public Material[] materials; // Array of materials to use for each button.

    private Renderer objectRenderer; 
    private Renderer objectRenderer1;

    private void Start()
    {
        year.SetActive(false);
        earth1.SetActive(false);
        earth2.SetActive(false);
        objectRenderer = objectToChange.GetComponent<Renderer>();
        objectRenderer1 = objectToChange2.GetComponent<Renderer>();
    }

    public void ChangeMaterial6()
    {
        
        
            objectRenderer.material = materials[0]; 
            objectRenderer1.material = materials[5];
            earth1.SetActive(true);
            earth2.SetActive(true);

    }
    public void ChangeMaterial10()
    {

            earth1.SetActive(true);
            earth2.SetActive(true);
        objectRenderer.material = materials[1];
        objectRenderer1.material = materials[6];

    }
    public void ChangeMaterial17()
    {

        earth1.SetActive(true);
        earth2.SetActive(true);
        objectRenderer.material = materials[2];
        objectRenderer1.material = materials[7];

    }
    public void ChangeMaterial19()
    {

        earth1.SetActive(true);
        earth2.SetActive(true);
        objectRenderer.material = materials[3];
        objectRenderer1.material = materials[8];

    }
    public void ChangeMaterial20()
    {

        earth1.SetActive(true);
        earth2.SetActive(true);
        objectRenderer.material = materials[4];
        objectRenderer1.material = materials[9];



    }
    public void SelectYear()
    {

        year.SetActive(true);
        
        



    }
}

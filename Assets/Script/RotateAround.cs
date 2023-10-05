using UnityEngine;
using System.Collections;

public class RotateAround : MonoBehaviour
{
    public Transform target; // the object to rotate around
    [SerializeField] float speed; // the speed of rotation

    void Start()
    {
        if (target == null)
        {
            target = this.gameObject.transform;
            Debug.Log("RotateAround target not specified. Defaulting to parent GameObject");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // RotateAround takes three arguments, first is the Vector to rotate around
        transform.RotateAround(target.transform.position, target.transform.up, speed * Time.deltaTime);
    }

}

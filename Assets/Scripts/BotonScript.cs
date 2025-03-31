using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonScript : MonoBehaviour
{

    public GameObject botonGO;

    void OnMouseDown()
    {
        botonGO.SetActive(false);
    }
    void OnMouseUp()
    {
        botonGO.SetActive(true); 
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

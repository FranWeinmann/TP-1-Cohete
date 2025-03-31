using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonScript : MonoBehaviour
{

    public GameObject botonGO;
    public CoheteScript coheteScript;

    void OnMouseDown()
    {
        botonGO.SetActive(false);
        coheteScript.Despegue();
    }
    void OnMouseUp()
    {
        botonGO.SetActive(true); 
    }
}

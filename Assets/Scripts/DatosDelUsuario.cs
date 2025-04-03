using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatosDelUsuario : MonoBehaviour
{
    public string NombreUsuario;
    public int EdadUsuario;
    public float AlturaUsuario;
    public bool EsDonante;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Mi nombre es " + NombreUsuario + " tengo " + EdadUsuario + ", mido " + AlturaUsuario + " metros y es " + EsDonante + " que soy donante de órganos.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeclaracionDeVariables : MonoBehaviour
{
    int CantAlumnos;
    float KilosVebdidos;
    string NombreAlumno;
    bool EsEtbul;
    // Start is called before the first frame update
    void Start()
    {
        CantAlumnos = 33;
        KilosVebdidos = 22.5f;
        NombreAlumno = "Máximo";
        EsEtbul = false;
        Debug.Log(CantAlumnos);
        Debug.Log(KilosVebdidos);
        Debug.Log(NombreAlumno);
        Debug.Log(EsEtbul);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

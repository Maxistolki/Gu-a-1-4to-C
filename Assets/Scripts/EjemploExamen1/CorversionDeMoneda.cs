using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorversionDeMoneda : MonoBehaviour
{
    public float monto;
    public string codigoMoneda;
    float montoConvertido;
    float cotizacionMonedaElegida;
    float montoMinimo = 1000;
    float cotizacionDolar = 1134.5f;
    float cotizacionEuro = 1397.16f;
    float cotizacionReal = 220;
    // Start is called before the first frame update
    void Start()
    {
        if (monto < montoMinimo)
        {
            Debug.Log("El monto mínimo es $1000");
            return;
        }
        if (codigoMoneda == "D")
        {
            cotizacionMonedaElegida = cotizacionDolar;
        }
        else if (codigoMoneda == "E")
        {
            cotizacionMonedaElegida = cotizacionEuro;
        }
        else if (codigoMoneda == "R")
        {
            cotizacionMonedaElegida = cotizacionReal;
        }
        else
        {
            Debug.Log("Opción de moneda extranjera no válida");
            return;
        }
        montoConvertido = monto / cotizacionMonedaElegida;
        Debug.Log("Monto convertido: " + montoConvertido);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

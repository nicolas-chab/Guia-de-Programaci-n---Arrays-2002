using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej2 : MonoBehaviour
{
    [SerializeField] string[] nombresMeses = new string[12];
    [SerializeField] int[] DiasPorCadaMes = new int[12];
    public string FechaIngresada;
    // Start is called before the first frame update
    void Start()
    {
        ValidarFormatoFecha(FechaIngresada);
        
    }

    
    bool ValidarFormatoFecha(string fecha)
    {
        bool fechaValida = false;
        if (fecha.Length == 4)
        {
            string dia = "";
            string Mes = "";
            dia += fecha[0];
            dia += fecha[1];
           int dianumber = int.Parse(dia);
            Mes += fecha[2];
            Mes += fecha[3];
            Debug.Log("Es el dia numero"+dia);
            Debug.Log("Es el mes numero"+Mes);
           int mesnumber = int.Parse(Mes);

            if (dianumber>0 && dianumber<= 31 && mesnumber > 0 && mesnumber <= 11)
            {
                fechaValida = true;
            }
        }
        else
        {
            Debug.Log("el largo de la fecha es incorrecto");
        }
        return fechaValida;
    }
}

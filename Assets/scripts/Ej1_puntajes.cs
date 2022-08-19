using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej1_puntajes : MonoBehaviour
{
    [SerializeField] int[] puntajes = new int[10];

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("El mayor puntaje es" +ObtenerMayorPuntaje());
        Debug.Log("el nivel con menor puntaje es" +ObtenerNivelDeMenorPuntaje());
        Debug.Log("el promedio es" + ObtenerPuntajePromedio());
    }

    // Update is called once per frame
    void Update()
    {

    }
    int ObtenerMayorPuntaje()
    {
    int MayorPuntaje = 0;
        foreach(int puntaje in puntajes)
        {
           if(puntaje > MayorPuntaje)
            {
                MayorPuntaje = puntaje;
            }
        }
        return MayorPuntaje;
    }
    int ObtenerNivelDeMenorPuntaje()
    {
        int indiceNivelMenorPuntaje = 0;
        int Menorpuntaje = 0;
        for (int i=0; i<puntajes.Length;i++)
        {
            if (puntajes[i] < Menorpuntaje)
            {
                Menorpuntaje = puntajes[i];
                indiceNivelMenorPuntaje = i;
            }
        }
            return indiceNivelMenorPuntaje;
    }
    float ObtenerPuntajePromedio()
    {
        float PuntajePromedio = 0;
        float Suma=0;
        foreach(int num in puntajes)
        {
            Suma += num;
        }
       PuntajePromedio  = Suma / puntajes.Length;

        return PuntajePromedio;
    }
     
  

}

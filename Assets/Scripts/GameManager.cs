using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instancia;
    [SerializeField] public int puntuacionActual, puntuacionMaxima;
    [SerializeField] float tiempo;
    // Start is called before the first frame update
    void Start()
    {
        puntuacionMaxima = PlayerPrefs.GetInt("puntuacionMaxima");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Perder()
    {

    }

    void ReiniciarJuego()
    {
        
    }

    void ActualizarPuntuacion()
    {
        puntuacionActual += 1;
        if (puntuacionActual >= puntuacionMaxima)
        {
            puntuacionMaxima = puntuacionActual;
            PlayerPrefs.SetInt("mejorPuntuacion", puntuacionMaxima);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instancia;
    [SerializeField] TMP_Text texto;
    [SerializeField] public int puntuacionActual, puntuacionMaxima;
    [SerializeField] public float tiempo;
    // Start is called before the first frame update
    void Start()
    {
        puntuacionMaxima = PlayerPrefs.GetInt("puntuacionMaxima");
    }

    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;
        int minutos = (int)tiempo / 60;
        int segundos = (int)tiempo % 60;
        Debug.Log(minutos + ":" + segundos);
        string textoTiempo = $"{minutos:D2}:{segundos:D2}";
        texto.text = textoTiempo;
    }

    void Perder()
    {
        SceneManager.LoadScene(1);
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

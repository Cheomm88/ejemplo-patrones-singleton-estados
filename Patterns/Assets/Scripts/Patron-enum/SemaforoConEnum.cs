using System.Threading;
using UnityEngine;

public class SemaforoConEnum : MonoBehaviour
{
    public enum EstadoEnumSemaforo
    {
        enRojo,
        enVerde,
        enAmarillo
    }

    public EstadoEnumSemaforo estadoInicial;
    private EstadoEnumSemaforo estadoActualSemaforo;

    public float timer = 0.0f;

    public GameObject luzRoja, luzVerde, luzAmarilla;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        estadoActualSemaforo = estadoInicial;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        switch (estadoActualSemaforo)
        {
            case EstadoEnumSemaforo.enRojo:
                SemaforoEnRojo();
                break;

            case EstadoEnumSemaforo.enVerde:
                Debug.Log("En verde");
                break;

        }

    }

    void SemaforoEnRojo()
    {
        if (timer < 10f)
        {
            luzRoja.SetActive(true);
            luzVerde.SetActive(false);
            luzAmarilla.SetActive(false);
        }
        else 
        {
            estadoActualSemaforo = EstadoEnumSemaforo.enVerde;
            timer = 0.0f;
        }
    }
    
}


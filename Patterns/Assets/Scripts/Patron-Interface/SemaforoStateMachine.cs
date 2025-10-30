using UnityEngine;

public class SemaforoStateMachine : MonoBehaviour
{
    
    public GameObject luzRoja, luzAmarilla, luzVerde;

    private IEstado estadoActualSemaforo;
    
    void Start()
    {
        luzRoja.SetActive(false);
        luzAmarilla.SetActive(false);
        luzVerde.SetActive(false);

        CambiarEstado(new EstadoRojo());
    }

    // Update is called once per frame
    void Update()
    {
        if (estadoActualSemaforo != null)
        {
            estadoActualSemaforo.Ejecutar(this);
        }
    }

    public void CambiarEstado(IEstado nuevoEstado)
    {
        if (estadoActualSemaforo != null) {
            estadoActualSemaforo.Salir(this);
        }

        estadoActualSemaforo = nuevoEstado;
        estadoActualSemaforo.Entrar(this);
    
    }
}

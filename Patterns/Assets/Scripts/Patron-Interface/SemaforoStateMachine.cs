using UnityEngine;

//Este es el cerebro de la m�uina de estados/sem�foro.
public class SemaforoStateMachine : MonoBehaviour
{
    //Luces que tiene el semaforo.
    public GameObject luzRoja, luzAmarilla, luzVerde;

    //Estado actual.
    private IEstado estadoActualSemaforo;
    
    void Start()
    {
        //Prepara sem�foro con todo apagado
        luzRoja.SetActive(false);
        luzAmarilla.SetActive(false);
        luzVerde.SetActive(false);

        //Enciende sem�foro en ROJO
        CambiarEstado(new EstadoRojo());
    }

    // Update is called once per frame
    void Update()
    {
        //Si tenemos un estado lo ejecutamos
        if (estadoActualSemaforo != null)
        {
            estadoActualSemaforo.Ejecutar(this);
        }
    }

    public void CambiarEstado(IEstado nuevoEstado)
    {
        //Si tenemos un estado salimos del mismo
        if (estadoActualSemaforo != null) {
            estadoActualSemaforo.Salir(this);
        }

        //Pasamos al nuevo estado (esto sirve para tener memoria de d�nde estamos)
        estadoActualSemaforo = nuevoEstado;
        //Entramos al nuevo estado.
        estadoActualSemaforo.Entrar(this);
    
    }
}

using UnityEngine;

public class EstadoRojo : IEstado
{
    private float timer;
    public void Ejecutar(SemaforoStateMachine semaforo)
    {
        timer += Time.deltaTime;
        if (timer > 10)
        {
            semaforo.CambiarEstado(new EstadoVerde());
        }
    }

    public void Entrar(SemaforoStateMachine semaforo)
    {
        Debug.Log("Enciende luz roja");
        semaforo.luzRoja.SetActive(true);
        timer = 0.0f;
    }

    public void Salir(SemaforoStateMachine semaforo)
    {
        Debug.Log("Apaga luz roja");
        semaforo.luzRoja.SetActive(false);
    }
}

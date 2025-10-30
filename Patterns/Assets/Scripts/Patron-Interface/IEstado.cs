//La clase base de los estados
//Todos los estados tendr�n lo que dice aqui
public interface IEstado
{
    void Entrar(SemaforoStateMachine semaforo);
    void Ejecutar(SemaforoStateMachine semaforo);
    void Salir(SemaforoStateMachine semaforo);
}

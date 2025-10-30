using UnityEngine;

public class SemaforoSimple : MonoBehaviour
{
    public GameObject luzRoja, luzAmarilla, luzVerde;

    void Start()
    {
        PonerEnRojo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PonerEnRojo()
    {
        //Estado inicial en rojo
        luzRoja.SetActive(true);
        luzAmarilla.SetActive(false);
        luzVerde.SetActive(false);

    }
}

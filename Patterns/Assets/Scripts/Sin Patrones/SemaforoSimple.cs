using UnityEngine;

public class SemaforoSimple : MonoBehaviour
{
    public GameObject luzRoja, luzAmarilla, luzVerde;
    public float timer = 0f;
    void Start()
    {
        PonerEnRojo();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 10f && luzRoja.activeSelf == true)
        {
            PonerEnVerde();
        }
        else if (timer >= 15f && luzVerde.activeSelf == true)
        {
            PonerEnAmbar();
        }
    }

    void PonerEnRojo()
    {
        //Estado inicial en rojo
        luzRoja.SetActive(true);
        luzAmarilla.SetActive(false);
        luzVerde.SetActive(false);
        timer = 0f;

    }

    void PonerEnVerde()
    {
        //Estado inicial en rojo
        luzRoja.SetActive(false);
        luzAmarilla.SetActive(false);
        luzVerde.SetActive(true);
        timer = 0f;

    }

    void PonerEnAmbar()
    {
        //Estado inicial en rojo
        luzRoja.SetActive(false);
        luzAmarilla.SetActive(true);
        luzVerde.SetActive(false);
        timer = 0f;

    }
}

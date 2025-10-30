using UnityEngine;

public class PickLife : MonoBehaviour, IPickeableObject
{
    public void RecogerObjeto()
    {
        Debug.Log("recoger vida");
    }
}

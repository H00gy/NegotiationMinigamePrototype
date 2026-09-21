using UnityEngine;
using UnityEngine.UI;

public class ZoneValueTxT : MonoBehaviour
{
    public GreenZone gz; 
    TMPro.TextMeshPro TextMeshPro;
    void Start()
    {
        
        TextMeshPro.text = gz.zoneValue.ToString();
    }

    
}

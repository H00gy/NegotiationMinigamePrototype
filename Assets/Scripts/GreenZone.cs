using UnityEngine;
using UnityEngine.UI; 

public class GreenZone : MonoBehaviour
{
    Image greenArea;
    float newX;
    public int zoneValue;

    private void Start()
    {
        greenArea = GetComponent<Image>();
        SetZoneValue();
    }
    public void SetZoneValue()
    {
        zoneValue = Random.Range(1, 100); // temp for prototype
    }
    public void SetZoneSize(float askingPrice) // need to instantiate or smt to loop 
    {
        
        
        if (askingPrice < zoneValue)
        {
            float temp = askingPrice / zoneValue;
            newX = temp * temp;
            greenArea.transform.localScale = new Vector3(newX, 1, 1); // at the moment having an exponential percentage feels balanced
        }
        else if (askingPrice >= zoneValue)
        {
            greenArea.transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            Debug.Log("bug");
        }

    }
}

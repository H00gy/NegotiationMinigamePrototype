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
        zoneValue = Random.Range(1, 100); // temp for prototype
    }
    public void SetZoneSize(float askingPrice) // need to instantiate or smt to loop 
    {
        
        
        if (askingPrice <= zoneValue)
        {
            newX = askingPrice / zoneValue;
            greenArea.transform.localScale = new Vector3(newX, 1, 1);
        }
        else if (askingPrice > zoneValue)
        {
            greenArea.transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            Debug.Log("bug");
        }

    }
}

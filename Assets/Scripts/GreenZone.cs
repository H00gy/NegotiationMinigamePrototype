using UnityEngine;
using UnityEngine.UI; 

public class GreenZone : MonoBehaviour
{
    Image greenArea;
    float newX;

    private void Start()
    {
        greenArea = GetComponent<Image>();
    }
    public void SetZoneSize(float askingPrice)
    {
        
        int zoneValue = Random.Range(1, 100); // temp for prototype
        if (askingPrice <= zoneValue)
        {
            newX = askingPrice / zoneValue;
            greenArea.transform.localScale = new Vector3(newX, 1, 1);
        }
        else if (askingPrice > zoneValue)
        {
            float tmpNegNum = zoneValue - askingPrice;
            newX = (tmpNegNum * -1) / zoneValue;
            greenArea.transform.localScale = new Vector3(newX, 1, 1);
        }
        else
        {
            Debug.Log("bug");
        }

    }
}

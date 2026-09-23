using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MoneyInput : MonoBehaviour
{
    public TMP_InputField MoneyInputField;
    public GameObject TimingUI;
    public GreenZone greenZone; 
   
    public float InputAmount;


    private void Start()
    {
        TimingUI.SetActive(false);
    }
    public void ConfirmInput()
    {
        
        string Input = MoneyInputField.text;
        TimingUI.SetActive(true);
        // Safely attempt to convert the string to a float
        if (float.TryParse(Input, out float result))
        {
            InputAmount = result;
            
        }
        else // this is temp, will have it so user must retype
        {
            // Triggers if the field is completely empty
            InputAmount = 0f;
            Debug.Log("Input was empty or invalid. Resetting float to 0.");
        }
        greenZone.SetZoneSize(InputAmount);

    }

    
}

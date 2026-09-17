using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MoneyInput : MonoBehaviour
{
    public TMP_InputField MoneyInputField;
    public GameObject TimingUI;
    public string InputAmount;

    private void Start()
    {
        TimingUI.SetActive(false);
    }
    public void ConfirmInput()
    {
        MoneyInputField.text = InputAmount;
        TimingUI.SetActive(true);

    }

    
}

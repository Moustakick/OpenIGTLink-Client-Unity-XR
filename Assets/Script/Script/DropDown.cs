using TMPro;
using UnityEngine;

public class DropDown : MonoBehaviour
{
    public TextMeshProUGUI dropDownValue; 
    public GameObject igtDialog;

    public void OnValueChange() {
        Debug.Log(dropDownValue.text);

        switch (dropDownValue.text) {
            case "OpenIGTLink":
                igtDialog.SetActive(true);
                break;
            default:
                igtDialog.SetActive(false);
                break;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NickController : MonoBehaviour
{
    public GameObject PanelNick;
    public InputField InputTxt;

    private void Start()
    {
        if (PlayerPrefs.HasKey("PlayerNick"))
        {
            PanelNick.SetActive(false);
        }
        else
        {
            PanelNick.SetActive(true);
        }
    }
    public void SetName()
    {
        if(InputTxt.text == "")
        {
            Debug.Log("Error");
        }
        else
        {
            PanelNick.SetActive(false);
            PlayerPrefs.SetString("PlayerNick", InputTxt.text);
            Debug.Log("Success");
        }
    }
}

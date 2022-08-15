using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BUttonsToTalk : MonoBehaviour
{
    public GameObject Dialog;
    public void OpenDialog()
    {
        Dialog.SetActive(true);
    }

    public void CloseDialog1()
    {
        PlayerPrefs.SetInt("Kvest0", 1);
        PlayerPrefs.SetInt("Kvest1", 1);
        PlayerPrefs.SetInt("Kvest5", 1);
        Dialog.SetActive(false);
    }
    public void CloseDialog2()
    {
        PlayerPrefs.SetInt("Kvest1", 2);
        PlayerPrefs.SetInt("Kvest2", 1);
        Dialog.SetActive(false);
    }
    public void CloseDialog3()
    {
        PlayerPrefs.SetInt("Kvest2", 3);
        PlayerPrefs.SetInt("Kvest3", 1);
        Dialog.SetActive(false);
    }
    public void CloseDialog4()
    {
        PlayerPrefs.SetInt("Kvest3", 2);
        PlayerPrefs.SetInt("Kvest4", 1);
        Dialog.SetActive(false);
    }
    public void CloseDialog5()
    {
        PlayerPrefs.SetInt("Kvest4", 3);
        Dialog.SetActive(false);
    }
}

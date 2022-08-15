using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsSimpleScene : MonoBehaviour
{
    public GameObject PanelYouDied;

    public void VremennoOk()
    {
        PanelYouDied.SetActive(false);
        Time.timeScale = 1;

    }
    public void StartTheGame()
    {
        SceneManager.LoadScene(1);
    }
    public void CloseMap()
    {
        PanelYouDied.SetActive(false);
    }
    public void OpenMap()
    {
        PanelYouDied.SetActive(true);
    }
}

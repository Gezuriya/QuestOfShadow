using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KVESTcontroller : MonoBehaviour
{
    public GameObject[] ButtonsToTalk;
    public GameObject TalkToElder, BULL, RABBIT, POYASVELIKANARVAN;
    int Kvest0, Kvest1, Kvest2, Kvest3, Kvest4, Kvest5, Kvest6, Kvest7, Kvest8, Kvest9, Kvest10, Kvest11, Kvest12, Kvest13, Kvest14, Kvest15, Kvest16, Kvest17, Kvest18;

    private void FixedUpdate()
    {
        if (PlayerPrefs.HasKey("Kvest0"))
        {
            Kvest0 = PlayerPrefs.GetInt("Kvest0");
        }
        else
            Kvest0 = 0;
        /*if(Kvest0 == 0)
        {
            TalkToElder.SetActive(true);
        }
        else
            TalkToElder.SetActive(false);*/

        if (PlayerPrefs.HasKey("Kvest1"))
        {
            Kvest1 = PlayerPrefs.GetInt("Kvest1");
        }
        else
            Kvest1 = 0;

       if (PlayerPrefs.HasKey("Kvest2"))
        {
            Kvest2 = PlayerPrefs.GetInt("Kvest2");
        }
        else
            Kvest2 = 0;

        if (PlayerPrefs.HasKey("Kvest3"))
        {
            Kvest3 = PlayerPrefs.GetInt("Kvest3");
        }
        else
            Kvest3 = 0;

        if (PlayerPrefs.HasKey("Kvest4"))
        {
            Kvest4 = PlayerPrefs.GetInt("Kvest4");
        }
        else
            Kvest4 = 0;

        if (PlayerPrefs.HasKey("Kvest5"))
        {
            Kvest5 = PlayerPrefs.GetInt("Kvest5");
        }
        else
            Kvest5 = 0;

        /*if (PlayerPrefs.HasKey("Kvest6"))
        {
            Kvest6 = PlayerPrefs.GetInt("Kvest6");
        }
        else
            Kvest6 = 0;

        if (PlayerPrefs.HasKey("Kvest7"))
        {
            Kvest7 = PlayerPrefs.GetInt("Kvest7");
        }
        else
            Kvest7 = 0;

        if (PlayerPrefs.HasKey("Kvest8"))
        {
            Kvest8 = PlayerPrefs.GetInt("Kvest8");
        }
        else
            Kvest8 = 0;

        if (PlayerPrefs.HasKey("Kvest9"))
        {
            Kvest9 = PlayerPrefs.GetInt("Kvest9");
        }
        else
            Kvest9 = 0;

        if (PlayerPrefs.HasKey("Kvest10"))
        {
            Kvest10 = PlayerPrefs.GetInt("Kvest10");
        }
        else
            Kvest10 = 0;

        if (PlayerPrefs.HasKey("Kvest11"))
        {
            Kvest11 = PlayerPrefs.GetInt("Kvest11");
        }
        else
            Kvest11 = 0;

        if (PlayerPrefs.HasKey("Kvest12"))
        {
            Kvest12 = PlayerPrefs.GetInt("Kvest12");
        }
        else
            Kvest12 = 0;

        if (PlayerPrefs.HasKey("Kvest13"))
        {
            Kvest13 = PlayerPrefs.GetInt("Kvest13");
        }
        else
            Kvest13 = 0;

        if (PlayerPrefs.HasKey("Kvest14"))
        {
            Kvest14 = PlayerPrefs.GetInt("Kvest14");
        }
        else
            Kvest14 = 0;

        if (PlayerPrefs.HasKey("Kvest15"))
        {
            Kvest15 = PlayerPrefs.GetInt("Kvest15");
        }
        else
            Kvest15 = 0;

        if (PlayerPrefs.HasKey("Kvest16"))
        {
            Kvest16 = PlayerPrefs.GetInt("Kvest16");
        }
        else
            Kvest16 = 0;

        if (PlayerPrefs.HasKey("Kvest17"))
        {
            Kvest17 = PlayerPrefs.GetInt("Kvest17");
        }
        else
            Kvest17 = 0;

        if (PlayerPrefs.HasKey("Kvest18"))
        {
            Kvest18 = PlayerPrefs.GetInt("Kvest18");
        }
        else
            Kvest18 = 0;*/
    }

    public void Quest1()
    {
        if(Kvest0 == 0)
        {
            if (ButtonsToTalk[0].activeInHierarchy)
            {
                ButtonsToTalk[0].SetActive(false);
            }
            else
                ButtonsToTalk[0].SetActive(true);
        }
        else
            ButtonsToTalk[0].SetActive(false);
    }
    public void Quest2()
    {
        if (Kvest1 == 1)
        {
            if (ButtonsToTalk[1].activeInHierarchy)
            {
                ButtonsToTalk[1].SetActive(false);
            }
            else
                ButtonsToTalk[1].SetActive(true);
        }
        else
            ButtonsToTalk[1].SetActive(false);
    }
    public void Quest3()
    {
        if (Kvest2 == 1)
        {
            BULL.SetActive(true);
        }
        else if (Kvest2 == 2)
        {
            if (ButtonsToTalk[2].activeInHierarchy)
            {
                ButtonsToTalk[2].SetActive(false);
            }
            else
                ButtonsToTalk[2].SetActive(true);
        }
        else
            ButtonsToTalk[2].SetActive(false);
    }
    public void Quest4()
    {
        if (Kvest3 == 1)
        {
            if (ButtonsToTalk[3].activeInHierarchy)
            {
                ButtonsToTalk[3].SetActive(false);
            }
            else
                ButtonsToTalk[3].SetActive(true);
        }
        else
            ButtonsToTalk[3].SetActive(false);
    }
    public void Quest5()
    {
        if (Kvest4 == 1)
        {
            RABBIT.SetActive(true);
        }
        else if (Kvest4 == 2)
        {
            if (ButtonsToTalk[4].activeInHierarchy)
            {
                ButtonsToTalk[4].SetActive(false);
            }
            else
                ButtonsToTalk[4].SetActive(true);
                
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            POYASVELIKANARVAN.SetActive(true);
        }
        else
            ButtonsToTalk[4].SetActive(false);

    }
    public void Quest6()
    {
        if (ButtonsToTalk[5].activeInHierarchy)
        {
            ButtonsToTalk[5].SetActive(false);
        }
        else
            ButtonsToTalk[5].SetActive(true);
    }
    public void Quest7()
    {
        if (ButtonsToTalk[6].activeInHierarchy)
        {
            ButtonsToTalk[6].SetActive(false);
        }
        else
            ButtonsToTalk[6].SetActive(true);
    }
    public void Quest8()
    {
        if (ButtonsToTalk[7].activeInHierarchy)
        {
            ButtonsToTalk[7].SetActive(false);
        }
        else
            ButtonsToTalk[7].SetActive(true);
    }
    public void Quest9()
    {
        if (ButtonsToTalk[8].activeInHierarchy)
        {
            ButtonsToTalk[8].SetActive(false);
        }
        else
            ButtonsToTalk[8].SetActive(true);
    }
    public void Quest10()
    {
        if (ButtonsToTalk[9].activeInHierarchy)
        {
            ButtonsToTalk[9].SetActive(false);
        }
        else
            ButtonsToTalk[9].SetActive(true);
    }
    public void Quest11()
    {
        if (ButtonsToTalk[10].activeInHierarchy)
        {
            ButtonsToTalk[10].SetActive(false);
        }
        else
            ButtonsToTalk[10].SetActive(true);
    }
    public void Quest12()
    {
        if (ButtonsToTalk[11].activeInHierarchy)
        {
            ButtonsToTalk[11].SetActive(false);
        }
        else
            ButtonsToTalk[11].SetActive(true);
    }
    public void Quest13()
    {
        if (ButtonsToTalk[12].activeInHierarchy)
        {
            ButtonsToTalk[12].SetActive(false);
        }
        else
            ButtonsToTalk[12].SetActive(true);
    }
    public void Quest14()
    {
        if (ButtonsToTalk[13].activeInHierarchy)
        {
            ButtonsToTalk[13].SetActive(false);
        }
        else
            ButtonsToTalk[13].SetActive(true);
    }
    public void Quest15()
    {
        if (ButtonsToTalk[14].activeInHierarchy)
        {
            ButtonsToTalk[14].SetActive(false);
        }
        else
            ButtonsToTalk[14].SetActive(true);
    }
    public void Quest16()
    {
        if (ButtonsToTalk[15].activeInHierarchy)
        {
            ButtonsToTalk[15].SetActive(false);
        }
        else
            ButtonsToTalk[15].SetActive(true);
    }
    public void Quest17()
    {
        if (ButtonsToTalk[16].activeInHierarchy)
        {
            ButtonsToTalk[16].SetActive(false);
        }
        else
            ButtonsToTalk[16].SetActive(true);
    }
    public void Quest18()
    {
        if (ButtonsToTalk[17].activeInHierarchy)
        {
            ButtonsToTalk[17].SetActive(false);
        }
        else
            ButtonsToTalk[17].SetActive(true);
    }
    public void Quest19()
    {
        if(ButtonsToTalk[18].activeInHierarchy)
        {
            ButtonsToTalk[18].SetActive(false);
        }
        else
            ButtonsToTalk[18].SetActive(true);
    }
}

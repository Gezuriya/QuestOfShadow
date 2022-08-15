using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private Rigidbody _rig;
    [SerializeField] private FixedJoystick _fixJoy;

    [SerializeField]
    private float speed;
    public bool JoyGoes;

    public TextMeshPro Nick;
    private Animator anim;
    public GameObject PanGameOverYouDied;
    public GameObject PrefKamnepad, buttonstartDialog, ButtonMapClick;
    public int PlayerHealth;
    public int Kvest0, Kvest1, Kvest2, Kvest3, Kvest4, Kvest5, Kvest6, Kvest7, Kvest8, Kvest9, Kvest10, Kvest11, Kvest12, Kvest13, Kvest14, Kvest15, Kvest16, Kvest17, Kvest18;
    public KVESTcontroller contr;

    bool damaged;
    public Image damageImage;                                                                    
    public float flashSpeed = 3f;                               
    public Color flashColour = new Color(1f, 0f, 0f, 0.15f);

    private void Start()
    {
        //PlayerPrefs.SetInt("Kvest0", 1);
       /* PlayerPrefs.DeleteKey("Kvest0"); 
        PlayerPrefs.DeleteKey("Kvest1");
        PlayerPrefs.DeleteKey("Kvest2");
        PlayerPrefs.DeleteKey("Kvest3");
        PlayerPrefs.DeleteKey("Kvest4");
        PlayerPrefs.DeleteKey("Kvest5");*/

        anim = GetComponent<Animator>();
        JoyGoes = true;
        if (PlayerPrefs.HasKey("PlayerNick"))
        {
            Nick.text = PlayerPrefs.GetString("PlayerNick");
        }
        else
        {
            Nick.text = "";
        }
        PlayerHealth = 4;
        if (PlayerPrefs.HasKey("Kvest0"))
        {
            Kvest0 = PlayerPrefs.GetInt("Kvest0");
        }
        else
            Kvest0 = 0;

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

        if (PlayerPrefs.HasKey("Kvest6"))
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
            Kvest18 = 0;
        //PlayerPrefs.DeleteKey("PlayerNick");    
    }
    void FixedUpdate()
    {
        if (PlayerHealth == 0)
        {
            Death();
        }

        if (damaged)
        {
            damageImage.color = flashColour;
        }
        else
        {
            damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
        }
        damaged = false;

        _rig.velocity = new Vector3(_fixJoy.Horizontal * speed, _rig.velocity.y, _fixJoy.Vertical * speed);

        if (_fixJoy.Horizontal != 0 || _fixJoy.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(_rig.velocity);
            anim.SetBool("IsRun", true);
            JoyGoes = false;
        }
        if (_fixJoy.Horizontal == 0 && _fixJoy.Vertical == 0)
        {
            anim.SetBool("IsRun", false);
            JoyGoes = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Fire")
        {
            StartCoroutine(DeathFromFireorRiver());
        }
        if (other.tag == "Enemy")
        {
            Death();
        }

        //Skelet
        if(other.tag == "KvestSkelet")
        {
            if (PlayerPrefs.HasKey("Kvest10"))
            {
                Kvest10 = PlayerPrefs.GetInt("Kvest10");
            }
            else
                Kvest10 = 0;
            if (PlayerPrefs.HasKey("Kvest12"))
            {
                Kvest12 = PlayerPrefs.GetInt("Kvest12");
            }
            else
                Kvest12 = 0;

            if (Kvest10 == 1)
            {
                contr.Quest11();
            }
            if (Kvest12 == 1)
            {
                contr.Quest13();
            }
        }
        if(other.tag == "KartaMap")
        {
            ButtonMapClick.SetActive(true);
        }


        // Stareishina
        if(other.tag == "STARETS")
        {
            if (PlayerPrefs.HasKey("Kvest0"))
            {
                Kvest0 = PlayerPrefs.GetInt("Kvest0");
            }
            else
                Kvest0 = 0;
            if (PlayerPrefs.HasKey("Kvest18"))
            {
                Kvest18 = PlayerPrefs.GetInt("Kvest18");
            }
            else
                Kvest18 = 0;

            if (Kvest0 == 0)
            {
                contr.Quest1();
            }
            if (Kvest18 == 1)
            {
                contr.Quest19();
            }
        }

        //Fermer
        if (other.tag == "FERMER")
        {
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

            if (Kvest1 == 1)
            {
                contr.Quest2();
            }
            if (Kvest2 == 2)
            {
                contr.Quest3();
            }
        }

        // PUGALO
        if (other.tag == "PUGALO")
        {
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

            if (Kvest3 == 1)
            {
                contr.Quest4();
            }
            if (Kvest4 == 2)
            {
                contr.Quest5();
            }
        }

        //Vedma
        if (other.tag == "VEDMA")
        {
            if (PlayerPrefs.HasKey("Kvest5"))
            {
                Kvest5 = PlayerPrefs.GetInt("Kvest5");
            }
            else
                Kvest5 = 0;

            if (Kvest5 == 1)
            {
                contr.Quest6();
            }

            if (PlayerPrefs.HasKey("Kvest6"))
            {
                Kvest6 = PlayerPrefs.GetInt("Kvest6");
            }
            else
                Kvest6 = 0;
            if (Kvest6 == 1)
            {
                contr.Quest7();
            }

            if (PlayerPrefs.HasKey("Kvest7"))
            {
                Kvest7 = PlayerPrefs.GetInt("Kvest7");
            }
            else
                Kvest7 = 0;
            if (Kvest7 == 1)
            {
                contr.Quest8();
            }

            if (PlayerPrefs.HasKey("Kvest9"))
            {
                Kvest9 = PlayerPrefs.GetInt("Kvest9");
            }
            else
                Kvest9 = 0;
            if (Kvest9 == 1)
            {
                contr.Quest10();
            }

            if (PlayerPrefs.HasKey("Kvest13"))
            {
                Kvest13 = PlayerPrefs.GetInt("Kvest13");
            }
            else
                Kvest13 = 0;
            if (Kvest13 == 1)
            {
                contr.Quest14();
            }

            if (PlayerPrefs.HasKey("Kvest14"))
            {
                Kvest14 = PlayerPrefs.GetInt("Kvest14");
            }
            else
                Kvest14 = 0;
            if (Kvest14 == 1)
            {
                contr.Quest15();
            }

            if (PlayerPrefs.HasKey("Kvest15"))
            {
                Kvest15 = PlayerPrefs.GetInt("Kvest15");
            }
            else
                Kvest15 = 0;
            if (Kvest15 == 1)
            {
                contr.Quest16();
            }

            if (PlayerPrefs.HasKey("Kvest17"))
            {
                Kvest17 = PlayerPrefs.GetInt("Kvest17");
            }
            else
                Kvest17 = 0;
            if (Kvest17 == 1)
            {
                contr.Quest18();
            }
        }

        //Deffka
        if (other.tag == "DEFFKA")
        {
            if (PlayerPrefs.HasKey("Kvest11"))
            {
                Kvest11 = PlayerPrefs.GetInt("Kvest11");
            }
            else
                Kvest11 = 0;

            if (Kvest11 == 1)
            {
                contr.Quest12();
            }
        }

        //DEREVO
        if (other.tag == "DEREVO")
        {
            if (PlayerPrefs.HasKey("Kvest8"))
            {
                Kvest8 = PlayerPrefs.GetInt("Kvest8");
            }
            else
                Kvest8 = 0;

            if (Kvest8 == 1)
            {
                contr.Quest9();
            }
        }

        //Velikan
        if (other.tag == "VELIKAN")
        {
            if (PlayerPrefs.HasKey("Kvest16"))
            {
                Kvest16 = PlayerPrefs.GetInt("Kvest16");
            }
            else
                Kvest16 = 0;

            if (Kvest16 == 1)
            {
                contr.Quest17();
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Fire")
        {
            StopAllCoroutines();
            StartCoroutine(ReloadHP());
        }
        if (other.tag == "Kamnepad")
        {
            Generate();
        }
        if (other.tag == "KartaMap")
        {
            ButtonMapClick.SetActive(false);
        }

        if (other.tag == "KvestSkelet")
        {
            if (PlayerPrefs.HasKey("Kvest10"))
            {
                Kvest10 = PlayerPrefs.GetInt("Kvest10");
            }
            else
                Kvest10 = 0;
            if (PlayerPrefs.HasKey("Kvest12"))
            {
                Kvest12 = PlayerPrefs.GetInt("Kvest12");
            }
            else
                Kvest12 = 0;

            if (Kvest10 == 1)
            {
                contr.Quest11();
            }
            if (Kvest12 == 1)
            {
                contr.Quest13();
            }
        }
        // Stareishina
        if (other.tag == "STARETS")
        {
            if (PlayerPrefs.HasKey("Kvest0"))
            {
                Kvest0 = PlayerPrefs.GetInt("Kvest0");
            }
            else
                Kvest0 = 0;
            if (PlayerPrefs.HasKey("Kvest18"))
            {
                Kvest18 = PlayerPrefs.GetInt("Kvest18");
            }
            else
                Kvest18 = 0;

            if (Kvest0 == 0 || Kvest0 == 1)
            {
                contr.Quest1();
            }
            if (Kvest18 == 1)
            {
                contr.Quest19();
            }
        }

        //Fermer
        if (other.tag == "FERMER")
        {
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

            if (Kvest1 == 1 || Kvest1 == 2)
            {
                contr.Quest2();
            }
            if (Kvest2 == 2 || Kvest2 == 3)
            {
                contr.Quest3();
            }
        }

        // PUGALO
        if (other.tag == "PUGALO")
        {
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

            if (Kvest3 == 1 || Kvest3 == 2)
            {
                contr.Quest4();
            }
            if (Kvest4 == 2 || Kvest4 == 3)
            {
                contr.Quest5();
            }
        }

        //Vedma
        if (other.tag == "VEDMA")
        {
            if (PlayerPrefs.HasKey("Kvest5"))
            {
                Kvest5 = PlayerPrefs.GetInt("Kvest5");
            }
            else
                Kvest5 = 0;

            if (Kvest5 == 1)
            {
                contr.Quest6();
            }

            if (PlayerPrefs.HasKey("Kvest6"))
            {
                Kvest6 = PlayerPrefs.GetInt("Kvest6");
            }
            else
                Kvest6 = 0;
            if (Kvest6 == 1)
            {
                contr.Quest7();
            }

            if (PlayerPrefs.HasKey("Kvest7"))
            {
                Kvest7 = PlayerPrefs.GetInt("Kvest7");
            }
            else
                Kvest7 = 0;
            if (Kvest7 == 1)
            {
                contr.Quest8();
            }

            if (PlayerPrefs.HasKey("Kvest9"))
            {
                Kvest9 = PlayerPrefs.GetInt("Kvest9");
            }
            else
                Kvest9 = 0;
            if (Kvest9 == 1)
            {
                contr.Quest10();
            }

            if (PlayerPrefs.HasKey("Kvest13"))
            {
                Kvest13 = PlayerPrefs.GetInt("Kvest13");
            }
            else
                Kvest13 = 0;
            if (Kvest13 == 1)
            {
                contr.Quest14();
            }

            if (PlayerPrefs.HasKey("Kvest14"))
            {
                Kvest14 = PlayerPrefs.GetInt("Kvest14");
            }
            else
                Kvest14 = 0;
            if (Kvest14 == 1)
            {
                contr.Quest15();
            }

            if (PlayerPrefs.HasKey("Kvest15"))
            {
                Kvest15 = PlayerPrefs.GetInt("Kvest15");
            }
            else
                Kvest15 = 0;
            if (Kvest15 == 1)
            {
                contr.Quest16();
            }

            if (PlayerPrefs.HasKey("Kvest17"))
            {
                Kvest17 = PlayerPrefs.GetInt("Kvest17");
            }
            else
                Kvest17 = 0;
            if (Kvest17 == 1)
            {
                contr.Quest18();
            }
        }

        //Deffka
        if (other.tag == "DEFFKA")
        {
            if (PlayerPrefs.HasKey("Kvest11"))
            {
                Kvest11 = PlayerPrefs.GetInt("Kvest11");
            }
            else
                Kvest11 = 0;

            if (Kvest11 == 1)
            {
                contr.Quest12();
            }
        }

        //DEREVO
        if (other.tag == "DEREVO")
        {
            if (PlayerPrefs.HasKey("Kvest8"))
            {
                Kvest8 = PlayerPrefs.GetInt("Kvest8");
            }
            else
                Kvest8 = 0;

            if (Kvest8 == 1)
            {
                contr.Quest9();
            }
        }

        //Velikan
        if (other.tag == "VELIKAN")
        {
            if (PlayerPrefs.HasKey("Kvest16"))
            {
                Kvest16 = PlayerPrefs.GetInt("Kvest16");
            }
            else
                Kvest16 = 0;

            if (Kvest16 == 1)
            {
                contr.Quest17();
            }
        }
    }

    IEnumerator DeathFromFireorRiver()
    {
        while (PlayerHealth >= 0)
        {
            damaged = true;
            PlayerHealth -= 1;
            yield return new WaitForSeconds(1.0f);
        }
    }
    IEnumerator ReloadHP()
    {
        while (PlayerHealth <= 4)
        {
            yield return new WaitForSeconds(8f);
            PlayerHealth += 1;
        }
    } 
    void Death()
    {
        damaged = true; 
        Time.timeScale = 0;
        PanGameOverYouDied.SetActive(true);
    }

   /* void KvestKladbishe()
    { 
   
    }*/

    [ContextMenu("Generate")]
    void Generate()
    {
        Instantiate(PrefKamnepad, new Vector3(1657, 65, 1618.5f), Quaternion.Euler(Random.Range(0, 360), Random.Range(0, 360), 0));
        Instantiate(PrefKamnepad, new Vector3(1652, 65, 1627.5f), Quaternion.Euler(0, Random.Range(0, 360), Random.Range(0, 360)));
        Instantiate(PrefKamnepad, new Vector3(1657, 65, 1634f), Quaternion.Euler(0, Random.Range(0, 360), 0));
        Instantiate(PrefKamnepad, new Vector3(1656.5f, 65, 1611f), Quaternion.Euler(0, Random.Range(0, 360), Random.Range(0, 360)));
        Instantiate(PrefKamnepad, new Vector3(1658.5f, 65, 1604f), Quaternion.Euler(0, Random.Range(0, 360), 0));
        Instantiate(PrefKamnepad, new Vector3(1670, 65, 1625f), Quaternion.Euler(0, Random.Range(0, 360), 0));
        Instantiate(PrefKamnepad, new Vector3(1664.38f, 65, 1618.5f), Quaternion.Euler(Random.Range(0, 360), Random.Range(0, 360), 0));
        Instantiate(PrefKamnepad, new Vector3(1664.38f, 65, 1638.76f), Quaternion.Euler(0, Random.Range(0, 360), 0));
    }

   
}

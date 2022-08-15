using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private Inventory inventory;
    public GameObject slotButton;
    public string TagOfObj;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        TagOfObj = this.tag;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    inventory.isFull[i] = true;
                    Instantiate(slotButton, inventory.slots[i].transform);
                    if(TagOfObj == "Bull")
                    {
                        PlayerPrefs.SetInt("Kvest2", 2);
                    }
                    if (TagOfObj == "Rabbit")
                    {
                        PlayerPrefs.SetInt("Kvest4", 2);
                    }
                    if (TagOfObj == "PoyasVelikanaRV")
                    {
                       PlayerPrefs.SetInt("Kvest7", 2);
                    }
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }
}

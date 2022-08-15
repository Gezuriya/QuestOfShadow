using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public GameObject Player;
    void Update()
    {
        transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y + 2f, Player.transform.position.z + 1f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitController : MonoBehaviour
{
    private Animator animator;
    public int SvapAnim, playerSpeed, Svap;
    bool Rex, GoOrNo;
    Rigidbody _rig;
    void Start()
    {
        _rig = GetComponent<Rigidbody>();
        Rex = true;
        animator = GetComponent<Animator>();
        StartCoroutine(Svapper());
    }
    private void FixedUpdate()
    {
        if (GoOrNo)
        {
            if (Svap == 0)
            {
                _rig.velocity = Vector3.forward * playerSpeed * Time.deltaTime;
            }
            if (Svap == 1)
            {
                _rig.velocity = Vector3.left * playerSpeed * Time.deltaTime;
            }
            if (Svap == 2)
            {
                _rig.velocity = Vector3.right * playerSpeed * Time.deltaTime;
            }
            if (Svap == 3)
            {
                _rig.velocity = Vector3.back * playerSpeed * Time.deltaTime;
            }
            transform.rotation = Quaternion.LookRotation(_rig.velocity);
        }
    }
    IEnumerator Svapper()
    {
        while (Rex)
        {
            yield return new WaitForSeconds(8);
            SvapAnim = Random.Range(0, 2);
            if (SvapAnim == 0)
            {
                animator.SetBool("Run", false);
                Svap = Random.Range(0, 4);
                GoOrNo = false;
            }
            else if (SvapAnim == 1)
            {
                animator.SetBool("Run", true);
                GoOrNo = true;
            }
        }
    }
}

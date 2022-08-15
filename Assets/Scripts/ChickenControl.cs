using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenControl : MonoBehaviour
{
    private Animator animator;
    public int SvapAnim, playerSpeed, Svap;
    bool Rex, GoOrNo;
    Vector3 RandGo;
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
            if(Svap == 0)
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
            SvapAnim = Random.Range(0, 4);
            if (SvapAnim == 0 || SvapAnim == 2)
            {
                animator.SetBool("Eat", false);
                animator.SetBool("Walk", true);
                Svap = Random.Range(0, 4);
                GoOrNo = true;
            }
            else if (SvapAnim == 1 || SvapAnim == 3)
            {
                animator.SetBool("Walk", false);
                animator.SetBool("Eat", true);
                GoOrNo = false;
            }
            else
            {
                animator.SetBool("Walk", false);
                animator.SetBool("Eat", false);
                GoOrNo = false;
            } 
        }
        
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleDoll : MonoBehaviour
{

    Rigidbody[] myRigidbodys;

    public ControlePersonagem CP;
    public ControleDoll cD;
    public Animator playerAn;
    public CharacterController CC;

    void Start()
    {
        myRigidbodys = GetComponentsInChildren<Rigidbody>();

        foreach (Rigidbody rdb in myRigidbodys)
        {
            rdb.isKinematic = true;
        }
    }

    public void Morte()
    {
        foreach (Rigidbody rdb in myRigidbodys)
        {
            CP.enabled = false;
            CC.enabled = false;
            playerAn.enabled = false;
            rdb.isKinematic = false;
        }
    }

}

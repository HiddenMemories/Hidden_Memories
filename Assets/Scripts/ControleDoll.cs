using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleDoll : MonoBehaviour
{

    public Rigidbody[] myRigidbodys;

    public MoveCharacterTuca MCT;
    public ControleDoll cD;
    public Animator playerAn;
    //public Rigidbody rdb;
    //public CharacterController CC;

    void Start()
    {
        myRigidbodys = GetComponentsInChildren<Rigidbody>();

        foreach (Rigidbody rdb in myRigidbodys)
        {
            //rdb.isKinematic = true;
        }
    }
    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Y))
        {
            Morte();
        }
    }
    public void Morte()
    {
        foreach (Rigidbody rdb in myRigidbodys)
        {
            MCT.enabled = false;
            //CC.enabled = false;
            playerAn.enabled = false;
            rdb.isKinematic = false;
        }
    }

}

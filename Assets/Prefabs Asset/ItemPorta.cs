﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPorta : MonoBehaviour {

    public GameObject mensagemPorta;
    public ItemAdquirido item;
    public Animation animPorta;
     void OnTriggerStay(Collider other)
    {
     if(other.gameObject.tag=="Player" && item.itemPego==true && Input.GetKeyDown(KeyCode.E))
        {
            animPorta.Play();
            mensagemPorta.SetActive(false);
        }

     
    }
}

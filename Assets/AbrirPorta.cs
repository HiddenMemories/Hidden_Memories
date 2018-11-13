using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirPorta : MonoBehaviour {
    public Animation animPorta;
    public bool portaAberta = false;
     void OnTriggerStay(Collider other)
    {
     if(other.gameObject.tag=="Player" && Input.GetKeyDown(KeyCode.E) && portaAberta==false)
        {
            animPorta.Play();
            portaAberta = true;
        }
    }
}

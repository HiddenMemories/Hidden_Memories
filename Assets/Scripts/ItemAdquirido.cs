using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAdquirido : MonoBehaviour
{
    public bool itemPego = false;
    public GameObject itemMacaneta;
    public GameObject triggerMensagem;
    public GameObject mensagemItem;
    void OnTriggerStay(Collider other)
    {
        triggerMensagem.SetActive(true);

        if (other.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.E))
        {
            itemPego = true;
            itemMacaneta.SetActive(false);
            mensagemItem.SetActive(true);


        }
        if (itemPego == true)
        {
            triggerMensagem.SetActive(false);
        }

    }

    void OnTriggerExit(Collider other)
    {
       if(other.gameObject.tag=="Player")
        {
            triggerMensagem.SetActive(false);
        }
    }



}

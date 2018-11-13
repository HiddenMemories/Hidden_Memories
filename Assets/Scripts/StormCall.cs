using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StormCall : MonoBehaviour
{
    public GameObject Thunder;
    public GameObject ChuvaSound;
    public GameObject ChuvaParticle;
    public bool triggerAtivo = false;

    void Update()
    {
        if (triggerAtivo == true)
        {
            AtivarThunder();
            Invoke("AtivarSomChuva", 7);
            Invoke("AtivarParticulas", 9);

        }   
    }
   
    public void AtivarThunder()
    {
        Thunder.SetActive(true);
    }
    public void AtivarSomChuva()
    {
        
        ChuvaSound.SetActive(true);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            triggerAtivo = true;
        }
    }
    public void AtivarParticulas()
    {
        ChuvaParticle.SetActive(true);
    }
}

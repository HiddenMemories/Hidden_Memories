using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeSwitch : MonoBehaviour
{

    public Animator bridgeAnimator;
    public GameObject bridgeCollider;

   // public Animation bridgeAnimation;
    public bool isActive = false;
    public Light redLight;
    public Light greenLight;

    public GameObject textodeInteracao;
    

    void OnTriggerStay(Collider other)
    {
        if (isActive == false)
        {
            
            textodeInteracao.SetActive(true);

            Debug.Log(other.gameObject.tag);
            if (other.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.E) && isActive == false)

            {
                redLight.enabled = false;
                greenLight.enabled = true;
                BridgeActive();

                bridgeAnimator.SetBool("OpenBridge", true);
                bridgeCollider.SetActive(false);

               // StartCoroutine(delayAnimation());
            }
        }
        else
        {
           
            textodeInteracao.SetActive(false);
        }

    }
    void OnTriggerExit(Collider other)
    {
        textodeInteracao.SetActive(false);
    }
    private IEnumerator delayAnimation()
    {
        yield return new WaitForSeconds(1);
        //bridgeAnimation.Play();
    }
    public void BridgeActive()
    {
        isActive = true;
    }
}

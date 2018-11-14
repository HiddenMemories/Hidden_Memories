using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour {

    public GameObject newPos;
    public GameObject playerPos;

    public ControlePersonagem CP;
    public Animator anim;
    public bool teleport = false;
    public bool pause = false;
   
    public Animation fadeAnim;
    public GameObject stairsSound;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (teleport == true)
        {
            StartCoroutine(teleportTimer());
            StartCoroutine(UnPause());
          
            
           
        }
	}
     void OnTriggerStay(Collider other)
    {
     if(other.gameObject.tag=="Player" && Input.GetKeyDown(KeyCode.E))
        {
           
            teleport =true;
            fadeAnim.Play();
            CP.enabled = false;
            anim.enabled = false;
            

        }
    }

    private IEnumerator UnPause()
    {
        yield return new WaitForSeconds(7);
        CP.enabled = true;
        anim.enabled = true;
        stairsSound.SetActive(false);
        

    }
    private IEnumerator teleportTimer()
    {
        yield return new WaitForSeconds(4);
        playerPos.transform.position = newPos.transform.position;
        teleport = false;
        stairsSound.SetActive(true);

    }
    
}

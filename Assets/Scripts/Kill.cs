using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
public class Kill : MonoBehaviour
{
    public ControleDoll CD;
    public ControlePersonagem player;
    public NavMeshAgent agent;
    public GameObject fadeMorte;

    //public Object SceneToLoad;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            agent.speed = 0;
            CD.Morte();
            fadeMorte.SetActive(true);
            StartCoroutine(LoadingScene());
        }
       
    }
    private IEnumerator Fade()
    {
        yield return new WaitForSeconds(3);
        fadeMorte.SetActive(true);
    }

    private IEnumerator Reload()
    {
        yield return new WaitForSeconds(3);
        //fadeMorte.SetActive(true);
    }
    private IEnumerator LoadingScene()
    {
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene("TelaAgradecimento");
    }
}

        
  
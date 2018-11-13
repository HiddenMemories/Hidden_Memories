using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{

    void Update()
    {
        StartCoroutine(WaitForNewSceneLoad());
    }

    private IEnumerator WaitForNewSceneLoad()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Level1");
    }
}

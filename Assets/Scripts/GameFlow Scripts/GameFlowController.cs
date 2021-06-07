using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameFlowController : MonoBehaviour
{
   
    public void loadScene(string sceneName)
    {
        StartCoroutine(CrLoadScene(sceneName));
    }

    IEnumerator CrLoadScene(string sceneName)
    {
        yield return FindObjectOfType<TransitionController>().CrFadeToBlack();
        SceneManager.LoadScene(sceneName);
    }
}

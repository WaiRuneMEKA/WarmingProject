using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScene : MonoBehaviour
{
    public float num;
    public string nameScene;
    
    void Start()
    {
        StartCoroutine(EndPro(num,nameScene));
    }

    IEnumerator EndPro(float nume , string sceneName)
    {
        yield return new WaitForSecondsRealtime(nume);
        SceneManager.LoadScene(sceneName);
    }
}

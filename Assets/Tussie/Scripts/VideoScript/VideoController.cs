using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    public GameObject StartVid;
    public GameObject[] Btn;
    public VideoPlayer MainPlayer;
    public GameObject MainPlayerObj;
    public GameObject IdleVid;
    public GameObject IdlePlayerObj;
    public VideoPlayer IdlePlayer;

    public int numSec;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < Btn.Length; i++)
        {
            Debug.Log(Btn[i]);
        }
        
        StartVid.SetActive(true);
        MainPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
        MainPlayer.EnableAudioTrack(0, true);
        MainPlayer.Prepare();
        StartCoroutine(WaitForVideoEnd());
    }

    public void BtnChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    IEnumerator WaitForVideoEnd()
    {
        yield return new WaitForSecondsRealtime(numSec);
        StartVid.SetActive(false);
        MainPlayerObj.SetActive(false);
        IdleVid.SetActive(true);
        IdlePlayerObj.SetActive(true);
        IdlePlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
        IdlePlayer.EnableAudioTrack(0, true);
        IdlePlayer.Prepare();

        for(int i = 0; i < Btn.Length; i++)
        {
            Btn[i].SetActive(true);
        }
    }
}

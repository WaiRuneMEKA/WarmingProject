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
    public VideoPlayer videoPlayer;
    public GameObject image;

    public int numSec;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < Btn.Length; i++)
        {
            Debug.Log(Btn[i]);
        }
        
        StartVid.SetActive(true);
        videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
        videoPlayer.EnableAudioTrack(0, true);
        videoPlayer.Prepare();
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
        image.SetActive(true);

        for(int i = 0; i < Btn.Length; i++)
        {
            Btn[i].SetActive(true);
        }
    }
}

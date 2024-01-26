using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ClickComboTest : MonoBehaviour
{
    public Slider slider;
    public GameObject Btn;
    public int comboNum;

    public void OnClickBtn()
    {
        comboNum++;
        slider.value = comboNum;
        StartCoroutine(ClickTimer());
    }

    IEnumerator ClickTimer()
    {
        yield return new WaitForSecondsRealtime(3);
        comboNum = 0;
    }
}

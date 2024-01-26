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

    public float EnumNum;

    void Start()
    {
        StartCoroutine(DecreaseNum(EnumNum));
    }

    private void Update()
    {
        slider.value = comboNum;
    }

    IEnumerator DecreaseNum(float num)
    {
        while (true)
        {
            yield return new WaitForSeconds(num);

            if (comboNum <= 0)
            {
                comboNum = 0;
            }
            else
            {
                comboNum--;
            }
        }
    }

    public void OnClickBtn()
    {
        comboNum++;
    }

    
}

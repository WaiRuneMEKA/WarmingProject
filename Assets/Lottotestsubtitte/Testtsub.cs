using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Testtsub : MonoBehaviour
{
    public Subtitte[] subtitte;

    public TMP_Text MainText;
    public float Maintext_Sec;
    public float timeBtwChars = 0.1f;
    public Color Maintext_Color;

    public TMP_Text Subtext;
    public float Subtext_Sec;
    public float timeBtwChars2 = 0.1f;
    public Color Subtext_Color;



    void Start()
    {
        
        StartCoroutine(WaitText());
        StartCoroutine(WaitText2());

       

    }


    // Update is called once per frame
    void Update()
    {
        if (Maintext_Sec >= 0) // ลบข้อความเมื่อ Sec = 0
        {
            Maintext_Sec -= Time.deltaTime;

            if (Maintext_Sec <= 0.0f)
            {

                MainText.text = "";
                Maintext_Sec = 0;
            }
        }

        if (Subtext_Sec >= 0) // ลบข้อความเมื่อ Sec = 0
        {
            Subtext_Sec -= Time.deltaTime;

            if (Subtext_Sec <= 0.0f)
            {

                Subtext.text = "";
                Subtext_Sec = 0;
            }
        }

    }


    IEnumerator WaitText()
    {
        for (int i = 0; i < subtitte.Length; i++)
        {
           
            print(i + "Main");
            if (subtitte[i].MainText != null && subtitte[i].Maintext_Sec > 0)
            {
                MainText.text = "";  // ล้างข้อความก่อนเริ่มเอฟเฟกต์เครื่องพิมพ์ดีด
                MainText.color = subtitte[i].Maintext_Color;
                print(subtitte[i].Maintext_Color);
                StartCoroutine(TypeWriterTMP(subtitte[i].MainText));
                Maintext_Sec = subtitte[i].Maintext_Sec;
                yield return new WaitForSeconds(Maintext_Sec);
            }
            print("ทำงานต่อ");

        }



    }

    IEnumerator WaitText2()
    {
        for (int i = 0; i < subtitte.Length; i++)
        {

            print(i + "Sub");
            if (subtitte[i].Subtext != null && subtitte[i].Subtext_Sec > 0)
            {
                Subtext.text = "";  // ล้างข้อความก่อนเริ่มเอฟเฟกต์เครื่องพิมพ์ดีด
                Subtext.color = subtitte[i].Subtext_Color;
                StartCoroutine(TypeWriterTMP2(subtitte[i].Subtext));
                Subtext_Sec = subtitte[i].Subtext_Sec;
                yield return new WaitForSeconds(Subtext_Sec);
            }
            print("ทำงานต่อ");

        }


    }
    IEnumerator TypeWriterTMP(string text)
    {
        foreach (char c in text)
        {
            MainText.text += c;
            yield return new WaitForSeconds(timeBtwChars);
        }
    }

    IEnumerator TypeWriterTMP2(string text)
    {
        foreach (char c in text)
        {
            Subtext.text += c;
            yield return new WaitForSeconds(timeBtwChars2);
        }
    }
}

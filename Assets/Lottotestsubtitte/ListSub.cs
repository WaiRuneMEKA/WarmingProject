using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ListSub : MonoBehaviour
{
    public Subtitte[] subtitte;

    public TMP_Text MainText;
    public float Maintext_Sec;
    //int RoundMainText;

    public TMP_Text Subtext;
    public float Subtext_Sec;

    //string writer;
    //public float timeBtwChars = 0.1f;
    //string leadingChar = "";


    // Start is called before the first frame update
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
            if (subtitte[i].MainText == null || subtitte[i].Maintext_Sec == 0)
            {
                MainText.text = "";
                Maintext_Sec = 0;
                yield return new WaitForSeconds(Maintext_Sec);
            }
            else
            {
                MainText.text = subtitte[i].MainText;
                //writer = MainText.text;
                //TypeWriterTMP();
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
            if (subtitte[i].Subtext == null || subtitte[i].Subtext_Sec == 0)
            {
                Subtext.text = "";
                Subtext_Sec = 0;
                yield return new WaitForSeconds(Subtext_Sec);
            }
            else
            {
                print(i + "sub");
                Subtext.text = subtitte[i].Subtext;
                Subtext_Sec = subtitte[i].Subtext_Sec;
                yield return new WaitForSeconds(Subtext_Sec);
            }
            print("ทำงานต่อ");



        }


    }
}

//    IEnumerator TypeWriterTMP()
//    {
//        print("พิม" + RoundMainText);
//        MainText.text = "";
//        MainText.text = subtitte[RoundMainText].MainText;
//        foreach (char c in writer)
//        {
//            if (MainText.text.Length > 0)
//            {
//                MainText.text = MainText.text.Substring(0, MainText.text.Length - leadingChar.Length);
//            }
//            MainText.text += c;
//            MainText.text += leadingChar;
//            yield return new WaitForSeconds(timeBtwChars);
//        }

//        if (leadingChar != "")
//        {
//            MainText.text = MainText.text.Substring(0, MainText.text.Length - leadingChar.Length);
//        }

//        yield return null;
//    }
//}

    


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour
{
    int get;
    public Text ResultText;

    void Start()
    {
        //get = ClickCount.GetSaveCount();         //PCのキーボードを使う時
        get = SerialReceive.GetSaveCount();　　　   //マイコンを使う時
        
        ResultText.text = get + "回";
    }
}

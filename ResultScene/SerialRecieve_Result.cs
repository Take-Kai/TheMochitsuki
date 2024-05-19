using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SerialRecieve_Result : MonoBehaviour
{
    //https://qiita.com/yjiro0403/items/54e9518b5624c0030531
    //上記URLのSerialHandler.cのクラス

    public SerialHandler_Result serialHandler_Result;

    void Start()
    {
        //信号を受信したときに、そのメッセージの処理を行う
        serialHandler_Result.OnDataReceived += OnDataReceived;
    }    

    //受信した信号(message)に対する処理
    void OnDataReceived(string message)
    {
        var data = message.Split(
                new string[] { "\n" }, System.StringSplitOptions.None);
        try
        {
            Debug.Log(data[0]);//Unityのコンソールに受信データを表示

              if(message[0] == 'K')   //杵のK
              {
                SceneManager.LoadScene("Start");
                //penaltyCount = penaltyCount + 1;
              }

              if(message[0] == 'U')   //臼のU
              {
                SceneManager.LoadScene("SampleScene");
                  //penaltyCount = 0;
              }
        }
        
        catch (System.Exception e)
        {
            Debug.LogWarning(e.Message);//エラーを表示
        }
    }
}
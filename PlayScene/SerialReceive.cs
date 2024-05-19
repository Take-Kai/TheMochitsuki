using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SerialReceive : MonoBehaviour
{
    //https://qiita.com/yjiro0403/items/54e9518b5624c0030531
    //上記URLのSerialHandler.cのクラス

    [SerializeField] private Animator moveKine;
    [SerializeField] private Animator moveHand;

    public SerialHandler serialHandler;

    public GameObject start;
    public GameObject ClickDetective;

    private int count = 0;
    private int penaltyCount = 0;
    public static int saveCount;
    public float untilstart = 3.0f;

    public GameObject TimeCounter;

    public Text counterText;
    public Text timeText;


  void Start()
    {
        //信号を受信したときに、そのメッセージの処理を行う
        serialHandler.OnDataReceived += OnDataReceived;
    }

  void Update()
  {
      if(start.activeSelf)
      {
        saveCount = count;
      }

      counterText.text = count.ToString("0") + "回";
  }


  public static int GetSaveCount()
  {
    return saveCount;
  }
  


  public void Penalty()
  {
    if(penaltyCount >= 4)
    {
      count = count - 3;
    }
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
                ClickDetective.SetActive(true);

                moveHand.SetBool("MoveHand", false);
                moveKine.SetBool("Move", true);

                //penaltyCount = penaltyCount + 1;
              }

              if(ClickDetective.activeSelf)
              {
                if(message[0] == 'U')   //臼のU
                {
                  count++;
                  ClickDetective.SetActive(false);

                  moveHand.SetBool("MoveHand", true);
                  moveKine.SetBool("Move", false);

                  //penaltyCount = 0;
                }
              }

              if(start.activeSelf)
              {
                if(message[0] == 'U')
                {
                  untilstart -= Time.deltaTime;
                  timeText.text = untilstart.ToString("0");
                  start.SetActive(false);
                }
              }
        }
        
        catch (System.Exception e)
        {
            Debug.LogWarning(e.Message);//エラーを表示
        }
    }
}
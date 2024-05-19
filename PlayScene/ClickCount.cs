using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClickCount : MonoBehaviour
{
    [SerializeField] private Animator moveKine;
    [SerializeField] private Animator moveHand;

    public GameObject start;
    public GameObject ClickDetective;

    private int count = 0;
    public static int saveCount;
    //private int penaltyCount  = 0;

    public GameObject TimeCounter;

    public Text counterText;

  void Update()
  {
      if(!start.activeSelf)
      {
        if(Input.GetKeyDown(KeyCode.Space))   //杵で餅をつく動作
        {
          moveKine.SetBool("Move", true);
          moveHand.SetBool("MoveHand", false);
          ClickDetective.SetActive(true);

          //penaltyCount += 1;
          //Debug.Log(penaltyCount);
        }

        if(ClickDetective.activeSelf)
        {
            if(Input.GetMouseButtonDown(0))
            {
              moveKine.SetBool("Move", false);
              moveHand.SetBool("MoveHand", true);
              ClickDetective.SetActive(false);
              count++;
              //penaltyCount = 0;
            }
        }
      }
      /*
      if(penaltyCount >= 5)
      {
        count = count - 1;
      }
      */

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
}

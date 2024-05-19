using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeCounter : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip Junei_1;
    public AudioClip Junei_2;

    public GameObject start;

    private float countdown = 20.0f;
    private float untilstart = 3.0f;
    private float untilSceneChange = 3.0f;

    //bool isStart = false;

    public Text timeText;

    void Start()
    {
       audioSource = GetComponent<AudioSource>();
       timeText.text = "エンターキーをおしてね";
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Return))
        {
            start.SetActive(true);
            //audioSource.PlayOneShot(Junei_1);
        }

        if(start.activeSelf)
        {
            untilstart -= Time.deltaTime;
            timeText.text = untilstart.ToString("0");
        }

        if(untilstart <= 0)
        {
            start.SetActive(false);
            countdown -= Time.deltaTime;
            timeText.text = "のこり" + countdown. ToString(" 0 ") + "びょう";
        }

        if(countdown <= 0)
        {
            //audioSource.PlayOneShot(Junei_2);
            start.SetActive(true);
            timeText.text = "おわり！";
            untilSceneChange -= Time.deltaTime;
        }

        if(untilSceneChange <= 0)
        {
            SceneManager.LoadScene("Ending");
        }
    }
}
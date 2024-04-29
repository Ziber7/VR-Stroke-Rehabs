using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using TMPro;

public class BallManager : MonoBehaviour
{
    public int BallCounter;
    public TMP_Text BallText;

    public GameObject HitBoxKey;
    public GameObject KeyObject;
    public GameObject FindKey;
    public GameObject GameUI;
    bool isBallSix = false;

    // Start is called before the first frame update
    void Start()
    {
       PlayerPrefs.SetInt("BallCount", 0);
        GameUI.SetActive(true);
        FindKey.SetActive(false);
        HitBoxKey.SetActive(false);
        KeyObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        BallCounter = PlayerPrefs.GetInt("BallCount");
        BallText.text = BallCounter.ToString() + "/6";

        if (isBallSix == false)
        {
            BallCheck();
        }
    }

    void BallCheck()
    {
        if(BallCounter == 6)
        {
            GameUI.SetActive(false);
            FindKey.SetActive(true);
            HitBoxKey.SetActive(true);
            KeyObject.SetActive(true);
            isBallSix = true;
        }
    }
}

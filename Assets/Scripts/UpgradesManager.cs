using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradesManager : MonoBehaviour
{
    public int coinsInWallet;
    public Text coinsText;
    public Animator powerAnim, speedAnim, coinsAnim;

    [Space(10)]
    [Header("Basics")]
    public Animator csoonAnim;
    public bool pwrPossible, spdPossible, coinsPossible;

    [Space(10)]
    [Header("Unavailable Button")]
    public bool useless;
    public Color f1_Unavl, f2_Unavl, shad_Unavl, out_Unavl, cb_Unavl;

    [Space(10)]
    [Header("Power Button")]
    public GameObject powPart;
    public int pwrInitCost, pwrLevel, pwrMulti;
    public Shapes2D.Shape powerShape, powerCbShape;
    public Color f1_power, f2_power, shad_power, out_Power, cb_power;
    public Image powCoinImg, powVidImg, powRayImg;
    public Text powCoinText, powVidText, pwrLvlTxt;

    [Space(10)]
    [Header("Speed Button")]
    public GameObject spdPart;
    public int spdInitCost, spdLevel, spdMulti;
    public Shapes2D.Shape speedShape, speedCbShape;
    public Color f1_Speed, f2_Speed, shad_Speed, out_Speed, cb_Speed;
    public Image spdCoinImg, spdVidImg, spdRayImg;
    public Text spdCoinText, spdVidText, spdLvlTxt;

    [Space(10)]
    [Header("Coins Button")]
    public GameObject coinPart;
    public int coinsInitCost, coinsLevel, coinsMulti;
    public Shapes2D.Shape coinShape, coinCbShape;
    public Color f1_Coin, f2_Coin, shad_Coin, out_Coin, cb_Coin;
    public Image coinCoinImg, coinVidImg, coinRayImg;
    public Text coinCoinText, coinVidText, coinsLvlTxt;

    void Awake()
    {
        coinsInWallet = PlayerPrefs.GetInt("Coins", 0);
        coinsText.text = "$" + coinsInWallet.ToString("");

        pwrLevel = PlayerPrefs.GetInt("PowerLevel", 1);
        pwrLvlTxt.text = "Lvl" + pwrLevel.ToString("");

        spdLevel = PlayerPrefs.GetInt("SpeedLevel", 1);
        spdLvlTxt.text = "Lvl" + spdLevel.ToString("");

        coinsLevel = PlayerPrefs.GetInt("CoinsLevel", 1);
        coinsLvlTxt.text = "Lvl" + coinsLevel.ToString("");


    }

    void Update()
    {

    }

    public void UpgradePower()
    {
        if(pwrPossible)
        {
            // Power Upgraded
            pwrLevel += 1;
            PlayerPrefs.SetInt("PowerLevel", pwrLevel);
            pwrLvlTxt.text = "Lvl" + pwrLevel.ToString("");
        }
        else
        {
            csoonAnim.gameObject.SetActive(false);
            csoonAnim.gameObject.SetActive(true);
            powerAnim.Play("UpgErr", -1, 0.0f);
        }
    }

    public void UpgradeSpeed()
    {

        if (pwrPossible)
        {
            // Speed Upgraded
            spdLevel += 1;
            PlayerPrefs.SetInt("SpeedLevel", spdLevel);
            spdLvlTxt.text = "Lvl" + spdLevel.ToString("");
        }
        else
        {
            csoonAnim.gameObject.SetActive(false);
            csoonAnim.gameObject.SetActive(true);
            speedAnim.Play("UpgErr", -1, 0.0f);
        }
    }

    public void UpgradeCoins()
    {

        if (pwrPossible)
        {
            // Coins Upgraded
            coinsLevel += 1;
            PlayerPrefs.SetInt("CoinsLevel", coinsLevel);
            coinsLvlTxt.text = "Lvl" + coinsLevel.ToString("");
        }
        else
        {
            csoonAnim.gameObject.SetActive(false);
            csoonAnim.gameObject.SetActive(true);
            coinsAnim.Play("UpgErr", -1, 0.0f);
        }
    }

    public void CheckUpgradesAvailability()
    {

    }
}
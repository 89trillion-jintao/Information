using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * 每领取一次奖励，金钱增加200
 */
public class RewardOnBtn : MonoBehaviour
{
    [SerializeField] private Text moneyTxt;
    private int sumOfMoney;

    //每点击一次按钮，获得两百奖励
    public void OnClick()
    {
        sumOfMoney += 200;
        moneyTxt.text = "MONEY: " + sumOfMoney;
    }
}
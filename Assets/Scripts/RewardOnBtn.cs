using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * 判断奖励按钮是否可以继续点击，点击后直接领取奖励，已领取的奖励不可再领取
 */
public class RewardOnBtn : MonoBehaviour
{
    [SerializeField] private Text moneyTxt;    //获取money文本
    
    [SerializeField] private Button rewardBtn;    //获取奖励的按钮
    
    [SerializeField] private Text rewardBtnTxt;    //获取奖励按钮的文本内容
    
    private int sumOfMoney;    //当前金钱数

    public void CloseAndReward()
    {
        //已领取的按钮将不能再进行点击
        rewardBtn.enabled = false;
        rewardBtnTxt.text = "奖励已领取！";
        //每点击一次按钮，获得两百奖励
        sumOfMoney = int.Parse(moneyTxt.text);
        sumOfMoney += 200;
        moneyTxt.text = "" + sumOfMoney;
    }
}
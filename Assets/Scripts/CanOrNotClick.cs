using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * 判断奖励按钮是否可以继续点击，已领取的奖励不可再领取
 */
public class CanOrNotClick : MonoBehaviour
{
    //获取奖励的按钮
    [SerializeField] private Button rewardBtn;

    //获取奖励按钮的文本内容
    [SerializeField] private Text rewardBtnTxt;

    //已领取的按钮将不能再进行点击
    public void OnClick()
    {
        rewardBtn.enabled = false;
        rewardBtnTxt.text = "奖励已领取！";
    }
}
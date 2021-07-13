using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * 控制加分按钮和刷新赛季按钮
 */
public class ScoreAndRefresh : MonoBehaviour
{
    //获取分数文本
    [SerializeField] private Text scoreTxt;

    //获取段位文本
    [SerializeField] private Text rankTxt;

    //获取按钮
    [SerializeField] private List<Button> rewardBtn;
    
    //获取按钮文本
    [SerializeField] private List<Text> rewardBtnTxt;


    //初始化总分数
    private int sumOfScore = 3500;

    //段位
    private int rank;

    //用来查看afterName是否重复
    private int checkAfterName;

    //绑定加分按钮的点击事件
    public void OnClick()
    {
        sumOfScore += 100;
        scoreTxt.text = "SCORE: " + sumOfScore;
        //六千分封顶
        if (sumOfScore >= 6000)
        {
            sumOfScore = 6000;
            scoreTxt.text = "SCORE: 6000";
        }
        else
        {
            //大于四千后可以开始领取奖励
            if (sumOfScore >= 4000)
            {
                rank = sumOfScore / 1000 - 3;
                rankTxt.text = "RANK: 段位" + rank;
                int afterName = (sumOfScore - 4000) / 200;
                if (sumOfScore >= 4200 && sumOfScore % 1000 != 0 && checkAfterName != afterName)
                {
                    checkAfterName = afterName;
                    if (afterName == 5 || afterName == 10||rewardBtnTxt[afterName - 1].text=="奖励已领取！")
                    {
                        return;
                    }
                    //到达段位后将奖励按钮生效并修改按钮文本 
                    rewardBtn[afterName - 1].enabled = true;
                    rewardBtnTxt[afterName - 1].text = "可领取";
                }
            }
        }
    }

    //绑定赛季刷新按钮的点击事件
    public void RefreshScore()
    {
        if (sumOfScore < 4000)
        {
            return;
        }

        //赛季刷新后4000+的分被减去一半
        if (sumOfScore % 2 != 0)
        {
            sumOfScore--;
            sumOfScore -= (sumOfScore - 4000) / 2;
        }
        else
        {
            sumOfScore -= (sumOfScore - 4000) / 2;
        }

        scoreTxt.text = "SCORE: " + sumOfScore;
        //将可领取的按钮生效，并修改文本
        for (var i = 1; i <= (sumOfScore - 4000) / 200 + 1; i++)
        {
            if (i == 5 || i == 10)
            {
                continue;
            }

            rewardBtn[i - 1].enabled = true;
            rewardBtnTxt[i - 1].text = "可领取";
        }

        //将不可领取的按钮失效并修改文本
        for (int i = 9; i > (sumOfScore - 4000) / 200; i--)
        {
            if (i == 5 || i == 10)
            {
                continue;
            }

            rewardBtn[i - 1].enabled = false;
            rewardBtnTxt[i - 1].text = "未达到段位";
        }

        //更新分数和段位的文本值
        rank = sumOfScore / 1000 - 3;
        rankTxt.text = "RANK: 段位" + rank;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * 控制显示段位和奖励按钮的pnl的显示和隐藏
 */
public class CheckNow : MonoBehaviour
{
    //获取查看段位和奖励的panel
    [SerializeField] private GameObject checkPanel;
    public void OnClick()
    {
        //判断当前panel是否显示，如果显示便将其隐藏，如果隐藏将其显示
        if (checkPanel.activeInHierarchy)
        {
            checkPanel.SetActive(false);
        }
        else
        {
            checkPanel.SetActive(true);
        }
        
    }
}

using UnityEngine;
using System.Collections;

public class RankingListGUI : MonoBehaviour
{
    public Texture RankingListBackground;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnGUI()
    {
        if (Global.PalyStatus == GameStatus.RankingList)
        {
            //背景
            GUI.DrawTexture(PositionHelper.GetFullScreen(), RankingListBackground);
            //分数排行
            GUI.Label(PositionHelper.GetPosition(50, 50, 100, 10), "Ranking List !!!");
            //返回按钮
            if (GUI.Button(PositionHelper.GetPaddingPosition(PositionHelper.GetPosition(100, 100, 40, 10), 0, 5, 5, 0), "Back"))
            {
                Global.PalyStatus = GameStatus.Welcome;
            }
        }
    }
}

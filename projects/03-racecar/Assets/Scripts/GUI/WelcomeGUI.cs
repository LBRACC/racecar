using UnityEngine;
using System.Collections;

public class WelcomeGUI : MonoBehaviour
{

    public Texture BackgroundImage;

    void OnGUI()
    {
        if (Global.PalyStatus == GameStatus.Welcome)
        {
            Background();
            PlayButton();
            RankingListButton();
            SoundToggleButton();

        }
    }

    void Background()
    {
        GUI.DrawTexture(PositionHelper.GetFullScreen(), BackgroundImage);
    }

    void PlayButton()
    {
        if (GUI.Button(PositionHelper.GetPosition(50, 50, 50, 10), new GUIContent("Play")))
        {
            Global.PalyStatus = GameStatus.Playing;
        }
    }

    void RankingListButton()
    {
        if (GUI.Button(PositionHelper.GetPosition(50, 65, 50, 10), "Ranking"))
        {
            Global.PalyStatus = GameStatus.RankingList;
        }
    }

    void SoundToggleButton()
    {
        if (GUI.Button(PositionHelper.GetPosition(50, 80, 50, 10), Global.SoundOpen ? "Close Sound" : "Open Sound"))
        {
            Global.SoundOpen = !Global.SoundOpen;
        }
    }


}

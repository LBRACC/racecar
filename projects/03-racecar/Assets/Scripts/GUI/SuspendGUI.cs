using UnityEngine;
using System.Collections;

public class SuspendGUI : MonoBehaviour
{

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        if (Global.PalyStatus == GameStatus.Playing)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                Global.PalyStatus = GameStatus.Suspend;
                Time.timeScale = 0;
            }
        }
        else if (Global.PalyStatus == GameStatus.Suspend)
        {
            RestartButton();
            SoundToggleButton();
        }
    }

    void RestartButton()
    {
        if (GUI.Button(PositionHelper.GetPosition(50, 50, 50, 10), "Restart"))
        {
            Global.PalyStatus = GameStatus.Playing;
            Time.timeScale = 1;
        }
    }

    void SoundToggleButton()
    {
        if (GUI.Button(PositionHelper.GetPosition(50, 70, 50, 10), Global.SoundOpen ? "Close Sound" : "Open Sound"))
        {
            Global.SoundOpen = !Global.SoundOpen;
        }
    }
}

using UnityEngine;
using System.Collections;

public class CommonGUI : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
	
	void OnGUI ()
	{
        //if (Global.PalyStatus == GameStatus.Welcome || Global.PalyStatus == GameStatus.Suspend) {
        //    SoundToggle ();
        //}
	}
	
	void SoundToggle ()
	{
		var top = 0;
		var left = 0;
		if (Global.PalyStatus == GameStatus.Welcome) {
			top = 60;
			left = 40;				
		}
		
		if (GUI.Button (new Rect (left, top, 20, 10), Global.SoundOpen ? "Close Sound" : "Open Sound")) {
			Global.SoundOpen = !Global.SoundOpen;
		}
	}
	

}

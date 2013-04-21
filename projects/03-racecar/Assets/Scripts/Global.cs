using UnityEngine;
using System.Collections;

public enum GameStatus {
	Welcome,
	Playing,
	Suspend,
	RankingList
}

public static class Global  {

	public static GameStatus PalyStatus = GameStatus.Welcome;
	public static bool SoundOpen = true;
}

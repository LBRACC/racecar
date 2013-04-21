using UnityEngine;
using System.Collections;

/// <summary>
/// 根据相对位置的百分比（0-100）获取屏幕上的实际位置
/// added by Li Bo
/// 2013-4-21
/// </summary>
public static class PositionHelper
{
	
//	private static float _paddingHorizontal = (float)(Screen.width/5);
//	private static float _paddingVertical = (float)(Screen.height/5);
//    
//	public static Rect GetRightBottomRect(int objectWidth, int objectHeight, float padding)
//	{
//		return new Rect(Screen.width-objectWidth - _paddingHorizontal,Screen.height - objectHeight - _paddingVertical,objectWidth,objectHeight);
//	}
//	
//	public static Rect GetLeftBottomRect(int objectWidth, int objectHeight)
//	{
//		return GetPosition(
//		return new Rect(0 + _paddingHorizontal ,Screen.height - objectHeight - _paddingVertical ,objectWidth,objectHeight);
//	}
	
	public static Rect GetPosition (float relativeLeft, float relativeTop, float relativeWidth, float relativeHeight)
	{
		var width = Screen.width * (Valid (relativeWidth) / 100);
		var height = Screen.height * (Valid (relativeHeight) / 100);
		var left = (Screen.width - width) * (Valid (relativeLeft) / 100);
		var top = (Screen.height - height) * (Valid (relativeTop) / 100);
		return new Rect (left, top, width, height);
	}
	
	public static Rect GetPaddingPosition (Rect position, float paddingTop, float paddingRight, float paddingBottom, float paddingLeft)
	{
		var top = position.x;
		if (paddingTop > 0)
			top = top + (Screen.height * (paddingTop / 100));
		else if (paddingBottom > 0)
			top = top - (Screen.height * (paddingTop / 100));
		top = Valid (top);
		
		var left = position.y;
		if (paddingLeft > 0)
			left = left + (Screen.width * (paddingLeft / 100));
		else if (paddingRight > 0)
			left = left - (Screen.width * (paddingLeft / 100));
		left = Valid (left);
		
		return new Rect (left, top, position.width, position.height);
	}
	
	private static float Valid (float positionValue)
	{
		if (positionValue < 0)
			return 0;
		
		if (positionValue > 100)
			return 100;
		
		return positionValue;
	}

	public static Rect GetFullScreen ()
	{
		return new Rect (0, 0, Screen.width, Screen.height);
	}

}

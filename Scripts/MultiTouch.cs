using UnityEngine;
using System.Collections;

public class MultiTouch : MonoBehaviour {

	void OnTouchDown ()
	{
		PlayerControl.lookAtCursor = false;
	}

	void OnTouchUp ()
	{
		PlayerControl.lookAtCursor = true;
	}

	void OnTouchStay ()
	{
		PlayerControl.lookAtCursor = false;
	}

	void OnTouchExit ()
	{
		PlayerControl.lookAtCursor = true;
	}
}

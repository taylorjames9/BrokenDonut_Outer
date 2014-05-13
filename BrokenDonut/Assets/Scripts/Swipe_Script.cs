using UnityEngine;
using System.Collections;

public class Swipe_Script : MonoBehaviour {

	// spin the yellow cube when swipping it
	void OnSwipe( SwipeGesture gesture )
	{
		// make sure we started the swipe gesture on our swipe object
		//   we use the object the swipe started on, instead of the current one
		GameObject selection = gesture.StartSelection;

		if( selection == this.gameObject )
		{

			Debug.Log("Swiped " + gesture.Direction + " with finger " + gesture.Fingers[0] +
				" (velocity:" + gesture.Velocity + ", distance: " + gesture.Move.magnitude + " )");

			transform.Rotate (0, gesture.Move.magnitude,0);
		}
	}
}

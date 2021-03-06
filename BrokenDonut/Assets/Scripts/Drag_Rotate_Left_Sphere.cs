﻿using UnityEngine;
using System.Collections;

public class Drag_Rotate_Left_Sphere : MonoBehaviour {

	//public GameObject dragObject;
		public float rotationRate;

	public static Vector3 leftInnerRotation;
		public static Quaternion myQuaternionRotation;
		public static float myYRotation;
	public	static float gestureYPosition;

	int dragFingerIndex = -1;

	void OnDrag(DragGesture gesture){

		FingerGestures.Finger finger = gesture.Fingers[0];

		if (gesture.Phase == ContinuousGesturePhase.Started) {
			// dismiss this event if we're not interacting with our drag object
			if (gesture.Selection != this.gameObject)
				return;

			dragFingerIndex = finger.Index;

			// spawn some particles because it's cool.
						//SpawnParticles (dragObject);
		}

		else if ( finger.Index == dragFingerIndex ) {
			if( gesture.Phase == ContinuousGesturePhase.Updated )
			{
				// update the position by converting the current screen position of the finger to a world position on the Z = 0 plane

				//Debug.Log ("leftInnterRotation Type == " + leftInnerRotation.GetType ().ToString ());
				this.transform.Rotate (0, gesture.DeltaMove.y, 0, Space.Self);

				print ("dragObject.transform.rotation =" +this.transform.rotation);
				print ("gesture.Position.y = " + gesture.Position.y);

				gestureYPosition = (gesture.Position.y - 400);

			}
			else
			{
				// reset our drag finger index
				dragFingerIndex = -1;

				// spawn some particles because it's cool.
								//SpawnParticles( dragObject );

			}
		}
	}

	// Convert from screen-space coordinates to world-space coordinates on the Z = 0 plane
	public static Vector3 GetWorldPos( Vector2 screenPos )
	{
		Ray ray = Camera.main.ScreenPointToRay( screenPos );

		// we solve for intersection with z = 0 plane
		float t = -ray.origin.z / ray.direction.z;

		return ray.GetPoint( t );
	}



		/*void SpawnParticles( GameObject obj )
	{
		ParticleEmitter emitter = obj.GetComponentInChildren<ParticleEmitter>();
		if( emitter )
			emitter.Emit();
	}*/
}

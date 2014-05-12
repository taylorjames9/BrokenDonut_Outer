using UnityEngine;
using System.Collections;

public class Drag_Rotate_Right_Sphere : MonoBehaviour {

		//public GameObject dragObject;
		public float rotationRate;

		public static Vector3 leftInnerRotation;
		public static Quaternion myQuaternionRotation;
		public static float myYRotation;

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
								////////this.transform.rotation = GetWorldPos( gesture.Position );
								//rotationRate = 3.0f;

								leftInnerRotation = new Vector3 (0, 0, gesture.DeltaMove.y);
								Debug.Log ("leftInnterRotation Type == " + leftInnerRotation.GetType ().ToString ());
								this.transform.Rotate (0,gesture.DeltaMove.y, 0, Space.Self);
								myQuaternionRotation = this.transform.rotation;
								myYRotation = this.transform.rotation.y;

								//dragObject.transform.rotation = GetWorldPos( gesture.Position );
								print ("dragObject.transform.rotation =" +this.transform.rotation);
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

using UnityEngine;
using System.Collections;

public class Pipe_Outer_Rotation : MonoBehaviour {
		public Quaternion myRotation;
		private float myEulerRotation;

		void Update () {

				myEulerRotation = Drag_Rotate_Right_Sphere.myYRotation;
		//this.transform.Rotate (myEulerRotation, myEulerRotation, myEulerRotation);

		if (Drag_Rotate_Right_Sphere.gestureYPosition > 0) {
			this.transform.Rotate (0, 1, 0);
		} else if (Drag_Rotate_Right_Sphere.gestureYPosition < 0) {
			this.transform.Rotate (0, -1, 0);
		}

		}
}
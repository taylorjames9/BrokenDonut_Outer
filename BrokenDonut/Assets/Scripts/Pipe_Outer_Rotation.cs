using UnityEngine;
using System.Collections;

public class Pipe_Outer_Rotation : MonoBehaviour {
		public Quaternion myRotation;
		private float myEulerRotation;


		// Update is called once per frame
		void Update () {

				myEulerRotation = Drag_Rotate_Right_Sphere.myYRotation;
				this.transform.Rotate (0, myEulerRotation, 0);
		}
}
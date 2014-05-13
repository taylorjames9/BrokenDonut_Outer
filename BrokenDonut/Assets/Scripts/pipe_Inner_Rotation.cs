using UnityEngine;
using System.Collections;

public class pipe_Inner_Rotation : MonoBehaviour {

		public Quaternion myRotation;
		private float myEulerRotation;
	public GameObject invisibleSphereLeft;
	private float myOrientation;
	// Use this for initialization
	void Start () {

			
	
	}
	
	// Update is called once per frame
	void Update () {

				myEulerRotation = Drag_Rotate_Left_Sphere.myYRotation;
				myOrientation = invisibleSphereLeft.transform.rotation.y;

		print ("Drag_Rotate_Left_Sphere.gestureYPosition " + Drag_Rotate_Left_Sphere.gestureYPosition);

		if (Drag_Rotate_Left_Sphere.gestureYPosition > 0) {
			this.transform.Rotate (0, 1, 0);
		} else if (Drag_Rotate_Left_Sphere.gestureYPosition < 0) {
			this.transform.Rotate (0, -1, 0);
		}

	}
}

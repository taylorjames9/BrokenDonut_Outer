using UnityEngine;
using System.Collections;

public class pipe_Inner_Rotation : MonoBehaviour {

		public Quaternion myRotation;
		private float myEulerRotation;
	// Use this for initialization
	void Start () {

			
	
	}
	
	// Update is called once per frame
	void Update () {

				/*Debug.Log ("this.transform.rotation == " + this.transform.rotation.GetType ().ToString ());
				myRotation = this.transform.rotation;
				myEulerRotation = myRotation.eulerAngles;

				this.transform.rotation.eulerAngles = myEulerRotation;*/

				//////////////////////this.transform.rotation = Drag_Rotate.myQuaternionRotation;
				/// 
				//myEulerRotation = this.transform.rotation.eulerAngles.y;
				myEulerRotation = Drag_Rotate_Left_Sphere.myYRotation;

				//this.transform.rotation.eulerAngles = new Vector3 (this.transform.rotation.x, this.transform.rotation.y, myEulerRotation);
				//transform.Rotate(Time.deltaTime, 0, 0);
				this.transform.Rotate (0, myEulerRotation, 0);

				//////////////this.transform.rotation = Drag_Rotate.leftInnerRotation;
				//rotation.eulerAngles = Drag_Rotate.leftInnerRotation;
				//this.transform.rotation = rotation;
	}
}

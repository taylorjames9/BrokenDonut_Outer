using UnityEngine;
using System.Collections;

public class Spouse : MonoBehaviour {


	private bool randomImpulse;

	// Use this for initialization
	void Start () {
		rigidbody.AddForce (Random.Range(-15,15),Random.Range(-15,15), 0);
	}
		

	void OnCollisionEnter(Collision otherCol){

		rigidbody.AddForce (Random.Range(-200,200),Random.Range(-200,200), 0);

	}

	void FixedUpdate(){
		if (!randomImpulse) {
			StartCoroutine (RandomImpulse ());
		}
	}

	IEnumerator RandomImpulse(){
		randomImpulse = true;
		yield return new WaitForSeconds (1.0f);
		rigidbody.AddForce (Random.Range(-200,200),Random.Range(-200,200), 0);
		yield return new WaitForSeconds (1.0f);
		randomImpulse = false;

	}
	IEnumerator GateOpen(){
		randomImpulse = true;
		yield return new WaitForSeconds (1.0f);
	}
}

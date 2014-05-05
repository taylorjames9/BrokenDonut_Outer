using UnityEngine;
using System.Collections;

public class Spouse : MonoBehaviour {

	// Use this for initialization
	void Start () {
		rigidbody.AddForce (Random.Range(-5,5),Random.Range(-5,5), 0);
	}
		

	void OnCollisionEnter(Collision otherCol){

		rigidbody.AddForce (Random.Range(-10,10),Random.Range(-10,10), 0);

	}
	/*void OnCollisionStay(Collision otherCol){

		rigidbody.AddForce (Random.Range(5,10),Random.Range(5,10), 0);

	}*/

	void FixedUpdate(){
		StartCoroutine (RandomImpulse ());

	}

	IEnumerator RandomImpulse(){

		rigidbody.AddForce (Random.Range(-5,5),Random.Range(-5,5), 0);
		yield return new WaitForSeconds (3.0f);
	}
}

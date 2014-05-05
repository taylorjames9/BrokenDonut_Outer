using UnityEngine;
using System.Collections;

public class EnemyIndividualRecycle : MonoBehaviour {

	GameObject absoluteCenter;
	public	float enemySpeed;

	// Use this for initialization
	void Start () {
		enemySpeed = Random.Range (1, 2);
		absoluteCenter = GameObject.Find("AbsoluteCenter");
	}
	
	void Update () {

		ChaseTheTarget ();
	}

	void ChaseTheTarget (){
		Vector3 current = new Vector3 (transform.position.x, transform.position.y, 0);
		Vector3 targetPos = new Vector3 (absoluteCenter.transform.position.x, absoluteCenter.transform.position.y, -1.5f);
		float step = enemySpeed * Time.deltaTime;
		this.transform.position = Vector3.MoveTowards (current, targetPos, step);
	}

	void OnCollisionEnter(Collision otherCol){

		this.transform.position = new Vector3(Random.Range(-15,15), Random.Range(-15,15), -1.5f);
	}
}

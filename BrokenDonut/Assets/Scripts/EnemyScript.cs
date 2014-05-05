using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {


		GameObject absoluteCenter;
		public	float enemySpeed;

	// Use this for initialization
	void Start () {
				enemySpeed = Random.Range (1, 2);
				absoluteCenter = GameObject.Find("AbsoluteCenter");
	}
	
	// Update is called once per frame
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
				EnemyManager.numEnemies--;
				Destroy (gameObject);
	}
}

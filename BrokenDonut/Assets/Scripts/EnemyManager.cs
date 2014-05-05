using UnityEngine;
using System.Collections;

public class EnemyManager : MonoBehaviour {

	public GameObject enemy1;
		public static int numEnemies;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


				while (numEnemies < 10) {
						GameObject aNewEnemy = Instantiate(enemy1, new Vector3(Random.Range(-10,10), Random.Range(-10,10), -1.5f), Quaternion.identity) as GameObject;
						numEnemies++;
				}
	}
}

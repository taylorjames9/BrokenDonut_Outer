using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyRedManager: MonoBehaviour {

	public Transform enemyRedPrefab; 
	public int numberOfRedEnemies;

	void Start(){
		for (int i = 0; i < numberOfRedEnemies; i++) {
			Transform o = (Transform)Instantiate(enemyRedPrefab);
			o.localPosition = new Vector3(Random.Range(-10,10), Random.Range(-10,10), -1.5f);
		}
	}
	void Update () {

	}
}

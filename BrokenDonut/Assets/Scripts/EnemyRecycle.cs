using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyRecycle : MonoBehaviour {

	public Transform enemyPrefab; 
	public int numberOfEnemies;

	void Start(){
		for (int i = 0; i < numberOfEnemies; i++) {
			Transform o = (Transform)Instantiate(enemyPrefab);
			o.localPosition = new Vector3(Random.Range(-10,10), Random.Range(-10,10), -1.5f);
		}
	}
	void Update () {

	}
}

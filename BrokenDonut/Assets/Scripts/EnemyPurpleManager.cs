using UnityEngine;
using System.Collections;

public class EnemyPurpleManager : MonoBehaviour {

	public Transform enemyPurplePrefab; 
	public int numberOfPurpleEnemies;

	void Start(){
		for (int i = 0; i < numberOfPurpleEnemies; i++) {
			Transform o = (Transform)Instantiate(enemyPurplePrefab);
			o.localPosition = new Vector3(Random.Range(-10,10), Random.Range(-10,10), -1.5f);
		}
	}
}

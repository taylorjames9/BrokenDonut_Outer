using UnityEngine;
using System.Collections;

public class EnemyBlueManager : MonoBehaviour {

	public Transform enemyBluePrefab; 
	public int numberOfBlueEnemies;

	void Start(){
		for (int i = 0; i < numberOfBlueEnemies; i++) {
			Transform o = (Transform)Instantiate(enemyBluePrefab);
			o.localPosition = new Vector3(Random.Range(-10,10), Random.Range(-10,10), -1.5f);
		}
	}
}

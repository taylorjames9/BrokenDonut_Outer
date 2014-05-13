using UnityEngine;
using System.Collections;

public class EnemyIndividualRecycle : MonoBehaviour {

	GameObject absoluteCenter;
	public	float enemySpeed;

	// Use this for initialization
	void Start () {
		enemySpeed = Random.Range (1, 3);
		absoluteCenter = GameObject.Find("Spouse");
	}
	
	void FixedUpdate () {

		ChaseTheTarget ();
	}

	void ChaseTheTarget (){
		Vector3 current = new Vector3 (transform.position.x, transform.position.y, 0);
		Vector3 targetPos = new Vector3 (absoluteCenter.transform.position.x, absoluteCenter.transform.position.y, -1.5f);
		float step = enemySpeed * Time.deltaTime;
		this.transform.position = Vector3.MoveTowards (current, targetPos, step);
	}

	void OnCollisionEnter(Collision otherCol){

		SpawnParticles();
		this.renderer.enabled = false;
		StartCoroutine (Regenerate ());

	}
	void SpawnParticles()
	{
		ParticleEmitter emitter = this.GetComponentInChildren<ParticleEmitter>();
		if( emitter )
			emitter.Emit();
	}

	IEnumerator Regenerate(){
		enemySpeed = Random.Range (1, 3);
		yield return new WaitForSeconds (1.0f);
		this.transform.position = new Vector3(Random.Range(-15,15), Random.Range(-15,15), -1.5f);
		this.renderer.enabled = true;
		yield return new WaitForSeconds (1.0f);
	}

}

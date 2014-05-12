using UnityEngine;
using System.Collections;

public class NewSpouseScript : MonoBehaviour {


	private Color centerColor;
	public float reddish;
	public float blueish;


	// Use this for initialization
	void Start () {

		reddish = 1.0f;
		blueish = 1.0f;
		//transform.renderer.material.color = Color.white;
		//centerColor = new Color (reddish, 0, blueish, 1.0f);
		this.renderer.material.color =  new Color (reddish, 0, blueish, 1.0f);
	}
	
	// Update is called once per frame
	void Update () {
		//centerColor = Vector3(reddish, 100, blueish);
		//this.renderer.material.color = new Color (reddish, 0, blueish, 255);

	}


	void OnCollisionEnter(Collision otherCol){
		if (otherCol.gameObject.tag == "BlueEnemy") {
			if (reddish >= 0.1f) {
				reddish -= 0.1f;
			}
			else if(blueish < 0.9f){
				blueish += 0.1f;

			}
			print ("Reddish =" + reddish);
			print ("Blueish =" + blueish);
			this.renderer.material.color =  new Color (reddish, 0, blueish, 1.0f);
		}
		else if (otherCol.gameObject.tag == "PurpleGuy") {
			if (reddish <= 0.9f && blueish <= 0.9f) {
				reddish += 0.1f;
				blueish += 0.1f;
			}
			print ("Reddish =" + reddish);
			print ("Blueish =" + blueish);
			this.renderer.material.color =  new Color (reddish, 0, blueish, 1.0f);
		}
		else if(otherCol.gameObject.tag == "RedEnemy") {
			if (blueish >= 0.1f) {
				blueish -= 0.1f;
				print ("Blueish =" + blueish);
			} 
			else if (reddish <= 0.9f) {
				reddish += 0.1f;
			}
			print ("Reddish =" + reddish);
			print ("Blueish =" + blueish);
			this.renderer.material.color =  new Color (reddish, 0, blueish, 1.0f);
			}
	}
}

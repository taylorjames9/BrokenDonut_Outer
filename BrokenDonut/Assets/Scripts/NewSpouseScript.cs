using UnityEngine;
using System.Collections;

public class NewSpouseScript : MonoBehaviour {


	private Color32 centerColor;
	public int reddish;
	public int blueish;


	// Use this for initialization
	void Start () {

		reddish = 255;
		blueish = 255;
		//transform.renderer.material.color = Color.white;
		centerColor = new Color (reddish, 100, blueish, 255);
	}
	
	// Update is called once per frame
	void Update () {
		//centerColor = Vector3(reddish, 100, blueish);
		//this.renderer.material.color = centerColor;

	}


	void OnCollisionEnter(Collision otherCol){
		if (otherCol.gameObject.tag == "BlueEnemy") {
			if (reddish >= 50) {
				reddish -= 50;
				centerColor = new Color(reddish, 100, blueish);
				print ("CenterColor = " + centerColor); 
				print ("Reddish =" + reddish);
			}
		}
		else if (otherCol.gameObject.tag == "PurpleGuy") {
			if (reddish <= 205 && blueish <= 205) {
				reddish += 50;
				blueish += 50;
				centerColor = new Color(reddish, 100, blueish);
				print ("CenterColor = " + centerColor); 

			}
		}
		else if(otherCol.gameObject.tag == "RedEnemy") {
			if (blueish >= 50) {
				blueish -= 50;
				centerColor = new Color (reddish, 100, blueish);
				print ("Blueish =" + blueish);
				print ("CenterColor = " + centerColor); 
			}
		}
	}
}

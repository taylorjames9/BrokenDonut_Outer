using UnityEngine;
using System.Collections;

public class BackToIntroScreen : MonoBehaviour {


	void OnTap(TapGesture gesture) { Application.LoadLevel ("IntroScreen");}

}

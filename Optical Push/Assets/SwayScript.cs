using UnityEngine;
using System.Collections;

public class SwayScript : MonoBehaviour {

	private float alpha = 0f;
	private float amp = .005f;
	private float per = .4f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	//	transform.Rotate(.01f,0,0);

		transform.Rotate(Mathf.Sin(alpha - 45)/50, 0,0);
	//	transform.Translate(new Vector3( Mathf.Cos(alpha * per) * amp, Mathf.Sin(alpha * per) * amp /10, Mathf.Sin(alpha * per) * amp     ));

		alpha += amp;
	}
}

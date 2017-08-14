using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour {

	private Animation _animation;

	// Use this for initialization
	void Start () {
		_animation = GetComponent <Animation>();
	}
	
	// Update is called once per frame
	void Update () {
		if (_animation.isPlaying) {
			transform.Translate (Vector3.forward * Time.deltaTime * (transform.localScale.x * .95f));
		}
	}

	public void Walk(){
		if (!_animation.isPlaying) {
			_animation.Play ();
		} else {
			_animation.Stop ();
		}
	}

	public void LookAt(){
		transform.LookAt (Camera.main.transform.position);
		transform.eulerAngles = new Vector3 (0, transform.eulerAngles.y, 0);
	}

	public void Bigger(){
		transform.localScale += new Vector3 (1, 1, 1);
	}

	public void Smaller(){
		if (transform.localScale.x > 1) {
			transform.localScale -= new Vector3 (1, 1, 1);
		}
	}
}

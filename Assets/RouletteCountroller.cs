using UnityEngine;
using System.Collections;

public class RouletteCountroller : MonoBehaviour {

	float rotSpeed = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			this.rotSpeed = Random.Range (5, 10);
		}
	
		transform.Rotate (0, 0, this.rotSpeed);

		this.rotSpeed *= 0.98f;
	}
}

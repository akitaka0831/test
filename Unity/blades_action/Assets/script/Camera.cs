using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {

	GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");

	}
	
	// Update is called once per frame
	void Update () {
		Vector3 playerPos = player.transform.position;
		transform.position = new Vector3 (playerPos.x, transform.position.y, transform.position.z);
	
	}
}

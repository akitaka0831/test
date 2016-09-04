using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour {

	GameObject timerText;
	float time = 180.0f;

	// Use this for initialization
	void Start () {

		this.timerText = GameObject.Find ("Time");
	
	}
	
	// Update is called once per frame
	void Update () {
	
		this.time -= Time.deltaTime;
		this.timerText.GetComponent<Text>().text =
			this.time.ToString("F1");
				}
}
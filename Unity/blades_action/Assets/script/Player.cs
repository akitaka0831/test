using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float speed = 5f;
	public float jump = 700f;
	private Rigidbody2D rb2d;
	private Animator anim;

	// Use this for initialization
	void Start () {

		rb2d = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
	
	}
	
	// Update is called once per frame
	void Update () {

		//左キー：-1、右キー:1
		float x = Input.GetAxisRaw("Horizontal");
		//左か右を入力したら
		if (x != 0) {
			//入力方向へ移動
			rb2d.velocity = new Vector2 (x * speed, rb2d.velocity.y);
			//移動に合わせて画像を反転する
			Vector2 temp = transform.localScale;
			temp.x = -x;
			transform.localScale = temp;
			//Wait→Walk
			anim.SetBool("Walk",true);
		} else {
			//横移動の速度を0にして止まるようにする
			rb2d.velocity = new Vector2 (0, rb2d.velocity.y);
			//Walk→Wait
			anim.SetBool("Walk",false);
		}
		//スペースを押したらジャンプ
		if (Input.GetKeyDown (KeyCode.Space) &&
			rb2d.velocity.y == 0) {
			rb2d.AddForce (transform.up * jump);
		}
		//右クリックで攻撃
		if (Input.GetMouseButtonDown (0)) {
			anim.SetTrigger ("Attack");

		}

	}
}

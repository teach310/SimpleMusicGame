using UnityEngine;
using System.Collections;

public class NotesScript : MonoBehaviour {

	public int lineNum;
	private GameManager _gameManager;

	void Start(){
		_gameManager = GameObject.Find ("GameManager").GetComponent<GameManager> ();
	}

	void Update () {
		this.transform.position += Vector3.down * 10 * Time.deltaTime;
		if (this.transform.position.y < -5.0f) {
			Debug.Log("false");
			Destroy (this.gameObject);
		}
	}


	void OnTriggerStay(Collider other){
		switch (lineNum) {
		case 0:
			CheckInput (KeyCode.D);
			break;
		case 1:
			CheckInput (KeyCode.F);
			break;
		case 2:
			CheckInput (KeyCode.Space);
			break;
		case 3:
			CheckInput (KeyCode.J);
			break;
		case 4:
			CheckInput (KeyCode.K);
			break;
		default:
			break;
		}
	}

	void CheckInput(KeyCode key){
		if (Input.GetKeyDown (key)) {
			_gameManager.GoodTimingFunc (lineNum);
			Destroy (this.gameObject);
		}
	}
}

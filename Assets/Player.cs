using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public int playerNumber;
	public float playerSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float xMovement = Input.GetAxis ("Player"+playerNumber+"_X");
		float yMovement = Input.GetAxis ("Player"+playerNumber+"_Y") * -1;
		if(xMovement != 0){
			float rotation = xMovement < 0 ? -1 : 1;
			RotateMe (rotation * -90);
			print (rotation);
			transform.Translate (Vector3.up * Time.deltaTime * playerSpeed);
		}else if(yMovement != 0){
			float rotation = yMovement < 0 ? -1 : 1;
			if(rotation == -1){
				RotateMe (rotation * 180);
			}else{
				RotateMe (rotation * 0);
			}
			print (rotation);
			transform.Translate (Vector3.up * Time.deltaTime * playerSpeed);
		}
	}
	
	void RotateMe(float rotation){
		transform.eulerAngles = new Vector3(0, 0, rotation);
	}
}

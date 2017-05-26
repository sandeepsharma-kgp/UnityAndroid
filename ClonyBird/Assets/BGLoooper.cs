using UnityEngine;
using System.Collections;

public class BGLoooper : MonoBehaviour {

	int numBGPanels = 6;

	void OnTriggerEnter2D(Collider2D collider){
		Debug.Log("Triggered: "+ collider.name);
		
		float widthOfBGOject = ((BoxCollider2D)collider).size.x;
		
		Vector3 pos = collider.transform.position;
		
		pos.x += widthOfBGOject * numBGPanels - widthOfBGOject/2f;
		
		collider.transform.position=pos;	
	}
}

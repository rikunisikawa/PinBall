using UnityEngine;
using System.Collections;

public class FripperController : MonoBehaviour {
	private HingeJoint myHingeJoint;

	private float defaultAngle = 20;
	private float flickAngle = -20;


	// Use this for initialization
	void Start () {
		this.myHingeJoint = GetComponent<HingeJoint> ();
		SetAngle (this.defaultAngle);//SetSngleがどこから来たか
	}

	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown (KeyCode.LeftArrow) && tag == "LeftFripperTag") {
		SetAngle (this.flickAngle);
		}
		if (Input.GetKeyDown (KeyCode.RightArrow) && tag == "RightFripperTag") {
		SetAngle (this.flickAngle);
		}

		if (Input.GetKeyUp (KeyCode.LeftArrow) && tag == "LeftFripperTag") {
		SetAngle (this.defaultAngle);
		}
		if (Input.GetKeyUp (KeyCode.RightArrow) && tag == "RightFripperTag") {
		SetAngle (this.defaultAngle);
		}
	}
	public void SetAngle (float angle){//最後に書く意味
		JointSpring jointSpr = this.myHingeJoint.spring;//.がある時とない時
		jointSpr.targetPosition = angle;
		this.myHingeJoint.spring = jointSpr;
	}
}



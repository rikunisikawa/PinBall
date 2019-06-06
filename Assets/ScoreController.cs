using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

	private int addScore;
	private int totalScore;

	private GameObject scoreText;

	// Use this for initialization
	void Start () {
		//スコアテキストを取得
		this.scoreText = GameObject.Find("scoreText");

		if (tag == "SmallStarTag"){this.addScore = 15;
		}else if (tag == "LargeStarTag"){this.addScore = 10;
		}else if (tag == "SmallCloudTag"){this.addScore = 5;
		}else if (tag == "LargeCloudTag"){this.addScore = 2;
		}
	}

	void OnCollisionEnter (Collision other){//
		totalScore += addScore;
		this.scoreText.GetComponent<Text> ().text = totalScore.ToString (); 
		Debug.Log (other.gameObject.tag);
		Debug.Log (totalScore);
	}

	// Update is called once per frame
	//on
	//tag
	//アタッチ

}
////using UnityEngine;
//using System.Collections;
//using UnityEngine.UI;
//
//public class BallController : MonoBehaviour {
//
//	//ボールが見える可能性のあるz軸の最大値
//	private float visiblePosZ = -6.5f;
//
//	//ゲームオーバを表示するテキスト
//	private GameObject gameoverText;
//
//	// Use this for initialization
//	void Start () {
//		//シーン中のGameOverTextオブジェクトを取得
//		this.gameoverText = GameObject.Find("GameOverText");
//	}
//
//	// Update is called once per frame
//	void Update () {
//		//ボールが画面外に出た場合
//		if (this.transform.position.z < this.visiblePosZ) {
//			//GameoverTextにゲームオーバを表示
//			this.gameoverText.GetComponent<Text> ().text = "Game Over";
//		}
//	}
//}
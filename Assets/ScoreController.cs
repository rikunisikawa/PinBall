using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

	private int addScore;
	private TotalScoreController totalScore;

	// Use this for initialization
	void Start () {

		// タグによって光らせる色を変える
		if (tag == "SmallStarTag")
		{
			this.addScore = 15;
		}
		else if (tag == "LargeStaTagr")
		{
			this.addScore = 10;
		}
		else if (tag == "SmallCloudTag")
		{
			this.addScore = 5;
		}
		else if (tag == "LargeCloudTag")
		{
			this.addScore = 2;
		}
		//this.TotalScore = GameObject.Find("TotalScoreText")
		GameObject totalScoreObject = GameObject.Find ("TotalScore");
		totalScore = totalScoreObject.GetComponent<TotalScoreController> ();
	}
	void OnCollisionEnter (Collision other){//
		totalScore.AddScore(addScore);



	}



}
//▼ScoreController
//・totalScoreを削除 済
//・scoreText;を削除　済
//・TotalScoreクラスの変数を用意する
//
//Start関数内で、TotalScoreを取得する
//// TotalScoreを取得する
//GameObject totalScoreObject = GameObject.Find("TotalScore");
//totalScore = totalScoreObject.GetComponent<TotalScore>();
//
//OnCollisionEnter内で、totalScoreのAddScore関数を呼ぶ。引数に、このクラスで定義しているaddScore変数を入れる//}
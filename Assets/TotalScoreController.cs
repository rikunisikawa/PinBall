using System.Collections;
using System.Collections.Generic;
using UnityEngine;//何を使うか
using UnityEngine.UI;

public class TotalScoreController : MonoBehaviour {

	private Text scoreText;
	private int totalScore;
	// Use this for initialization
	void Start () {
		GameObject score = GameObject.Find ("scoreText");
		scoreText = score.GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
			
	}
	public void AddScore (int score){
		totalScore += score;
		scoreText.text = totalScore.ToString ();
    }
}
//新規で、TotalScoreクラスを作成する
//HierarchyにGameObjectを新規でつくって、そこにTotalScoreクラスをアタッチする
//（GameObjectの名前は、極力スクリプトと同じ名前が好ましいです。ここでは、TotalScore）
//
//▼TotalScoreクラス
//スコアテキストの変数を定義して、
//Startで、スコアテキストを取得する
//void Start(){
//	//スコアテキストを取得
//	this.scoreText = GameObject.Find("scoreText");
//}
//
//publicで、AddScore関数をつくる。（totalScoreに加算する関数）
//public void AddScore(int 引数){
//	トータルスコア += 引数;
//	this.scoreText.GetComponent<Text>().text = トータルスコア.ToString();
//}
//

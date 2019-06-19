using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrightnessRegulator : MonoBehaviour {
	Material myMaterial;//よくわからん

	private float minEmission = 0.3f;//最小値
	private float magEmission = 2.0f;//最大値
	private int degree = 0;//角度がわからん
	private int speed = 10;//スピードがわからん

	Color defaultColor = Color.white;//並びの意味
	// Use this for initialization
	void Start () {
		if (tag == "SmallStarTag") {
			this.defaultColor = Color.white;
		} else if (tag == "LargeStarTag") {
			this.defaultColor = Color.yellow;
		} else if (tag == "SmallCloudTag" || tag == "LargeCloudTag"){
			this.defaultColor = Color.cyan;
		}//初期の色

		this.myMaterial = GetComponent<Renderer> ().material;//意味わからんRenderer

		myMaterial.SetColor ("_EmissionColor", this.defaultColor * minEmission); //意味わからん・Materialクラスの「SetColor」関数は、マテリアルの色を設定します。第一引数に変更したい色のパラメータを指定し、第二引数に変更する色の値を指定します。
	}
	
	// Update is called once per frame
	void Update () {

		if (this.degree >= 0){

			Color emissionColor = this.defaultColor * (this.minEmission + Mathf.Sin (this.degree * Mathf.Deg2Rad) * this.magEmission);//Color emissionColorの並び

			myMaterial.SetColor ("_EmissionColor", emissionColor);//意味わからん

			this.degree -= this.speed;//意味わからん
		}
	}
	void OnCollisionEnter(Collision other){ //Colision otherの意味
		this.degree = 180;
	}
}
//角度とスピードの意味は？
//this.myMaterial = GetComponent<Renderer> ().material;
//this.gameoverText.GetComponent<Text> ().text = "Game Over";//ゲームオーバーテキストになんて書くか
//myとは

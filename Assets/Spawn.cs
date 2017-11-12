using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {


	public GameObject sari;
	public GameObject kirmizi;
	public GameObject yesil;
	public GameObject duvar;
	public GameObject bonus_hiz;
	public float minx = 0;
	public float miny=0;
	public float maxx=10;
	public float maxy = 10;

	// Use this for initialization
	void Start () {


		Sarispawnobject ();
		KirmiziSpawnObject ();
		YesilSpawnObject ();
	}



	// Update is called once per frame
	void Update () {

	}

	void Sarispawnobject(){

		for (int i = 1; i < 4; i++) {

			float x = Random.Range (minx, maxx);
			float y = Random.Range (miny,maxy);

			Instantiate (sari, new Vector2 (x, y), Quaternion.identity);

									}
	}

	void KirmiziSpawnObject(){
		for (int i = 1; i < 4; i++) {
			float x = Random.Range (minx, maxx);
			float y = Random.Range (miny,maxy);
			Instantiate (kirmizi, new Vector2 (x, y), Quaternion.identity);

									}

	}

	void YesilSpawnObject(){
		for (int i = 1; i < 4; i++) {
			float x = Random.Range (minx, maxx);
			float y = Random.Range (miny,maxy);
			Instantiate (yesil, new Vector2 (x, y), Quaternion.identity);

		}

	}


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class üretim : MonoBehaviour {


	public GameObject sari;
	public GameObject kirmizi;
	public float minx = 0;
	public float miny=0;
	public float maxx=10;
	public float maxy = 10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void spawnobject(){



		float x = Random.Range (minx, maxx);
		float y = Random.Range (miny,maxy);

//		Instantiate (sari,new Vector3(x,y,0),Quaternion.identity) as GameObject;


	}


}

using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float hiz;
	public GameObject oyuncu;

	void Update()
	{
		var x = Input.GetAxis("Horizontal") * Time.deltaTime * hiz;
		var y = Input.GetAxis("Vertical") * Time.deltaTime * hiz;

		transform.Rotate(0, 0, 0);
		transform.Translate (x, y,0 );




	}





	public void OnCollisionEnter(Collision col){

		if (col.gameObject.tag == "yem") {
			Destroy (col.gameObject);

			oyuncu.gameObject.transform.localScale += new Vector3 (0.1f, 0.1f, 0);
		}

	}

}
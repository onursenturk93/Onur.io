using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
	public float hiz;
	public GameObject oyuncu;
	static public int score=0;
	public Text countText;
	public float ivme;
	public float bonus_hiz;

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

			score = score + 1;
			countText.text = "Skor: " + score.ToString ();
			hiz = hiz - ivme;

		}


		else if (col.gameObject.tag == "hiz_bonus") {

			Destroy (col.gameObject);
			hiz = hiz + bonus_hiz;
		}

	}

}
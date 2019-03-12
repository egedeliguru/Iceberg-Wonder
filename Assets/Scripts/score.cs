using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {

    public Transform player;
    public Text scoreText;
    double scorePoint;

	// Update is called once per frame
	void Update () {
         scorePoint = player.position.z + 286.3;
         scoreText.text = "Score : " + scorePoint.ToString("0");
    }

    private void OnTriggerEnter(Collider other)
    {
        if( other.gameObject.tag == "ring")
        {
            scorePoint *= 2;
        }
    }

}

using UnityEngine;
using UnityEngine.UI;

public class coin : MonoBehaviour {

    private int coinCounter;
    public Transform Player;
    public Text coinText;

	// Use this for initialization
	void Start () {
        coinCounter = 0;
	}
	
	// Update is called once per frame
	void Update () {
        coinText.text = "Coins : " + coinCounter.ToString();
	}

    private void OnTriggerEnter(Collider other)
    {
        if( other.gameObject.tag == "coin")
        {
            other.gameObject.SetActive(false);
            coinCounter++;
        }
        
    }

}

using UnityEngine;
using UnityEngine.UI;

public class scorePoint : MonoBehaviour
{

    public Transform player;
    public Text scoreText;
    private double score;
    private double lastScore;
    private int flag;

    // Use this for initialization
    void Start()
    {
        //score = lastScore;
        Debug.LogWarning("point start");
        score = player.position.z + 288;
        scoreText.text = "Score : " + score.ToString("0");
        lastScore = score;
        flag = 0;
        Debug.LogWarning("score" + score);
        Debug.LogWarning("last score" + lastScore);
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ring")
        {
            Debug.LogWarning("touched ring");
            flag = 1;
        }


    }

    // Update is called once per frame
    void Update()
    {
        if (flag == 1)
        {
            score = score * 2;
            scoreText.text = "Score : " + score.ToString("0");
            lastScore = score;
            flag = 0;
        }
        else
        {
            score = (player.position.z + 288) + lastScore;
            scoreText.text = "Score : " + score.ToString("0");
        }

    }


}

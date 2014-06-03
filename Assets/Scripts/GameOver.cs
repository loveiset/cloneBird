using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {
    public GameManager gmr;
    Animator gameOver;
    public FinalScore finalScore;
    GameObject continueGame;
    GameObject share;
    SpriteRenderer medal;
    [SerializeField]
    Sprite[] medalsToShow;
    

	// Use this for initialization
	void Start () 
    {
        gameOver = this.GetComponent<Animator>();
        Debug.Log(finalScore.GetComponent<FinalScore>());
        continueGame = transform.FindChild("scorepanel/continue").gameObject;
        share = transform.FindChild("scorepanel/share").gameObject;
        medal = transform.FindChild("scorepanel/medal").gameObject.GetComponent<SpriteRenderer>();
	}

    void GameMedal()
    {
        if (gmr.score >= 10 && gmr.score < 19)
        {
            medal.sprite = medalsToShow[0];
        }
        else if (gmr.score >= 20 && gmr.score < 30)
        {
            medal.sprite = medalsToShow[1];
        }
        else if (gmr.score >= 30 && gmr.score < 40)
        {
            medal.sprite = medalsToShow[2];
        }
        else if (gmr.score >= 40)
        {
            medal.sprite = medalsToShow[3];
        }
    }

    void startAnimation()
    {
        finalScore.GetComponent<FinalScore>().enabled = true;
    }
	
	// Update is called once per frame
	void Update () 
    {
        if (gmr.die == true)
        {
            gameOver.SetTrigger("die");
        }
        if (gmr.hasReachedMax)
        {
            GameMedal();
            continueGame.SetActive(true);
            share.SetActive(true);
        }
	}
}

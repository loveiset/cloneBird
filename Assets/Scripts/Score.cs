using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Score : MonoBehaviour {
    public int score = 0;
    public int hisScore = 0;
    List<int> numbersToShow = new List<int>();
    [SerializeField]
    Sprite[] scorePic;
    [SerializeField]
    GameObject[] scorePosition;
    SpriteRenderer[] showSprites = new SpriteRenderer[3];

	// Use this for initialization
	void Start () 
    {
        score = 8;
        for (int i = 0; i < scorePosition.Length; i++)
        {
            showSprites[i] = scorePosition[i].GetComponent<SpriteRenderer>();
            //Debug.Log(scorePosition[i].GetComponent<SpriteRenderer>());
        }
	}

    void AddScore()
    {
        score++;
        if (score >= hisScore)
        {
            hisScore = score;
        }
    }

    void DividedNumber(int number)
    {
        numbersToShow.Clear();
        if (number < 10)
        {
            numbersToShow.Add(number);
        }
        else
        {
            int temp = number;
            while (temp > 0)
            {
                numbersToShow.Insert(0, temp % 10);
                temp /= 10;
            }
        }
    }

    void Reset()
    {
        for (int i = 0; i < showSprites.Length; i++)
        {
            showSprites[i].sprite = null;
        }
    }

    public void ShowScore()
    {
        AddScore();
        Reset();
        DividedNumber(score);
        for (int i = 0; i < numbersToShow.Count; i++)
        {
            showSprites[i].sprite = scorePic[numbersToShow[i]];
            //Debug.Log(scorePic[numbersToShow[i]]);
            //Debug.Log(showSprites[i]);
        }
    }
	
	// Update is called once per frame
	void Update () 
    {
        
	}
}

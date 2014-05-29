using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BestScore : MonoBehaviour {
    public static int hisScore = 0;
    public GameManager gmr;

    List<int> numbersToShow = new List<int>();
    [SerializeField]
    Sprite[] scorePic;
    [SerializeField]
    GameObject[] scorePosition;
    SpriteRenderer[] showSprites = new SpriteRenderer[4];

    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < scorePosition.Length; i++)
        {
            showSprites[i] = scorePosition[i].GetComponent<SpriteRenderer>();
        }
        ShowScore();
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

    public void Reset()
    {
        for (int i = 0; i < showSprites.Length; i++)
        {
            showSprites[i].sprite = null;
        }
    }

    public void ShowScore()
    {
        Reset();
        DividedNumber(hisScore);

        for (int i = 0; i < numbersToShow.Count; i++)
        {
            showSprites[i].sprite = scorePic[numbersToShow[i]];
        }
    }

	// Use this for initialization
	
	// Update is called once per frame
    void Update()
    {

        if (hisScore < gmr.hisScore)
        {

            hisScore = gmr.hisScore;
        }
        if (gmr.hasReachedMax == true)
        {
            ShowScore();
        }

    }
}

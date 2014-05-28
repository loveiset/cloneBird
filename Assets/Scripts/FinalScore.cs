using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FinalScore : MonoBehaviour {
    public Score score;
    int tempNumber = 0;
    double showTimeScale = 0.05f;

    bool hasReachedMax = false;
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
        DividedNumber(tempNumber);

        for (int i = 0; i < numbersToShow.Count; i++)
        {
            showSprites[i].sprite = scorePic[numbersToShow[i]];
        }
    }

    void IncreseNumber( )
    {
        int temp = 0;
        if (score.score <= 9)
        {
            tempNumber++;
        }
        else if(9 < score.score && score.score <= 19)
        {
            tempNumber += Random.Range(1, 3);
        }
        else
        {
            temp = score.score / 10;
            tempNumber += Random.Range(temp - 1, temp + 2);
        }
    }

    // Update is called once per frame
    void Update()
    {
        showTimeScale -= Time.deltaTime;
        if (showTimeScale < 0)
        {
            showTimeScale = 0.05f;

            if (hasReachedMax == false)
            {
                Debug.Log(tempNumber);
                IncreseNumber();
                if (tempNumber >= score.score)
                {
                    hasReachedMax = true;
                    tempNumber = score.score;
                }
                ShowScore();
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {
    int maxnum = 1000;
    int minnum = 1;
    int guess = 500;
	// Use this for initialization
	//test github
    void Start () {
        Debug.Log("Welcome to BUI's number wizard");
        Debug.Log("Please pick a number :) (inyourhead)");
        Debug.Log("The highest number is " + maxnum);
        Debug.Log("The lowest number is " + minnum);
        Debug.Log("Is your number higher or lower than " + guess);
        Debug.Log("Up Arrow = Higher, Down Arrow = Lower, Enter = Correct!");
        maxnum++;
	}
	
    void RestartGame(){
        maxnum = 1000;
        minnum = 1;
        guess = 500;
        Debug.Log("Welcome back to BUI's number wizard");
        Debug.Log("Please pick a number :) (inyourhead)");
        Debug.Log("The highest number is " + maxnum);
        Debug.Log("The lowest number is " + minnum);
        Debug.Log("Is your number higher or lower than " + guess);
        Debug.Log("Up Arrow = Higher, Down Arrow = Lower, Enter = Correct!");
        maxnum++;
    }
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow)){
            minnum = guess;
            guess = (maxnum + minnum) / 2;
            Debug.Log("Is your number " + guess + "?");
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            maxnum = guess;
            guess = (maxnum + minnum) / 2;
            Debug.Log("Is your number " + guess + "?");
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Woohoo!");
            RestartGame();
        }
	}
}

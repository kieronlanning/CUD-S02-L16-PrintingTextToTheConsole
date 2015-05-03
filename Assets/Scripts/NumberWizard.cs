using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour
{
    int _max;
    int _min;
    int _guess;

    // Use this for initialization
    void Start()
    {
        // Otherwise we won't be able to guess 1000.
        StartGame();
    }

    void StartGame()
    {
        _max = 1000;
        _min = 1;
        _guess = 500;

        print("=========================");
        print("Welcome to Number Wizard!");
        print("Pick a number in your head...");

        print("The highest number you can pick is " + _max + "...");
        print("The lowest number you can pick is " + _min + "...");

        print("Is the number higher or lower than " + _guess + "?");
        print("Press UP arrow for higher, DOWN arrow for lower or ENTER for equals...");

        _max ++;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            _min = _guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            _max = _guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("I won!");
            StartGame();
        }
    }

    void NextGuess()
    {
        _guess = (_max + _min)/2;
        print("Is the number higher or lower than " + _guess + "?");

        print("Press UP arrow for higher, DOWN arrow for lower or ENTER for equals...");
    }
}

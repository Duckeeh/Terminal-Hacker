using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{

    // Game state
    int level;
    enum Screen { MainMenu, Password, Win };
    Screen currentScreen;
    string password;

	// Use this for initialization
	void Start ()
    {
        ShowMainMenu();
    }

    void ShowMainMenu()
    {
        currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine("Oh no! It looks like some of the thingsare out of order around Disney World.");
        Terminal.WriteLine("");
        Terminal.WriteLine("Which park would you like to fix?");
        Terminal.WriteLine("Press 1 for Epcot. (Easy)");
        Terminal.WriteLine("Press 2 for Animal Kingdom. (Medium)");
        Terminal.WriteLine("Press 3 for Magic Kingdom. (Hard)");

    }

    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            ShowMainMenu();
        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
        else if (currentScreen == Screen.Password)
        {
            CheckPassword(input);
        }
    }

    void RunMainMenu(string input)
    {
        if (input == "007")
        {
            Terminal.WriteLine("Please select a level, Mr. Bond.");
        }
        else if (input == "1")
        {
            level = 1;
            password = ("Ball");
            StartGame();
        }
        else if (input == "2")
        {
            level = 2;
            password = ("Animal");
            StartGame();
        }
        else if (input == "3")
        {
            level = 3;
            password = ("Mickey");
            StartGame();
        }
        else
        {
            Terminal.WriteLine("Please choose a valid level.");
        }
 
    }

    void StartGame()
    {
        currentScreen = Screen.Password;
        Terminal.WriteLine("You have chosen level " + level);
        Terminal.WriteLine("Please enter the correct password.");
    }

    void CheckPassword(string input)
    {
        if (input == password)
            Terminal.WriteLine("That's correct, great job!");
        else
            Terminal.WriteLine("That's incorrect, try again!");
       
    } 
}




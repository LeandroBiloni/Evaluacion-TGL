using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenNavigator : MonoBehaviour
{
    
    [SerializeField] private Screen _currentScreen;

    private Screen _previousScreen;

    private static ScreenNavigator _instance;
    public static ScreenNavigator Instance
    {
        get
        {
            if (_instance == null)
            {

            }
            return _instance;
        }
    }
    public void OpenScreen(Screen screen)
    {
        if (!screen) return;

        //Saves reference to previous screen
        _previousScreen = _currentScreen;

        //Closes the previous screen
        CloseScreen(_previousScreen);

        _currentScreen = screen;

        Debug.Log("Current Screen: " + gameObject.name);

        //Opens the new screen
        screen.Open();
    }

    public void CloseScreen(Screen screen)
    {
        if (!screen) return;

        screen.Close();
    }

    public void OpenPreviousScreen()
    {
        OpenScreen(_previousScreen);
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuAndButtonScripts : MonoBehaviour
{
    #region //AnaMenuden Oyuna giri� 
    public void AnaMenudenOyunaGiris()
    {
        SceneManager.LoadScene("GameLevel");
    }
    #endregion

    #region //OyundanAnaMenuyeGiris
    public void oyundanAneMenuyeGiris()
    {
        SceneManager.LoadScene("mainMenuAlertButtonScenes");
    }
    #endregion

    #region //Uyar�PaneliEvetButonScripti
    public void UyariEvetButonScript()
    {
        SceneManager.LoadScene("Home");
    }
    #endregion

    #region //Uyar�PaneliHay�rButonScript
    public void UyariHayirButonScript()
    {
        SceneManager.LoadScene("GameLevel");
    }
    #endregion

    #region // ��k��Kodu

    public void exitGameScenes()
    {
        SceneManager.LoadScene("homeExitAlertButtonScenes");
    }
    #endregion

    #region
    public void ExitAletNoButton()
    {
        SceneManager.LoadScene("Home");
    }
    #endregion

    #region
    public void ExitAlertYesButton()
    {
        Application.Quit();
    }
    public void tryAginScenes()
    {

        SceneManager.LoadScene("GameLevel");
        SceneManager.LoadScene("Home");

    }
    #endregion

}



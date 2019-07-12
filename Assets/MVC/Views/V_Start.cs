using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class V_Start : MonoBehaviour
{
    #region serialize_private_fields
    [SerializeField]
    GameObject LoadingText;
    [SerializeField]
    GameObject StartButton;
    [SerializeField]
    C_Start startController;
    #endregion

    #region public_functions
    public void ShowStartButton()
    {
        LoadingText.SetActive(false);
        StartButton.SetActive(true);
    }
    public void OnStartButtonPressed()
    {
        startController.MoveToGameScene();
    }
    #endregion

}

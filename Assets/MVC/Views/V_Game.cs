using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class V_Game : MonoBehaviour {
    [SerializeField]
    Text pointsText;
    [SerializeField]
    C_Game gameController;
    [SerializeField]
    GameObject endGamePanel;
    [SerializeField]
    Text endGamePoints;
	
	public void UpdatePoints(int newP)
    {
        pointsText.text = newP.ToString();
    }
    public void OnGameEnd()
    {
        endGamePoints.text = pointsText.text;
        endGamePanel.SetActive(true);
    }
    public void OnExitGamePressed()
    {
        gameController.ExitGame();
    }
}

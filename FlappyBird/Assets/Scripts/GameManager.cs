using UnityEngine;

public class GameManager : MonoBehaviour
{
  private int score;

public void GameOver(){
    Debug.Log("GameOver");
}


public void IncreaseScroe(){
      score++;
  }
}

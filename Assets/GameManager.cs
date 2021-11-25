using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameOverScreen GameOverScreen;
    // Start is called before the first frame update
    public void GameOver(){
      GameOverScreen.Setup();
    }
}

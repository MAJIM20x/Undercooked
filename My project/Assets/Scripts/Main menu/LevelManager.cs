using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
   public void MenuControl()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
  }
  public void MainMenuControl()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
  }
  public void MainMenuSettings()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
  }public void MenuSettings()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
  }
}

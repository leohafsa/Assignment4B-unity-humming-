using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuController : MonoBehaviour
{
   public void playPenguin()
    {
        SceneManager.LoadScene("Penguins");
    }
    public void playHummingbird()
    {
        SceneManager.LoadScene("FlowerIsland");
    }
}

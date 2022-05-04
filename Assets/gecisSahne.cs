using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gecisSahne : MonoBehaviour
{
    public void sahneGecis(string a)
    {
        SceneManager.LoadScene(a);
    }
}

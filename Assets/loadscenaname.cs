using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadscenaname : MonoBehaviour
{
    public class loadscenaname : MonoBehaviour
    {
        public void loadScenaWithName(string scenaName)
        {
            SceneManager.LoadScene(scenaName);
        }
    }
}

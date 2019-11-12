using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class F : MonoBehaviour
{
    public Dropdown myDropdown;
    public void Update()
    {
        switch (myDropdown.value)
        {
            case 1:

                SceneManager.LoadScene("F_B");

                break;
            case 2:

                SceneManager.LoadScene("F_A");

                break;
            case 3:

                SceneManager.LoadScene("F_G");

                break;
            case 4:

                SceneManager.LoadScene("F_TechPark");

                break;
            
        }
    }
}


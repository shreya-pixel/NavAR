using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class A : MonoBehaviour
{
    public Dropdown myDropdown;
    public void Update()
    {
        switch (myDropdown.value)
        {
            case 1:

                SceneManager.LoadScene("A_B");

                break;
            case 2:

                SceneManager.LoadScene("A_F");

                break;
            case 3:

                SceneManager.LoadScene("A_G");

                break;
            case 4:

                SceneManager.LoadScene("A_TechPark");

                break;
            
        }
    }
}


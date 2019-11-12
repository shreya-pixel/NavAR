using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class B : MonoBehaviour
{
    public Dropdown myDropdown;
    public void Update()
    {
        switch (myDropdown.value)
        {
            case 1:

                SceneManager.LoadScene("B_A");

                break;
            case 2:

                SceneManager.LoadScene("B_F");

                break;
            case 3:

                SceneManager.LoadScene("B_G");

                break;
            case 4:

                SceneManager.LoadScene("B_TechPark");

                break;
            
        }
    }
}


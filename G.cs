using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class G : MonoBehaviour
{
    public Dropdown myDropdown;
    public void Update()
    {
        switch (myDropdown.value)
        {
            case 1:

                SceneManager.LoadScene("G_B");

                break;
            case 2:

                SceneManager.LoadScene("G_F");

                break;
            case 3:

                SceneManager.LoadScene("G_A");

                break;
            case 4:

                SceneManager.LoadScene("G_TechPark");

                break;
            
        }
    }
}


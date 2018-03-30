using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour 
{
    public GameObject Character;
    //public GameObject Enemy;
    public GameObject camera1;
    public GameObject camera2;
	//public GameObject MainMenu_Restart;
    public GameObject GameUI;
    public GameObject MainMenu;
    public GameObject RestartMenu;
    public const int maxHealth = 100;
    public int currentHealth = maxHealth;

    public Text LevenText;

    

    

    




    void Update ()
    {
        {
            LevenText.text = "LEVEN: " + currentHealth;
        }

        if (currentHealth <= 0)
        {
            Debug.Log("DOOD");

            camera1.SetActive(true);
            camera2.SetActive(false); 

            GameUI.SetActive(false);
            MainMenu.SetActive(false);
            RestartMenu.SetActive(true);

            Vector3 pos3 = new Vector3(1, 15, 1);
            Character.transform.position = pos3;

            currentHealth = 100;

            


            

            
		    
            
        {

    }
 
            
    }
    }

    public void TakeDamage(int amount)
    {

        currentHealth -= amount;

    }
    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "Enemy")
        {
            //Debug.Log("-10");
            currentHealth -= 10;
            //Debug.Log(currentHealth);
        }
    }

}

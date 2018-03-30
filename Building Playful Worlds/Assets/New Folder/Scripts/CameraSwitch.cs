using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
 public class CameraSwitch : MonoBehaviour {
     public GameObject camera1;
     public GameObject camera2;
	 public GameObject GameUI;
	 public GameObject MainMenu;
	 public GameObject RestartMenu;

	 public GameObject WinScreen;
	 
	 //public GameObject MainMenu_Restart;

	 public GameObject Character;
	 public RespawnEnemy EnemySpawn;



	

	 


	 
    void Start() {
		 Debug.Log("HELLO WORLD");

         camera1.SetActive(true);
         camera2.SetActive(false); 

		 WinScreen.SetActive(false);
		 GameUI.SetActive(false);
		 RestartMenu.SetActive(false);
		 MainMenu.SetActive(true);



		 

     }

	void OnCollisionEnter(Collision col) {

		if (col.gameObject.name == "EndPoint")
        {
            Debug.Log("YOU WON");

			camera1.SetActive(true);
        	camera2.SetActive(false);


			WinScreen.SetActive(true);
			GameUI.SetActive(false);
			RestartMenu.SetActive(false);
			MainMenu.SetActive(false);

            
 
            
        }
		
	}

	public void OnStartGame()
	 {
		camera1.SetActive(false);
        camera2.SetActive(true);



		GameUI.SetActive(true);
		RestartMenu.SetActive(false);
		MainMenu.SetActive(false);
		WinScreen.SetActive(false);
		Debug.Log("STARTED!");





		if(GameObject.Find(Character.name) != null)
		{
			

			Vector3 pos3 = new Vector3(1, 15, 1);

     		Debug.Log ("Exists");
			Character.transform.position = pos3;

			//EnemySpawn.RespawnCube2();


  		}


		//else
}





		

	 
 
 }
 
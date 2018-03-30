using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
 public class CameraSwitch : MonoBehaviour {
     public GameObject camera1;
     public GameObject camera2;
	 public GameObject GameUI;
	 public GameObject MainMenu;
	 public GameObject RestartMenu;
	 
	 //public GameObject MainMenu_Restart;

	 public GameObject Character;
	 public RespawnEnemy EnemySpawn;



	

	 


	 
    void Start() {
		 Debug.Log("HELLO WORLD");

         camera1.SetActive(true);
         camera2.SetActive(false); 

		 GameUI.SetActive(false);
		 RestartMenu.SetActive(false);
		 MainMenu.SetActive(true);



		 

     }

	public void OnStartGame()
	 {
		camera1.SetActive(false);
        camera2.SetActive(true);



		GameUI.SetActive(true);
		RestartMenu.SetActive(false);
		MainMenu.SetActive(false);
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
 
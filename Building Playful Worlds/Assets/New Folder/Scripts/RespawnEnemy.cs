using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RespawnEnemy : MonoBehaviour {

    public GameObject Enemy;
    //public GameObject Enemy;
    public Vector3 center;
    public Vector3 size;
    public int score;
    public int PlusScore;
    public Text ScoreText;
    private GameObject[] Enemies;
	private int EnemiesMinEen;

    private float nextActionTime = 10.0f;
    public float period = 0.1f;

    void Start()
    {
        //Debug.Log("Start");
        UpdateScore();
        //Debug.Log(score);

        InvokeRepeating("RespawnCube", 10.0f, 5.0f);

   

        //RespawnCube();

         // execute block of code here
     //   }
    }








    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "GameObject_Bullet(Clone)")
        {
            Debug.Log("Hit");
            
            AddScore();
            //Debug.Log(score);
            
            RespawnCube();
            Destroy(Enemy);
            
        }

        if (col.gameObject.name == "RigidBodyFPSController ")
        {
            RespawnCube();
            Destroy(Enemy);
        }
    }
// 
    public void RespawnCube()
    {
        //Debug.Log("Respawn");

        
        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2),center.y,Random.Range(-size.z / 2, size.z / 2));
        //Vector3 pos2 = center + new Vector3(Random.Range(-size.x / 2, size.x / 2),center.y,Random.Range(-size.z / 2, size.z / 2));

        


        GameObject newEnemy = (GameObject)Instantiate(Enemy, pos, Quaternion.identity); 
        
        newEnemy.name = Enemy.name;

        //GameObject newEnemy2 = (GameObject)Instantiate(Enemy, pos2, Quaternion.identity); 

        //newEnemy2.name = Enemy.name;

    }

        public void RespawnCube2()
    {
        Debug.Log("RespawnCube2");
        Enemies = GameObject.FindGameObjectsWithTag("Enemy");
		Debug.Log (Enemies.Length);

		//EnemiesMinEen = (Enemies.Length - 1);

		//Debug.Log (EnemiesMinEen);


        foreach (GameObject target in Enemies) 
		{
        	GameObject.Destroy(target);
    	}

        
        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2),size.y/2,Random.Range(-size.z / 2, size.z / 2));
        Vector3 pos2 = center + new Vector3(Random.Range(-size.x / 2, size.x / 2),size.y/2,Random.Range(-size.z / 2, size.z / 2));

        


        GameObject newEnemy = (GameObject)Instantiate(Enemy, pos, Quaternion.identity); 
        
        newEnemy.name = Enemy.name;

        GameObject newEnemy2 = (GameObject)Instantiate(Enemy, pos2, Quaternion.identity); 

        newEnemy2.name = Enemy.name;

    }

    public void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 100, 0.5f);
        Gizmos.DrawCube(center, size);
    }

	public void AddScore ()
    {
        score += PlusScore;
        UpdateScore();
    }
    void UpdateScore ()
    {
        ScoreText.text = "SCORE: " + (score);
	}
}

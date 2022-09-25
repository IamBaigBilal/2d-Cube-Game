using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Enemyspawner : MonoBehaviour
{
    

    public GameObject[] Enemies;
    public float spawnwait;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

   public IEnumerator SpawnEnemies()
    {
        yield return null;
        while(true)
        {
            int rand = Random.Range(0, Enemies.Length);
            Instantiate(Enemies[rand], this.transform.position, Quaternion.identity);
            yield return new WaitForSeconds(spawnwait);
        }
    }   
    
    public void ReloadScene()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

   
}

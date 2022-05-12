using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour

{
    public GameObject enemigo;
    public GameObject cofre;
    public Vector3 spawnValues;
    public int hazardCount;
    public int cofrescount;
    public float spawnWait;
    public float startWait;
    public float waveWait;

    private int score;
    public Text scoreText;
    string nameplayer;
    private void OnEnable()
    {
        nameplayer = PlayerPrefs.GetString("name");
    }
    // Start is called before the first frame update
    void Start()   
    {
        score = 0;
        UpdateScore();
        StartCoroutine(SpawnWaves());
    }

    // Update is called once per frame
    private IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);

        while (true)
        {

            for (int i = 0; i < hazardCount; i++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Instantiate(enemigo, spawnPosition, Quaternion.identity);
                yield return new WaitForSeconds(spawnWait);

            }

            for (int i = 0; i < cofrescount; i++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Instantiate(cofre, spawnPosition, Quaternion.identity);
                yield return new WaitForSeconds(spawnWait);

            }


            yield return new WaitForSeconds(waveWait);
        
        }
        
    }

    public void AddScore (int value)

    {
        score += value;
        UpdateScore();

    }

    public void UpdateScore()
    {

        scoreText.text = nameplayer + " Puntuacion: " + score;
    }
}

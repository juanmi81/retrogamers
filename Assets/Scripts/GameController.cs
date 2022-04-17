using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour

{
    public GameObject enemigo;
    public Vector3 spawnValues;
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;

    // Start is called before the first frame update
    void Start()   
    {
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
            yield return new WaitForSeconds(waveWait);
        
        }
        
    }
}

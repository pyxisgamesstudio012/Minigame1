using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{

    public GameObject BoxBreakable;
    public GameObject BoxUnbreakable;
    public GameObject Enemy;

    public int quantityMaxUnbreakableBoxes = 0;
    public int quantityMaxBreakableBoxes = 0;
    public int quantityMaxEnemies = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    private void Awake()
    {
        for (int x=1; x< quantityMaxUnbreakableBoxes; x++)
        {
            GameObject box = Instantiate(this.BoxBreakable);
            box.SetActive(true);
            box.GetComponent<Transform>().position = getNewLocation(-15, 15);
        }

        for (int x = 1; x < quantityMaxBreakableBoxes; x++)
        {
            GameObject box = Instantiate(this.BoxUnbreakable);
            box.SetActive(true);
            box.GetComponent<Transform>().position = getNewLocation(-15, 15);
        }

        for (int x = 1; x < quantityMaxEnemies; x++)
        {
            GameObject enemy = Instantiate(this.Enemy);
            enemy.SetActive(true);
            enemy.GetComponent<Transform>().position = getNewLocation(-15, 15);
        }

    }

    private Vector3 getNewLocation(int min, int max)
    {
        return new Vector3(Random.Range(min, max), 1, Random.Range(min, max));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

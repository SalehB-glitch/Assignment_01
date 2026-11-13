using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject[] coinPrefabs;   // the 3 coin types (Orange, Green, Blue)
    public int coinsPerBatch = 5;
    public Vector2 minPosition = new Vector2(-8f, -4f);
    public Vector2 maxPosition = new Vector2(8f, 4f);

    private int coinsLeft;

    void Start()
    {
        SpawnBatch();
    }

    void SpawnBatch()
    {
        for (int i = 0; i < coinsPerBatch; i++)
        {
            int type = Random.Range(0, coinPrefabs.Length);
            float x = Random.Range(minPosition.x, maxPosition.x);
            float y = Random.Range(minPosition.y, maxPosition.y);

            Instantiate(coinPrefabs[type], new Vector3(x, y, 0f), Quaternion.identity);
        }

        coinsLeft = coinsPerBatch;
    }

    public void CoinCollected()
    {
        coinsLeft--;

        if (coinsLeft <= 0)
        {
            SpawnBatch();
        }
    }
}

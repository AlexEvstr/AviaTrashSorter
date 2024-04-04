using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TrashBinSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _trashBins;
    [SerializeField] private GameObject _finish;

    private float _interval;

    private void Start()
    {
        SpawnTrashBin();
    }

    public void SpawnTrashBin()
    {
        int index = 0;
        _interval = 5;

        while (index < 30)
        {
            Vector2 position = new Vector2(_interval, -3);
            _interval += 5;

            GameObject trashBin = Instantiate(_trashBins[Random.Range(0, _trashBins.Length)]);
            trashBin.transform.position = position;

            index++;
        }
        GameObject finish = Instantiate(_finish);
        finish.transform.position = new Vector2(_interval + 1, -4);
    }
}

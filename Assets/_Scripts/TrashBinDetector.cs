using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashBinDetector : MonoBehaviour
{
    [SerializeField] private int _plusScore;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trash"))
        {
            Destroy(collision.gameObject);
            ScoreCounter.Score += _plusScore;
        }
    }
}

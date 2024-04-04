using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBehavior : MonoBehaviour
{
    private bool _canJump = false;
    private float _force = 5.0f;
    public void JumpButton()
    {
        if (_canJump)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector3(0, 700, 0), ForceMode2D.Impulse);
            _canJump = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform") || collision.gameObject.CompareTag("TrashBin"))
        {
            _canJump = true;
        }
        else if (collision.gameObject.CompareTag("Trash"))
        {
            _canJump = true;
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(collision.gameObject.GetComponent<Rigidbody2D>().velocity * _force, ForceMode2D.Force);
        }
    }
}

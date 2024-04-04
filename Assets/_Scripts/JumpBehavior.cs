using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBehavior : MonoBehaviour
{
    private bool _canJump = false;
    public void JumpButton()
    {
        if (_canJump)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector3(0, 7, 0), ForceMode2D.Impulse);
            _canJump = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            _canJump = true;
        }
    }
}

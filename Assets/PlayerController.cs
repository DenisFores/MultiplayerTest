using Photon.Pun;
using UnityEngine;

public class PlayerController : MonoBehaviourPun
{
    public float speed = 5f;

    void Update()
    {
        if (!photonView.IsMine) return;

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(h, 0, v) * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    void Jump()
    {
        transform.Translate(Vector3.up * 2);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public float cameraSpeed = 5.0f;

    public GameObject _player;

    private void Update()
    {
        this.transform.position = new Vector3(_player.transform.position.x, _player.transform.position.y, this.transform.position.z);
    }
}

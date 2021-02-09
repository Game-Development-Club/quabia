using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchAlien : MonoBehaviour
{
    private Rigidbody2D _rigidBody2D;
    private Alien[] _aliens;
    private int _selectedAlien;

    private void Start()
    {
        _rigidBody2D = GetComponent<Rigidbody2D>();

        _aliens = new Alien[] { new HighJumpAlien(), new InvisibleAlien() };
    }

    private void Update()
    {
        var inputVal = Input.GetAxis("spacebar");

        if (inputVal != 1) return;

        _aliens[_selectedAlien].ExecuteAbility(_rigidBody2D);
    }
}

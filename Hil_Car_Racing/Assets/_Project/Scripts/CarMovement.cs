using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Core.Gameplay
{
    public class CarMovement : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D _frontWhaal;

        [SerializeField]private Rigidbody2D _backWhaal;
        [SerializeField] private float _speed = 10f;
      

        private void Update()
        {
            if (Input.GetKey(KeyCode.D) == true) { SetMovement(1); }
            else if (Input.GetKey(KeyCode.A)== true) { SetMovement(-1);}
            else {  SetMovement(0); }
        }
        private void  SetMovement(int direction)
        {
            var movement =Vector2.right * _speed * direction * Time.deltaTime;
            _frontWhaal.velocity += movement;
            _backWhaal.velocity += movement;
        }

    }


}


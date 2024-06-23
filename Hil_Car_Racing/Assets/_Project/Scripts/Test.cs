using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Test : MonoBehaviour
{
    [Inject ]
    [SerializeField] private Sprite _icon;
}

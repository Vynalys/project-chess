using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : MonoBehaviour
{
    GridManager grid;

    int hasMoved = 0;

    [SerializeField] public int x_position;
    [SerializeField] public int y_position;
    void Update() {
        Debug.Log(x_position);
        Debug.Log(y_position);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private Color _baseColor, _offsetColor;
    [SerializeField] private SpriteRenderer _renderer;
    [SerializeField] private GameObject _highlight;


    // selects a color for the tile by a bool value
    public void Init(bool isOffset){
        _renderer.color = isOffset ?_baseColor : _offsetColor;
    }

    // activates the highlight tile
    void OnMouseEnter(){
        _highlight.SetActive(true);
    }

    // deactivates the highlight tile
    void OnMouseExit(){
        _highlight.SetActive(false);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
Class holds the information of a chess piece.
    - Color represents the players color

**/
public class Piece : MonoBehaviour
{

    [SerializeField] SpriteRenderer _renderer;

    /** 
    Sets the color of the renderer. Can be used to color the pieces 
    in a different color.
    **/
    public void SetColor(Color color){
        _renderer.color = color;    
    }


    /**
    Loads the required sprite and adds it to the renderer.
    **/
    public void SetSprite(string pieceName){
        Sprite [] _spArray = Resources.LoadAll<Sprite>("Pieces");

        // piece name like the sprite name -> 1 after the name indicates black
        switch(pieceName){
            case("bishop"): _renderer.sprite = _spArray[0]; break;
            case("bishop1"):_renderer.sprite = _spArray[1]; break;
            case("king"):   _renderer.sprite = _spArray[2]; break;
            case("king1"):  _renderer.sprite = _spArray[3]; break;
            case("knight"): _renderer.sprite = _spArray[4]; break;
            case("knight1"):_renderer.sprite = _spArray[5]; break;
            case("pawn"):   _renderer.sprite = _spArray[6]; break;
            case("pawn1"):  _renderer.sprite = _spArray[7]; break;
            case("queen"):  _renderer.sprite = _spArray[8]; break;
            case("queen1"): _renderer.sprite = _spArray[9]; break;
            case("rook"):   _renderer.sprite = _spArray[10]; break;
            case("rook1"):  _renderer.sprite = _spArray[11]; break;

        }
        
    }

}

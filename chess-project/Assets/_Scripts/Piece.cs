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

    // Variable to store movement of the piece
    // ...
    // Variable to ...
   


    /**
    Loads the required sprite and adds it to the renderer.
    **/
    public Sprite GetSprite(string pieceName){
        Sprite [] _spArray = Resources.LoadAll<Sprite>("Pieces");

        // piece name like the sprite name -> 1 after the name indicates black
        switch(pieceName){
            case("bishop"):  return _spArray[0];
            case("bishop1"): return _spArray[1];
            case("king"):    return _spArray[2];
            case("king1"):   return _spArray[3];
            case("knight"):  return _spArray[4];
            case("knight1"): return _spArray[5];
            case("pawn"):    return _spArray[6];
            case("pawn1"):   return _spArray[7];
            case("queen"):   return _spArray[8];
            case("queen1"):  return _spArray[9];
            case("rook"):    return _spArray[10];
            case("rook1"):   return _spArray[11];

        }
        return null;
        
    }

    public void OnClick(){
        
    }
    

    /** 
    Sets the color of the renderer. Can be used to color the pieces 
    in a different color.
    **/
    public void SetColor(Color color){
        _renderer.color = color;    
    }

}

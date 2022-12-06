using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
Class manages placement of the pieces and selects the correct piece for the start position...!?
**/
public class PieceManager : MonoBehaviour
{

    // Might not be needed
    // [SerializeField] Piece _piecePrefab;
    
    // constant float indicating the scale of the pieces for x and y 
    const private float _pieceScale = 1.5f;  

    public Piece _piece;


    
    /**
    Generates the Pieces on the board by the providing the x and y values of the tile positions provided by x and y.
    Add an SpriteRenderer to add the chess piece sprite by calling the GetSprite function from Piece class.
    **/
    public void PlacePieces(int x, int y){

        // Create the pawn pieces
        if(y == 1 || y == 6){
            // Create an pawn object with the name and at the psoition x and y
            GameObject spawnedPiece = CreatePieceGameObject($"Pawn {x},{y}", x, y);

            // Add a SpriteRenderer to the piece and select the sprite 
            SpriteRenderer _renderer = spawnedPiece.AddComponent<SpriteRenderer>();
            _renderer.sprite = _piece.GetSprite(y == 1 ? "pawn" : "pawn1");
        }


        // Create other pieces that are not pawns 
        if(y == 0 || y == 7){
            if(x == 0 || x == 7){
                    GameObject spawnedPiece = CreatePieceGameObject($"Rook {x},{y}", x, y);

                    SpriteRenderer _renderer = spawnedPiece.AddComponent<SpriteRenderer>();
                    _renderer.sprite = _piece.GetSprite(y == 0 ? "rook" : "rook1");
            }
            else if(x == 1 || x == 6){  
                    GameObject spawnedPiece = CreatePieceGameObject($"Knight {x},{y}", x, y); 
                    
                    SpriteRenderer _renderer = spawnedPiece.AddComponent<SpriteRenderer>();
                    _renderer.sprite = _piece.GetSprite(y == 0 ? "knight" : "knight1");
            }
            else if(x == 2 ||x == 5){
                    GameObject spawnedPiece = CreatePieceGameObject($"Bishop {x},{y}", x, y); 
                    
                    SpriteRenderer _renderer = spawnedPiece.AddComponent<SpriteRenderer>();
                    _renderer.sprite = _piece.GetSprite(y == 0 ? "bishop" : "bishop1");
            }
            else if(x == 3){
                    GameObject spawnedPiece = CreatePieceGameObject($"{x},{y}", x, y); 
                    
                    SpriteRenderer _renderer = spawnedPiece.AddComponent<SpriteRenderer>();
                    _renderer.sprite = _piece.GetSprite(y == 0 ? "king" : "queen1");
            }
            else if(x == 4){
                    GameObject spawnedPiece = CreatePieceGameObject($"{x},{y}", x, y);
                                
                    SpriteRenderer _renderer = spawnedPiece.AddComponent<SpriteRenderer>();
                    _renderer.sprite = _piece.GetSprite(y == 0 ? "queen" : "king1");
            }
            
        }
    }


    /**
    Create an GameObject representing a chess piece  
    **/
    public GameObject CreatePieceGameObject(string name, float x, float y){
        // Create GameObject
        GameObject spawnedPiece = new GameObject(name);
        
        // set the position and the scale of the object
        spawnedPiece.transform.position = new Vector3(x, y, -1);
        spawnedPiece.transform.localScale = new Vector3(_pieceScale, _pieceScale, 1);

        // Add Components
        _piece = spawnedPiece.AddComponent<Piece>();
        spawnedPiece.AddComponent<BoxCollider2D>();
        
        return spawnedPiece;
    }

    void 

}

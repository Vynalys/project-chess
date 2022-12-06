using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
Class manages placement of the pieces and selects the correct piece for the start position...!?
**/
public class PieceManager : MonoBehaviour
{

    [SerializeField] Piece _piecePrefab;

    public Piece _piece;
    
    /**
    Generates the Pieces on the board by the providing the x and y values of the tile positions.

    TODO: Can be done prettier!
    **/
    public void PlacePieces(int x, int y){

        // Create a row of pawns at the for both players...
        if(y == 1 || y == 6){
            Debug.Log(System.String.Format("Tile found: {0},{1}", x, y));

            GameObject spawnedPiece = new GameObject($"Pawn {x},{y}");
            spawnedPiece.transform.position = new Vector3(x, y, -3);
            
            _piece = spawnedPiece.AddComponent<Piece>();
            
            SpriteRenderer _renderer = spawnedPiece.AddComponent<SpriteRenderer>();
            _renderer.sprite = _piece.GetSprite(y == 1 ? "pawn" : "pawn1");
        }







        if(y == 0 || y == 7){
            if(x == 0 || x == 7){
                    GameObject spawnedPiece = new GameObject($"Rook {x},{y}");
                    spawnedPiece.transform.position = new Vector3(x, y, -3);
            
                    _piece = spawnedPiece.AddComponent<Piece>();
            
                    SpriteRenderer _renderer = spawnedPiece.AddComponent<SpriteRenderer>();
                    _renderer.sprite = _piece.GetSprite(y == 0 ? "rook" : "rook1");
            }
            else if(x == 1 || x == 6){  
                    GameObject spawnedPiece = new GameObject($"Knight {x},{y}");
                    spawnedPiece.transform.position = new Vector3(x, y, -3);
            
                    _piece = spawnedPiece.AddComponent<Piece>();
            
                    SpriteRenderer _renderer = spawnedPiece.AddComponent<SpriteRenderer>();
                    _renderer.sprite = _piece.GetSprite(y == 0 ? "knight" : "knight1");
            }
            else if(x == 2 ||x == 5){
                    GameObject spawnedPiece = new GameObject($"Bishop {x},{y}");
                    spawnedPiece.transform.position = new Vector3(x, y, -3);
            
                    _piece = spawnedPiece.AddComponent<Piece>();
            
                    SpriteRenderer _renderer = spawnedPiece.AddComponent<SpriteRenderer>();
                    _renderer.sprite = _piece.GetSprite(y == 0 ? "bishop" : "bishop1");
            }
            else if(x == 3){
                    GameObject spawnedPiece = new GameObject($"{x},{y}");
                    spawnedPiece.transform.position = new Vector3(x, y, -3);
            
                    _piece = spawnedPiece.AddComponent<Piece>();
            
                    SpriteRenderer _renderer = spawnedPiece.AddComponent<SpriteRenderer>();
                    _renderer.sprite = _piece.GetSprite(y == 0 ? "king" : "queen1");
            }
            else if(x == 4){
                    GameObject spawnedPiece = new GameObject($"{x},{y}");
                    spawnedPiece.transform.position = new Vector3(x, y, -3);
            
                    _piece = spawnedPiece.AddComponent<Piece>();
            
                    SpriteRenderer _renderer = spawnedPiece.AddComponent<SpriteRenderer>();
                    _renderer.sprite = _piece.GetSprite(y == 0 ? "queen" : "king1");
            }
            
        }
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
Class manages placement of the pieces and selects the correct piece for the start position...!?
**/
public class PieceManager : MonoBehaviour
{

    [SerializeField] Piece _piecePrefab;
    
    /**
    Generates the Pieces on the board by the providing the x and y values of the tile positions.
    **/
    public void PlacePieces(int x, int y){

        // Create a row of pawns at the for both players...
        if(y == 1 || y == 6){
            Debug.Log(System.String.Format("Tile found: {0},{1}", x, y));
            var spawnedPiece = Instantiate(_piecePrefab, new Vector3(x, y), Quaternion.identity);
            spawnedPiece.name = $"Pawn{y}";
            spawnedPiece.SetSprite(y == 1 ? "pawn" : "pawn1");
        }

        if(y == 0 || y == 7){
            if(x == 0 || x == 7){
                    var spawnedPiece = Instantiate(_piecePrefab, new Vector3(x, y), Quaternion.identity);
                    spawnedPiece.name = $"Rook{y}";
                    spawnedPiece.SetSprite(y == 0 ? "rook" : "rook1");
            }
            else if(x == 1 || x == 6){
                var spawnedPiece = Instantiate(_piecePrefab, new Vector3(x, y), Quaternion.identity);
                    spawnedPiece.name = $"Knight{y}";
                    spawnedPiece.SetSprite(y == 0 ? "knight" : "knight1");
            }
            else if(x == 2 ||x == 5){
                var spawnedPiece = Instantiate(_piecePrefab, new Vector3(x, y), Quaternion.identity);
                    spawnedPiece.name = $"Bishop{y}";
                    spawnedPiece.SetSprite(y == 0 ? "bishop" : "bishop1");
            }
            else if(x == 3){
                var spawnedPiece = Instantiate(_piecePrefab, new Vector3(x, y), Quaternion.identity);
                    spawnedPiece.name = $"{y}";
                    spawnedPiece.SetSprite(y == 0 ? "king" : "queen1");
            }
            else if(x == 4){
                var spawnedPiece = Instantiate(_piecePrefab, new Vector3(x, y), Quaternion.identity);
                    spawnedPiece.name = $"{y}";
                    spawnedPiece.SetSprite(y == 0 ? "queen" : "king1");
            }
            
        }
    }


}

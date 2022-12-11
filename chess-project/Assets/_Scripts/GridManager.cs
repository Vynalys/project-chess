using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GridManager : MonoBehaviour{

 [SerializeField] private int _width, _height;

 [SerializeField] private Tile _tilePrefab;

 [SerializeField] private Transform _cam;

 [SerializeField] private PieceManager _pieceManager;


 private Dictionary<Vector2, Tile> _tiles;




 void Start(){
	Debug.Log("Started Gridmanager...");
	GenerateGrid();

 }

 void GenerateGrid(){
	  _tiles = new Dictionary<Vector2, Tile>();
	  for(int x = 0; x < _width; x++){
			for(int y = 0; y < _height; y++ ){
				// create a tile and nameing it by its position
				var spawnedTile = Instantiate(_tilePrefab, new Vector3(x, y), Quaternion.identity);
				spawnedTile.name = $"Tile {x} {y}";
				

				// select a color for the tile by checking its cordinates
				var isOffset = (x % 2 == 0 && y % 2 != 0) || (x % 2 != 0 && y % 2 == 0);
				spawnedTile.Init(isOffset);

				_tiles[new Vector2(x, y)] = spawnedTile;

				_pieceManager.PlacePieces(x, y);
			}
	  }

	  // set the cameras position, position is on the middle of the grid
	  _cam.transform.position = new Vector3((float)_width/2 - 0.5f, (float)_height/2 - 0.5f, -20);
 }






 public Tile GetTielPosition(Vector2 pos){
	  
	  if(_tiles.TryGetValue(pos, out var _tile)){
		return _tile;
		}

		return null;
 }





}
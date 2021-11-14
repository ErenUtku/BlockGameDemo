using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubes : MonoBehaviour
{
    //[HideInInspector]
    public Vector2Int posIndex;
    [HideInInspector]
    public Board board;
    public Renderer rend;

    private Cubes otherCubes;

    public enum CUBECOLOR{ RED,GREEN }
    public CUBECOLOR color;


    void Start()
    {
        rend = GetComponent<Renderer>();
        board.allCubes[posIndex.x, posIndex.y] = this;
    }

    public void SetupCubes(Vector2Int pos, Board theBoard)
    {
        posIndex = pos;
        board = theBoard;
    }

   
    void Update()
    {

    }
}

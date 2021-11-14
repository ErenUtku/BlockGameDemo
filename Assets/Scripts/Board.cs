using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public int width = 4;
    public int height = 4;

    public GameObject BGCubePrefab;

    public Cubes[] cubes;
    public Cubes[,] allCubes;

    public Border border;
    public Border[,] allBorder;

    void Start()
    {
        allCubes = new Cubes[width, height];
        allBorder = new Border[width, height];
        SetupBoard();
        SetupBorder();
    }  
    
    private void SetupBoard()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                Vector3 pos = new Vector3(x, y);
                GameObject cubeTile = Instantiate(BGCubePrefab, pos + new Vector3(0, 0, 1), Quaternion.identity);
                cubeTile.transform.parent = transform;

                int greenCubeChance = Random.Range(0, 10);
                if (greenCubeChance < 4)
                {
                    SpawnGreenCubes(new Vector2Int(x, y), cubes[0]);
                }
                else
                {
                    SpawnRedCubes(new Vector2Int(x, y), cubes[1]);
                }
            }
        }
    }

    private void SetupBorder()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                if (x == 0)
                {                                  
                    SpawnBorderCubes(new Vector2Int(x-1, y), border);
                }
                if (x == width -1)
                {
                    SpawnBorderCubes(new Vector2Int(x + 1, y), border);
                }
                if (y == 0)
                {
                    SpawnBorderCubes(new Vector2Int(x, y - 1), border);
                }
                if (y == height - 1)
                {                 
                    SpawnBorderCubes(new Vector2Int(x, y + 1), border);
                }
            }
        }
          
    }

    private void SpawnGreenCubes(Vector2Int position, Cubes spawnCubes)
    {
        Cubes _cubes = Instantiate(spawnCubes, new Vector3(position.x, position.y, 0f), Quaternion.identity);

        _cubes.rend.material.color = Color.green;
        _cubes.transform.parent = this.transform;
        _cubes.name = "Cubes = " + position.x + "," + position.y;
        allCubes[position.x, position.y] = _cubes;
        _cubes.SetupCubes(position, this);
    }
    private void SpawnRedCubes(Vector2Int position, Cubes spawnCubes)
    {
        Cubes _cubes = Instantiate(spawnCubes, new Vector3(position.x, position.y, 0f), Quaternion.identity);

        _cubes.rend.material.color = Color.red;
        _cubes.transform.parent = this.transform;
        _cubes.name = "Cubes = " + position.x + "," + position.y;
        allCubes[position.x, position.y] = _cubes;
        _cubes.SetupCubes(position, this);
    }

    private void SpawnBorderCubes(Vector2Int position, Border spawnBorder)
    {
        Border _bordercubes = Instantiate(spawnBorder, new Vector3(position.x, position.y, 0f), Quaternion.identity);
        _bordercubes.transform.parent = this.transform;
        _bordercubes.name = "Cubes = " + position.x + "," + position.y;
        _bordercubes.SetupBorder(position, this);
    }
}

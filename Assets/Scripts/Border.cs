using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    public Vector2Int posIndex;
    [HideInInspector]
    public Board board;

    [Header("Mouse")]
    private Vector2 touchPos;
    private bool mousePressed;

    private Cubes cubes;

    public int getValue;

    public void SetupBorder(Vector2Int pos, Board theBoard)
    {
        posIndex = pos;
        board = theBoard;
    }

    void Update()
    {
        getValue = FindObjectOfType<ButtonUI>().value;
    }

    private void OnMouseDown()
    {
        //LEFT
        if (posIndex.x == -1)
        {
            if (getValue == 0)
            {
                Debug.Log("GET VALUE BLOCK");
            }
            else if (getValue == 2)
            {
                if (board.allCubes[0, posIndex.y].color == Cubes.CUBECOLOR.RED &&
                    board.allCubes[1, posIndex.y].color == Cubes.CUBECOLOR.RED)
                {
                    for (int i = 0; i < getValue; i++)
                    {
                        board.allCubes[i, posIndex.y].rend.material.color = Color.green;
                        board.allCubes[i, posIndex.y].color = Cubes.CUBECOLOR.GREEN;
                    }
                }
            }
            else if (getValue == 3)
            {
                if (board.allCubes[0, posIndex.y].color == Cubes.CUBECOLOR.RED &&
                    board.allCubes[1, posIndex.y].color == Cubes.CUBECOLOR.RED &&
                    board.allCubes[2, posIndex.y].color == Cubes.CUBECOLOR.RED)
                {
                    for (int i = 0; i < getValue; i++)
                    {
                        board.allCubes[i, posIndex.y].rend.material.color = Color.green;
                        board.allCubes[i, posIndex.y].color = Cubes.CUBECOLOR.GREEN;
                    }
                }
            }
            else if (getValue == 4)
            {
                if (board.allCubes[0, posIndex.y].color == Cubes.CUBECOLOR.RED &&
                    board.allCubes[1, posIndex.y].color == Cubes.CUBECOLOR.RED &&
                    board.allCubes[2, posIndex.y].color == Cubes.CUBECOLOR.RED &&
                    board.allCubes[3, posIndex.y].color == Cubes.CUBECOLOR.RED)
                {
                    for (int i = 0; i < getValue; i++)
                    {
                        board.allCubes[i, posIndex.y].rend.material.color = Color.green;
                        board.allCubes[i, posIndex.y].color = Cubes.CUBECOLOR.GREEN;
                    }
                }
            }
        }

        //RIGHT

        if (posIndex.x == board.width)
        {
            if (getValue == 0)
            {
                Debug.Log("GET VALUE BLOCK");
            }
            else if (getValue == 2)
            {
                if (board.allCubes[board.width - 1, posIndex.y].color == Cubes.CUBECOLOR.RED &&
                    board.allCubes[board.width - 2, posIndex.y].color == Cubes.CUBECOLOR.RED)
                {
                    for (int i = board.width; i > board.width - 2; i--)
                    {
                        board.allCubes[i - 1, posIndex.y].rend.material.color = Color.green;
                        board.allCubes[i - 1, posIndex.y].color = Cubes.CUBECOLOR.GREEN;
                    }
                }
            }
            else if (getValue == 3)
            {
                if (board.allCubes[board.width - 1, posIndex.y].color == Cubes.CUBECOLOR.RED &&
                    board.allCubes[board.width - 2, posIndex.y].color == Cubes.CUBECOLOR.RED &&
                    board.allCubes[board.width - 3, posIndex.y].color == Cubes.CUBECOLOR.RED)
                {
                    for (int i = board.width; i > board.width - 3; i--)
                    {
                        board.allCubes[i - 1, posIndex.y].rend.material.color = Color.green;
                        board.allCubes[i - 1, posIndex.y].color = Cubes.CUBECOLOR.GREEN;
                    }
                }
            }
            else if (getValue == 4)
            {
                if (board.allCubes[board.width - 1, posIndex.y].color == Cubes.CUBECOLOR.RED &&
                    board.allCubes[board.width - 2, posIndex.y].color == Cubes.CUBECOLOR.RED &&
                    board.allCubes[board.width - 3, posIndex.y].color == Cubes.CUBECOLOR.RED &&
                    board.allCubes[board.width - 4, posIndex.y].color == Cubes.CUBECOLOR.RED)
                {
                    for (int i = board.width; i > board.width - 4; i--)
                    {
                        board.allCubes[i - 1, posIndex.y].rend.material.color = Color.green;
                        board.allCubes[i - 1, posIndex.y].color = Cubes.CUBECOLOR.GREEN;
                    }
                }
            }
        }

        //TOP
        if (posIndex.y == board.height)
        {
            if (getValue == 0)
            {
                Debug.Log("GET VALUE BLOCK");
            }
            else if (getValue == 2)
            {
                if (board.allCubes[posIndex.x, board.height - 1].color == Cubes.CUBECOLOR.RED &&
                    board.allCubes[posIndex.x, board.height - 2].color == Cubes.CUBECOLOR.RED)
                {
                    for (int i = board.height; i > board.height - 2; i--)
                    {
                        board.allCubes[posIndex.x, i - 1].rend.material.color = Color.green;
                        board.allCubes[posIndex.x, i - 1].color = Cubes.CUBECOLOR.GREEN;
                    }
                }
            }
            else if (getValue == 3)
            {
                if (board.allCubes[posIndex.x, board.height - 1].color == Cubes.CUBECOLOR.RED &&
                    board.allCubes[posIndex.x, board.height - 2].color == Cubes.CUBECOLOR.RED &&
                    board.allCubes[posIndex.x, board.height - 3].color == Cubes.CUBECOLOR.RED)

                {
                    for (int i = board.width; i > board.width - 3; i--)
                    {
                        board.allCubes[posIndex.x, i - 1].rend.material.color = Color.green;
                        board.allCubes[posIndex.x, i - 1].color = Cubes.CUBECOLOR.GREEN;
                    }
                }
            }
            else if (getValue == 4)
            {
                if (board.allCubes[posIndex.x, board.height - 1].color == Cubes.CUBECOLOR.RED &&
                    board.allCubes[posIndex.x, board.height - 2].color == Cubes.CUBECOLOR.RED &&
                    board.allCubes[posIndex.x, board.height - 3].color == Cubes.CUBECOLOR.RED &&
                    board.allCubes[posIndex.x, board.height - 4].color == Cubes.CUBECOLOR.RED)
                {
                    for (int i = board.width; i > board.width - 4; i--)
                    {
                        board.allCubes[posIndex.x, i - 1].rend.material.color = Color.green;
                        board.allCubes[posIndex.x, i - 1].color = Cubes.CUBECOLOR.GREEN;
                    }
                }
            }
        }

        //Bottom
        if (posIndex.y == -1)
        {
            if (getValue == 0)
            {
                Debug.Log("GET VALUE BLOCK");
            }

            else if (getValue == 2)
            {
                if (board.allCubes[posIndex.x, 0].color == Cubes.CUBECOLOR.RED &&
                    board.allCubes[posIndex.x, 1].color == Cubes.CUBECOLOR.RED)
                {
                    for (int i = 0; i < getValue; i++)
                    {
                        board.allCubes[posIndex.x, i].rend.material.color = Color.green;
                        board.allCubes[posIndex.x, i].color = Cubes.CUBECOLOR.GREEN;
                    }
                }
            }
            else if (getValue == 3)
            {
                if (board.allCubes[posIndex.x, 0].color == Cubes.CUBECOLOR.RED &&
                    board.allCubes[posIndex.x, 1].color == Cubes.CUBECOLOR.RED &&
                    board.allCubes[posIndex.x, 2].color == Cubes.CUBECOLOR.RED)
                {
                    for (int i = 0; i < getValue; i++)
                    {
                        board.allCubes[posIndex.x, i].rend.material.color = Color.green;
                        board.allCubes[posIndex.x, i].color = Cubes.CUBECOLOR.GREEN;
                    }
                }
            }
            else if (getValue == 4)
            {
                if (board.allCubes[posIndex.x, 0].color == Cubes.CUBECOLOR.RED &&
                    board.allCubes[posIndex.x, 1].color == Cubes.CUBECOLOR.RED &&
                    board.allCubes[posIndex.x, 2].color == Cubes.CUBECOLOR.RED &&
                    board.allCubes[posIndex.x, 3].color == Cubes.CUBECOLOR.RED)
                {
                    for (int i = 0; i < getValue; i++)
                    {
                        board.allCubes[posIndex.x, i].rend.material.color = Color.green;
                        board.allCubes[posIndex.x, i].color = Cubes.CUBECOLOR.GREEN;
                    }
                }
            }
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
public class ButtonUI : MonoBehaviour
{
    public Board board;
    public Button unit2;
    public Button unit3;
    public Button unit4;

    public int value;

    public Text txtValue;

    UnityEvent m_MyEvent = new UnityEvent();

    void Start()
    {
        value = 0;
        unit2.onClick.AddListener(unit2Clicked);
        unit3.onClick.AddListener(unit3Clicked);
        unit4.onClick.AddListener(unit4Clicked);
    }
    private void Update()
    {
        txtValue.text = value.ToString();
    }

    public void unit2Clicked()
    {
        value = 2;
    }

    public void unit3Clicked()
    {
        value = 3;
    }

    public void unit4Clicked()
    {
        value = 4;
    }

}

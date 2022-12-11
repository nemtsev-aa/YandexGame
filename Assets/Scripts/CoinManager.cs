using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;



public class CoinManager : MonoBehaviour
{
    /// <summary>
    /// ���������� �����, ��������� ���������� �� ������
    /// </summary>
    [SerializeField] int _numberOfCoinInLevel;
    /// <summary>
    /// ��������� ���� ��� ����������� ���������� ��������� �����
    /// </summary>
    [SerializeField] TextMeshProUGUI _text;

    /// <summary>
    /// ���������� �������� �����
    /// </summary>
    public void AddOne()
    {
        _numberOfCoinInLevel += 1;
        //����������� ����� �� ������
        _text.text = _numberOfCoinInLevel.ToString();
    }

}

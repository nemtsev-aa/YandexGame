using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
/// <summary>
/// ��� ����������
/// </summary>
public enum DeformationType
{
    Width,
    Height
}

public class GateAppeareance : MonoBehaviour
{
    /// <summary>
    /// ��������� ���� ��� ����������� �������� �����
    /// </summary>
    [SerializeField] TextMeshProUGUI _text;
    /// <summary>
    /// ����������� ������� ������
    /// </summary>
    [SerializeField] Image _topImage;
    /// <summary>
    /// ����������� ������ 
    /// </summary>
    [SerializeField] Image _glassImage;
    /// <summary>
    /// ���� ���-��������
    /// </summary>
    [SerializeField] Color _colorPositive;
    /// <summary>
    /// ���� �����-��������
    /// </summary>
    [SerializeField] Color _colorNegative;
   
    /// <summary>
    /// ����������� ���� � ������� ������ ����� - "���������� ������"
    /// </summary>
    [SerializeField] GameObject _expandLabel;
    /// <summary>
    /// ����������� ���� � ������� ������ ����� - "���������� ������"
    /// </summary>
    [SerializeField] GameObject _shrinkLabel;
    /// <summary>
    /// ����������� ���� � ������� ������ ����� - "���������� ������"
    /// </summary>
    [SerializeField] GameObject _upLabel;
    /// <summary>
    /// ����������� ���� � ������� ������ ����� - "���������� ������"
    /// </summary>
    [SerializeField] GameObject _downLabel;

    /// <summary>
    ///  ������������� � ��������� �������� ����� � �� ������� ��� ���������� � ������������ � ������������� ��������� 
    /// </summary>
    public void UpdateVisual(DeformationType _deformationType, int _value)
    {
        string pref = "";

        if (_value > 0)
        {
            //����������� ������� ������ "����������" ����
            //(��������� � ������� ������)
            //_topImage.color = _colorPositive;
            //_glassImage.color = new Color(_colorPositive.r, _colorPositive.g, _colorPositive.b, 0.5f);

            //(��������� � ������� ������� � ����������)
            SetColor(_colorPositive);

            pref = "+";
        }
        else if (_value == 0)
        {
            //(��������� � ������� ������)
            //_topImage.color = Color.grey;
            //_glassImage.color = new Color(Color.gray.r, Color.gray.g, Color.gray.b, 0.5f);

            //(��������� � ������� ������� � ����������)
            SetColor(Color.gray);
        }
        else
        {
            //����������� ������� ������ "����������" ����
            //(��������� � ������� ������)
            //_topImage.color = _colorNegative;
            //_glassImage.color = new Color(_colorNegative.r, _colorNegative.g, _colorNegative.b, 0.5f);

            //(��������� � ������� ������� � ����������)
            SetColor(_colorNegative);
        }

        //����� �� �������
        _text.text = pref + _value.ToString();

        //��������� ������������ �������� ������� ������
        _expandLabel.SetActive(false);
        _shrinkLabel.SetActive(false);
        _upLabel.SetActive(false);
        _downLabel.SetActive(false);

        ///���� ������ ��� ���������� "������"
        if (_deformationType == DeformationType.Width)
        {
            //� �������� �� ������� �������������
            if (_value > 0)
            {
                //���������� ������������ �������
                _expandLabel.SetActive(true);
            }
            else
            {
                //���������� ���������� �������
                _shrinkLabel.SetActive(true);
            }
        }
        else
        {
            if (_value > 0)
            {
                //���������� ������� �����
                _upLabel.SetActive(true);
            }
            else
            {
                //���������� ������� ����
                _downLabel.SetActive(true);
            }
        }
    }

    /// <summary>
    /// ��������� ����� �����
    /// </summary>
    /// <param name="color"></param>
    void SetColor(Color color)
    {
        //���� ������� ������
        _topImage.color = new Color(color.r, color.g, color.b, 1f); 
        //���� ������
        _glassImage.color = new Color(color.r, color.g, color.b, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

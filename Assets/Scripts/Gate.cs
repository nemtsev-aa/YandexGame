using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    /// <summary>
    /// ���� �� �������
    /// </summary>
    [SerializeField] int _value;
    /// <summary>
    /// ��� ����������
    /// </summary>
    [SerializeField] DeformationType _deformationType;
    /// <summary>
    /// ����� ���������� ������� ��� �����
    /// </summary>
    [SerializeField] GateAppeareance _gateAppeareance;

    private void OnValidate()
    {
        //�������� ��������� ��������� �������� ���� �����
        _gateAppeareance.UpdateVisual(_deformationType, _value);
    }
}
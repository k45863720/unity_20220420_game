using UnityEngine;

// �R�W�Ŷ� namespace �Ŷ��W�� { �ӪŶ������e }
namespace ��
{
 /// <summary>
 ///  ���a����t��
 ///  �������B�o�g�u�]
 ///  </summary>
}
public class SystemContorl : MonoBehaviour
{
    #region ���
    // GameObject �C������
    // �s�񶥼h���O���Ϊ̱M�פ�������
    // �b�Y
    [Header("�b�Y")]
    public GameObject arrow;
    // ����t��
    [Header("����t��"), Range(0, 500)]
    public float speedTurn = 10.5f;
    //�u�]�w�s��
    [Header("�u�]�w�s��")]
    public GameObject marble;
    //�u�]�i�H�o�g���`��
    [Header("�i�o�g���`��"),Range(0,100)]
    public int canShootMarbleTotal = 15;
    #endregion

    #region �ƥ�

    #endregion

    #region ��k
    /// <summer>
    /// ���ਤ��A �����⭱�۷ƹ���m
    /// </summer>
    private void TrunCharacter()
    {

    }
    /// <summer>
    /// �o�g�u�]�A�ھ��`�Ƶo�g�u�]����
    /// </summer>
    private void ShootMarble()
    {

    }
    /// <summary>
    ///  �^���u�]
    /// </summary>
    private void RecyleMarble()
    {

    }
    #endregion
}

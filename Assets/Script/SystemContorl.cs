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
    [Header("�u�]�ͦ��I")]
    public Transform traSpawnPoint;
    [Header("�����ѼƦW��")]
    public string parAttack = "Ĳ�o����";
    [Header("�u�]�o�g�t��"), Range(0, 5000)]
    public float speedMarble = 1000;
    
    public Animator ani;
    #endregion

    #region �ƥ�
    private void Update()
    {
        ShootMarble();
    }
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
        // ���U �ƹ����� ��� �b�Y
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            arrow.SetActive(true);
        }
        // ��} �ƹ����� ���ýb�Y �ͦ��õo�g�u�]
        else if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            print("��}����!");

            // Objecct ���O�i�ٲ����g
            // �����z�L Objecct �����W�٨ϥ�
            // �ͦ�(�u�]) ;
            // Quaternion.identity �s�ר�
            GameObject tempMarble = Instantiate(marble, traSpawnPoint.position, Quaternion.identity);
            // �Ȧs�u�] ���o���餸�� �K�[���O (�}��.�e�� * �t��)
            // transform.forward �}�⪺�e��
            tempMarble.GetComponent<Rigidbody>().AddForce(transform.forward * 700);
        }
    }
    /// <summary>
    ///  �^���u�]
    /// </summary>
    private void RecyleMarble()
    {

    }
    #endregion
}

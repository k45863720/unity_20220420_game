using UnityEngine;

public class Car : MonoBehaviour
{
    // Start is called before the first frame update


    //���y�k
    //�׹��� ������� ���ۭq�W�� ���w �� �����Ÿ�
    //�׹�����ƪ��s���v��

    //��j�򥻭׹���
    //���}:���\�~���s���A��ܦb�ݩʭ��O
    //public
    //�p�H:�����\�~���s���A����ܦb�ݩʭ��O(�w�]�ȡA�i�ٲ�)
    //private
    //1.Unity �H�ݩʭ��O��Ƭ��D
    //2.�٭��{�������ȥ����� ... > Reset

    //����ݩʻy�k
    //[�ݩʦW��(��)]

    //���� Tooltip
    //���D Header
    //�d�� Range �ȭ���ƻP�B�I��
    //���q
    [Tooltip("�T�������q�A���O��"), Range(1,10)]
    public int weight = 3;
    //����
   [Header("��������"), Range(1,5)]
    public float height = 3.5f;
    //�~�P
    public string brand = "���h";
    //�O�_���ѵ�
    public bool hasskywindow = true;
    private void drivCar()
    {

    }
}


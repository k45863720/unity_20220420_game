using UnityEngine;

/// <summary>
/// ���� (�P�_��)
/// 1. if
/// 2. switch
/// </summary>
public class LearnCondition : MonoBehaviour
{
    public bool openDoor;
    public int combo;
    public string prop;
    // 1.�w�q�C�|���e
    // 2.�w�q���

    // �C�|�y�k:
    // �׹��� �C�| �C�|�W�� { �C�|���e }
    public enum StatePlayer
    {
        Idle, Walk, Run, Hurt, Attack, Dead
    }
    // �w�q���
    // �׹��� �C�|�W�� ���W��;
    public StatePlayer statePlayer;
    private void Start()
    {
        #region  if �P�_��
        // if �y�k :
        // if (���L��) { ���L�ȵ��� true �|����}
        if (true)
        {
            print("�ڦb�P�_�� if ��");
        }


    }
    private void Update()
    {
        // �p�G openDoor ���� true �N�}�� �A �_�h�N����
        // �p�G
        // if �y�k:
        // if (���L��) { ���L�ȵ��� true �|����}
        //�_�h
        // else { ���L�ȵ��� false �|���� }
        if (openDoor)
        {
            print("�}��");
        }
        else
        {
            print("����");
        }
        // else if () {}
        //�L���ƶq
        // �s���� < 100 �����O + 0%
        //�s���� >= 100 �����O + 10%
        //�s���� >= 200 �����O + 20%
        if (combo < 100)
            print("�����O + 0%");
        else if (combo >= 200)
        {
            print("�����O + 20%");
        }
        else if (combo >= 100)
        {
            print("�����O + 10%");
        }
        #endregion
        #region �P�_�� switch
        // switch �y�k:
        // switch (������B�⦡)
        // {
        //      case ��:
        //      �{�����e
        //      break;
        //}

        switch (prop)
        {
            case "�����Ĥ�":
                print("�ɦ�");
                break;

            case "�Ŧ��Ĥ�":
                print("���]");
                break;

            case "�����Ĥ�":
                print("�ɭ@�O");
                break;
            // �i�ٲ�
            default:
                print("�S�����D��~");
                break;
                #endregion

        }
        //1. switch +  Tab * 2
        //2. ��J�C�|�W�� statePlayer
        //3. Enter

        switch (statePlayer)
        {
            case StatePlayer.Idle:
                print("����");
                break;
            case StatePlayer.Walk:
                print("����");
                break;
            case StatePlayer.Run:
                print("�]�B");
                break;
            case StatePlayer.Hurt:
                print("����");
                break;
            case StatePlayer.Attack:
                print("����");
                break;
            case StatePlayer.Dead:
                print("���`");
                break;
            default:

                break;
        }
    }
}
    

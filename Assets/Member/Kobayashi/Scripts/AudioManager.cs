using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>
///BGM��SE�̊Ǘ�������}�l�[�W���[
///</summary>
///
[System.Serializable]
public class Sound
{
    private AudioSource source;
    //=================================================================================
    //�I�[�f�B�I�ڍ�
    //=================================================================================
    public string Name;     //�I�[�f�B�I�̖��O
    public AudioClip Clip;  //�I�[�f�B�I�ۊ�
    [Range(0f, 1f)] public float Volume = 0.7f; //�I�[�f�B�I�̃{�����[��
    [Range(0f, 1.5f)] public float Pitch = 1f;  //�I�[�f�B�I�̃s�b�`

    [Range(0f, 0.5f)] public float RandomVolume = 0.1f;
    [Range(0f, 0.5f)] public float RandomPicth = 0.1f;

    public bool loop = false;   //���[�v�̃`�F�b�N

    public void SetSource(AudioSource _source)
    {
        source = _source;
        source.clip = Clip;
        source.loop = loop;
    }

    public void Play()  //�v���C���\�b�h
    {
        source.volume = Volume * (1 + Random.Range(-RandomVolume / 2f, RandomVolume / 2f)); //�����_���Ń{�����[����ς���
        source.pitch = Pitch * (1 + Random.Range(-RandomPicth / 2f, RandomPicth / 2f));     //�����_���Ńs�b�`��ς���
        source.Play();
    }
    public void Stop() //�X�g�b�v���\�b�h
    {
        source.Stop();
    }
}
public class AudioManager : MonoBehaviour
{

    public static AudioManager instance;

    [SerializeField] Sound[] sounds;
    //=================================================================================
    //������
    //=================================================================================

    void Awake()
    {
        if (instance != null)
        {
            if (instance != this)
            {
                Destroy(this.gameObject);
            }
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
    }

    void Start()
    {
        //�Z�b�g�T�E���h�ɂЂƂ��i�[
        for (int i = 0; i < sounds.Length; i++)
        {
            GameObject _go = new GameObject("Sound_" + i + "_" + sounds[i].Name);
            sounds[i].SetSource(_go.AddComponent<AudioSource>());
        }
    }
    public void PlaySound(string _Name)     //�v���C�T�E���h���\�b�h
    {
        for (int i = 0; i < sounds.Length; i++)
        {
            if (sounds[i].Name == _Name)
            {
                sounds[i].Play();   //�I�񂾋Ȃ��������ꍇ
                return;
            }
            else
            {
                Debug.Log(_Name + "������܂���");//�Ȃ������ꍇ
            }
        }

    }
    public void StopSound(string _Name)     //�X�g�b�v�T�E���h���\�b�h
    {
        for (int i = 0; i < sounds.Length; i++)
        {
            if (sounds[i].Name == _Name)
            {
                sounds[i].Stop();   //�I�񂾋Ȃ��������ꍇ
                return;
            }
            else
            {
                Debug.Log(_Name + "������܂���");//�Ȃ������ꍇ
            }
        }

    }
}
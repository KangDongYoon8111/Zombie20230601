using UnityEngine;
using UnityEngine.SceneManagement; // �� ������ ���� �ڵ�
using UnityEngine.UI; // UI ���� �ڵ�

// �ʿ��� UI�� ��� �����ϰ� ������ �� �ֵ��� ����ϴ� UI �Ŵ���
// 1. �ܺο� UI ��ҵ鰣�� ������
// 2. UI ��ҵ��� ���氪���� ����� ����
public class UIManager : MonoBehaviour
{
    // �̱��� ���ٿ� ������Ƽ
    public static UIManager instance
    {
        get
        {
            if(m_instance == null)
            {
                m_instance = FindObjectOfType<UIManager>();
            }
            return m_instance;
        }
    }

    private static UIManager m_instance; // �̱����� �Ҵ�� ����

    public Text ammoText; // ź�� ǥ�ÿ� �ؽ�Ʈ
    public Text scoreText; // ���� ǥ�ÿ� �ؽ�Ʈ
    public Text waveText; // �� ���̺� ǥ�ÿ� �ؽ�Ʈ
    public GameObject gameoverUI; // ���ӿ��� �� Ȱ��ȭ�� UI

    // ź�� �ؽ�Ʈ ����
    public void UpdateAmmoText(int magAmmo, int remainAmmo)
    {
        ammoText.text = magAmmo + "/" + remainAmmo;
    }

    // ���� �ؽ�Ʈ ����
    public void UpdateScoreText(int newScore)
    {
        scoreText.text = "Score : " + newScore;
    }

    // �� ���̺� �ؽ�Ʈ ����
    public void UpdateWaveText(int waves, int count)
    {
        waveText.text = "Wave : " + waves + "\nEnemy Left : " + count;
    }

    // ���ӿ��� UI Ȱ��ȭ
    public void SetActiveGameoverUI(bool active)
    {
        gameoverUI.SetActive(active);
    }

    // ���� �����
    public void GameRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

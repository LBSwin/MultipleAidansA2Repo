using UnityEngine;

public class AU06_Visualiser : MonoBehaviour
{
    public GameObject barPrefab;
    public int numBars = 64;
    public float radius = 5f;
    public AudioSource audioSource;
    private GameObject[] bars;

    void Start()
    {
        bars = new GameObject[numBars];

        for (int i = 0; i < numBars; i++)
        {
            float angle = i * Mathf.PI * 2 / numBars;
            Vector3 pos = new Vector3(Mathf.Cos(angle), 0, Mathf.Sin(angle)) * radius;
            bars[i] = Instantiate(barPrefab, pos, Quaternion.identity);
            bars[i].transform.parent = this.transform;
        }
    }

    void Update()
    {
        float[] spectrum = new float[numBars];
        audioSource.GetSpectrumData(spectrum, 0, FFTWindow.BlackmanHarris);

        for (int i = 0; i < numBars; i++)
        {
            if (bars[i] != null)
            {
                Vector3 scale = bars[i].transform.localScale;
                scale.y = Mathf.Clamp(spectrum[i] * 100, 0.1f, 20f);
                bars[i].transform.localScale = scale;
            }
        }
    }
}

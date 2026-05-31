//Name: LUCAS ISAAC CASSOMA KATALAHALI 

namespace KelimeEzberleme;

public partial class Form1 : Form
{
    //Declarando uma lista do tipo palavra
    List<Kelime> list = new List<Kelime>();
    public Form1()
    {
        InitializeComponent();
    }
    private void Form1_Load(object sender, EventArgs e)
    {
        string path = Path.Combine(Application.StartupPath, "sozlukler");
        string[] file = Directory.GetFiles(path, "*.txt");

        foreach (string fileAdi in file)
        {
            string sozluk = Path.GetFileNameWithoutExtension(fileAdi);
            comboBoxSozluk.Items.Add(sozluk);
        }
        comboBoxSozluk.SelectedIndex = 0;
    }

    //MÉTODO BOTÃO YUKLE
    private void buttonYukle_Click(object sender, EventArgs e)
    {
        string path = Path.Combine(Application.StartupPath, "sozlukler");
        string fileAdi = comboBoxSozluk.SelectedItem!.ToString()!;
        fileAdi = Path.Combine(path, fileAdi + ".txt");
        list.Clear();
        foreach (string satir in File.ReadLines(fileAdi))
        {
            string[] parts = satir.Split('\t');

            if (parts.Length >= 2)
            {
                Kelime k = new Kelime(parts[0].Trim(), parts[1].Trim());
                list.Add(k);
            }
        }
        buttonBaslat.Enabled = true;
    }
    private void buttonBaslat_Click(object sender, EventArgs e)
    {
        FormQuiz formQuiz = new FormQuiz(list);
        formQuiz.Show();
    }
    private void buttonCikis_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
    private void comboBoxSozluk_SelectedIndexChanged(object sender, EventArgs e)
    {
        buttonBaslat.Enabled = false;
    }
}

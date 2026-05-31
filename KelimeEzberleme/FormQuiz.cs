using System.Data;

namespace KelimeEzberleme;

public partial class FormQuiz: Form
{
    List<Kelime> listkelimeler;
    Random random = new Random();
    int index = 0;
    int puan = 0;
    int count = 0;
    public FormQuiz(List<Kelime> list)
    {
        InitializeComponent();
        listkelimeler = new List<Kelime>(list);
        listkelimeler = listkelimeler.OrderBy(x => random.Next()).ToList();
        sonrakiSoru();
    }
    private void sonrakiSoru()
    {
        if(index >= listkelimeler.Count)
        {
            MessageBox.Show($"Bitti! Final Puan: {puan}");
            Close();
            return;
        }
        labelProgress.Text = $"{index + 1}/{listkelimeler.Count}";
        labelScore.Text = $"Puan: {puan}";
        labelSoru.Text = listkelimeler[index].Ingilizce;

        List<Kelime> random_secenekler = new List<Kelime>(listkelimeler);
        random_secenekler = random_secenekler.OrderBy(x => random.Next()).ToList();

        List<string> turkSecenekler = new List<string>();
        for(int i = 0; i <=2; i++)
        {
            if (random_secenekler[i].Turkce != listkelimeler[index].Turkce)
            {
                turkSecenekler.Add(random_secenekler[i].Turkce);
            }
            else
            { i--; }
        }
        turkSecenekler.Add(listkelimeler[index].Turkce);
        turkSecenekler = turkSecenekler.OrderBy(x => random.Next()).ToList();

        buttonOpsyon1.Text = turkSecenekler[0];
        buttonOpsyon2.Text = turkSecenekler[1];
        buttonOpsyon3.Text = turkSecenekler[2];
        buttonOpsyon4.Text = turkSecenekler[3];
    }
    private void cevapKontrol(object sender, EventArgs e)
    {
        if(sender is Button clickedButton)
        {
            count++;
            string secenek = clickedButton.Text;
            if (secenek == listkelimeler[index].Turkce)
            {
                index++;
                if (count == 1) puan += 10;
                count = 0;
                buttonOpsyon1.BackColor = SystemColors.Control;
                buttonOpsyon2.BackColor = SystemColors.Control;
                buttonOpsyon3.BackColor = SystemColors.Control;
                buttonOpsyon4.BackColor = SystemColors.Control;
                sonrakiSoru();
            }
            else
            {
                clickedButton.BackColor = Color.Red;
            }
        }
    }
}

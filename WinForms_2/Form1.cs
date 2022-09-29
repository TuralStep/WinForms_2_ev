using System.Text;

namespace WinForms_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum Marks
        {
            C = 0,
            Topla = 1,
            Cix = 2,
            Vur = 3,
            Bol = 4,
        }

        Font smallFont = new Font("Showcard Gothic", 30, FontStyle.Bold);
        Font regularFont = new Font("Showcard Gothic", 72, FontStyle.Bold);

        bool isItMark = true;
        bool canPlaceMark = false;

        List<int> numbers = new();
        List<Marks> marks = new();
        int currentNumber = 0;
        StringBuilder numberText = new StringBuilder("");

        private void number_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;

            if (btn != null)
            {
                isItMark = false;
                canPlaceMark = true;
                currentNumber = currentNumber * 10 + Convert.ToInt32(btn.Text);
                labelAdjustment(btn.Text);
            }
        }

        private void mark_Click(object sender, EventArgs e)
        {
            if (marks.Count == 0)
            {
                marks.Add(Marks.Topla);
            }
            var btn = sender as Button;

            if (btn != null && canPlaceMark)
            {
                if (isItMark) marks.RemoveAt(marks.Count() - 1);
                switch (btn.Text)
                {
                    case "+":
                        marks.Add(Marks.Topla);
                        break;
                    case "-":
                        marks.Add(Marks.Cix);
                        break;
                    case "/":
                        marks.Add(Marks.Bol);
                        break;
                    case "*":
                        marks.Add(Marks.Vur);
                        break;
                    case "=":
                        numbers.Add(currentNumber);

                        string answer = findAnswer();
                        number_lbl.Text = answer;
                        currentNumber = Convert.ToInt32(answer);
                        numberText.Clear();
                        numberText.Append(answer);

                        numbers.Clear();
                        marks.Clear();
                        marks.Add(Marks.Topla);
                        return;
                    case "C":
                        number_lbl.Text = "0";
                        numberText.Clear();
                        numbers.Clear();
                        marks.Clear();
                        return;
                }
                numbers.Add(currentNumber);
                currentNumber = 0;
                if (isItMark)
                    labelAdjustment(btn.Text, true);
                else
                    labelAdjustment(btn.Text);
                isItMark = true;
            }

        }

        private void labelAdjustment(string text, bool replace = false)
        {
            if (replace)
            {
                numberText.Remove(numberText.Length - 1, 1);
            }
            numberText.Append(text);

            if (numberText.Length > 5)
            {
                number_lbl.Font = smallFont;
            }
            else
            {
                number_lbl.Font = regularFont;
            }

            number_lbl.Text = numberText.ToString();
        }

        private string findAnswer()
        {

            int answer = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                try
                {
                    marks[i].ToString();
                }
                catch (Exception)
                {
                    number_lbl.Text = $"{numbers.Count}-{i}";
                    throw;
                }
                switch (marks[i])
                {
                    case Marks.Topla:
                        answer += numbers[i];
                        break;
                    case Marks.Cix:
                        answer -= numbers[i];
                        break;
                    case Marks.Vur:
                        answer *= numbers[i];
                        break;
                    case Marks.Bol:
                        answer /= numbers[i];
                        break;
                }
            }

            return answer.ToString();
        }

    }
}
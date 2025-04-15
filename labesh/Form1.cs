namespace labesh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<string> comboItems = new List<string> { "+", "-" };
            foreach (string item in comboItems)
            {
                comboBox1.Items.Add(item);
            }
            var measureItems = new string[]
       {
            "м^2.",
            "гк.",
            "ст.",
            "дес",
       };

            // прив€зываем списки значений к каждому комбобоксу
            comboBox2.DataSource = new List<string>(measureItems);
            comboBox3.DataSource = new List<string>(measureItems);
            comboBox4.DataSource = new List<string>(measureItems);
            comboBox5.DataSource = new List<string>(measureItems);
            comboBox6.DataSource = new List<string>(measureItems);
        }
        private Square.measure GetMeasureType(ComboBox comboBox)
        {
            Square.measure measureType;
            switch (comboBox.Text)
            {
                case "м^2":
                    measureType = Square.measure.mSquare;
                    break;
                case "гк.":
                    measureType = Square.measure.gectar;
                    break;
                case "ст.":
                    measureType = Square.measure.hundred;
                    break;
                case "дес":
                    measureType = Square.measure.tens;
                    break;
                default:
                    measureType = Square.measure.mSquare;
                    break;
            }
            return measureType;
        }

        private void Calculate()
        {


            Square.measure firstType = GetMeasureType(comboBox2);
            Square.measure secondType = GetMeasureType(comboBox3);
            Square.measure resultType = GetMeasureType(comboBox4);
            Square firstLength;
            Square secondLength;

            try
            {
                var firstValue = double.Parse(textFirst.Text);
                var secondValue = double.Parse(textSecond.Text);
                if (firstValue < 0 || secondValue < 0)
                {
                    MessageBox.Show("“џ ≈ЅЋјЌ ” “≈Ѕя ѕЋќўјƒ» ќ“–»÷ј“≈Ћ№Ќџ≈");
                    textFirst.Text = "0";
                    textSecond.Text = "0";
                    textThird.Text = "0";
                    return;
                }
                else
                {
                     
                    
                }
                Square sumLength;
                firstLength = new Square(firstValue, firstType);
                secondLength = new Square(secondValue, secondType);


                switch (comboBox1.Text)
                {
                    case "+":
                        // если плюсик выбрали, то складываем
                        sumLength = firstLength + secondLength;
                        break;
                    case "-":
                        // если минус, то вычитаем
                        sumLength = firstLength - secondLength;
                        break;
                    default:
                        // а если что-то другое, то просто 0 выводим,
                        // такое маловеро€тно, но надо указать иначе не скомпилитс€
                        sumLength = new Square(0, resultType);
                        break;
                }


                textThird.Text = sumLength.verbose();
            }
            catch (FormatException)
            {
                // если тип преобразовать не смогли
            }
        }
        private string compareAreas()
        {
            string result = "";
            Square.measure firstMeasure = GetMeasureType(comboBox5);
            Square.measure secondMeasure = GetMeasureType(comboBox6);
            try
            {
                var firstValue = double.Parse(textBox2.Text);
                var secondValue = double.Parse(textBox3.Text);
                var firstSquare = new Square(firstValue, firstMeasure);
                var secondSquare = new Square(secondValue, secondMeasure);
                result = Square.compare(secondSquare, firstSquare);

                //MessageBox.Show(firstSquare.To(Square.measure.mSquare).getValue().ToString());
               //MessageBox.Show(secondSquare.To(Square.measure.mSquare).getValue().ToString());

            }
            catch (FormatException)
            {

            }
            return result;
        }

        private void textFirst_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void textSecond_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = compareAreas();
            MessageBox.Show(result);
        }
    }

}

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
            "�^2.",
            "��.",
            "��.",
            "���",
       };

            // ����������� ������ �������� � ������� ����������
            comboBox2.DataSource = new List<string>(measureItems);
            comboBox3.DataSource = new List<string>(measureItems);
            comboBox4.DataSource = new List<string>(measureItems);
        }
        private Square.measure GetMeasureType(ComboBox comboBox)
        {
            Square.measure measureType;
            switch (comboBox.Text)
            {
                case "�^2":
                    measureType = Square.measure.mSquare;
                    break;
                case "��.":
                    measureType = Square.measure.gectar;
                    break;
                case "��.":
                    measureType = Square.measure.hundred;
                    break;
                case "���":
                    measureType = Square.measure.gectar;
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

            try
            {
                var firstValue = double.Parse(textFirst.Text);
                var secondValue = double.Parse(textSecond.Text);

                var firstLength = new Square(firstValue, firstType);
                var secondLength = new Square(secondValue, secondType);

                Square sumLength;


                switch (comboBox1.Text)
                {
                    case "+":
                        // ���� ������ �������, �� ����������
                        sumLength = firstLength + secondLength;
                        break;
                    case "-":
                        // ���� �����, �� ��������
                        sumLength = firstLength - secondLength;
                        break;
                    default:
                        // � ���� ���-�� ������, �� ������ 0 �������,
                        // ����� ������������, �� ���� ������� ����� �� �����������
                        sumLength = new Square(0, resultType);
                        break;
                }


                textThird.Text = sumLength.verbose();
            }
            catch (FormatException)
            {
                // ���� ��� ������������� �� ������
            }
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
    }

}

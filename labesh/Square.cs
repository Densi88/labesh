using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labesh
{
   public class Square
    {
        public enum measure { mSquare, gectar, hundred, tens };
        private double value;
        public measure type;
        
        public Square(double value, measure type) {
            this.value = value;
            this.type = type;
        }
        public string verbose()
        {
            string result="";
            switch (this.type)
            {
                case measure.mSquare:
                    result = "м^2";
                    break;
                case measure.gectar:
                    result = "гк";
                    break;
                case measure.hundred:
                    result = "ст";
                    break;
                case measure.tens:
                    result = "дес";
                    break;
            }
            return String.Format("{0} {1}", this.value, result);
        }
        public static Square SquarePlusNumber(Square instance, double number)
        {
            var newValue = instance.value + number;
            Square square = new Square(newValue, instance.type);
            return square;
        }
        public static Square SquareMinusNumber(Square instance, double number)
        {
            return new Square(instance.value - number, instance.type);
        }
        public static Square SquareMultiplicationNumber(Square instance, double number)
        {
            return new Square(instance.value* number, instance.type);
        }
        public static Square SquareDivisionNumber(Square instance, double number)
        {
            return new Square(instance.value/number, instance.type);
        }

        public Square To(measure newType)
        {
            // по умолчанию новое значение совпадает со старым
            var newValue = this.value;
            // если текущий тип -- это метр
            if (this.type == measure.mSquare)
            {
                // а теперь рассматриваем все другие ситуации
                switch (newType)
                {
                    // если конвертим в метр, то значение не меняем
                    case measure.mSquare:
                        newValue = this.value;
                        break;
                    // если в км.
                    case measure.gectar:
                        newValue = this.value / 10000;
                        break;
                    // если в  а.е.
                    case measure.tens:
                        newValue = this.value / 10925;
                        break;
                    // если в парсек
                    case measure.hundred:
                        newValue = this.value /100;
                        break;
                }
            }
            else if (newType == measure.mSquare) // если новый тип: метр
            {
                switch (this.type) // а тут уже старый тип проверяем
                {
                    case measure.mSquare:
                        newValue = this.value;
                        break;
                    case measure.gectar:
                        newValue = this.value * 10000; // кстати это то же код что и выше, только / заменили на *
                        break;
                    case measure.tens:
                        newValue = this.value * 10925; // и тут / на *
                        break;
                    case measure.hundred:
                        newValue = this.value * 100; // и даже тут, просто / на *
                        break;
                }
            }
            else
            {
                newValue = this.To(measure.mSquare).To(newType).value;
            }
            return new Square(newValue, newType);
        }
        public static Square operator+(Square instance1, Square instance2)
        {
            var lalala = instance2.To(instance1.type);
            return new Square(instance1.value + lalala.value, instance1.type);
        }
       public static Square operator -(Square instance1, Square instance2)
        {
            var lalala = instance2.To(instance1.type);
            return new Square(instance1.value - lalala.value, instance1.type);
        }
        public double getValue()
        {
            return value;
        }
        public static string compare(Square instance1, Square instance2)
        {
            string result = "";
            instance1=instance1.To(Square.measure.mSquare);
            instance2=instance2.To(Square.measure.mSquare);
            if (instance1.getValue()>instance2.getValue())
            {
                result = "Первая площадь больше второй!";
            }
            if(instance1.getValue()<instance2.getValue())
            {
                result = "Вторая площадь больше первой!";
            }
            if(instance1.getValue() == instance2.getValue())
            {
                result = "Площади равны!";
            }
            return result;
        }
    }
}

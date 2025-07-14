using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
namespace Lab1
{

    public class UncorrectChooseException : Exception
    {
        // Конструктор класса, принимающий сообщение об ошибке
        public UncorrectChooseException(string message) : base(message)
        {
        }
    }


    interface ICalculator
    {
        void analyze_weight(bool isMan, double weight, int height, int age, int target, double target_weight, int days, ref Label result_label);
        double norm_calories(double weight, int height, int age, bool isMan);
        double weight_change(double currentWeight, double targetWeight, int days);
            }
    internal class Calculator: ICalculator//модификатор доступа
    {
        public Calculator() { }

        public double norm_calories(double weight, int height, int age, bool isMan)
        {
            if (isMan) //количество нормальных калорий
                return 10 * weight + 6.25 * height - 5 * age + 5;
            return 10 * weight + 6.25 * height - 5 * age - 161;
        }
        //дефицита калорий в день
        public double weight_change(double currentWeight, double targetWeight, int days)
        {
            double caloriesPerKilogram = 7700;//количество калорий в одном килограмме жира без воды и соед тканей

            double weightLossPerDay = Math.Abs(currentWeight - targetWeight) / days;//изменение веса в день

            double totalCaloricDeficit = weightLossPerDay * caloriesPerKilogram;//общий дефицит калорий

            double dailyCaloricDeficit = totalCaloricDeficit / days;

            return dailyCaloricDeficit;
        }

        public void analyze_weight(bool isMan, double weight, int height, int age, int target, double target_weight, int days, ref Label result_label)
        {
            double calories = 0;
            double normal_weight = 0;
            if(isMan)
            {
                normal_weight = (height - 100) * 0.9;
            }
            else {
                normal_weight = (height - 100) * 0.85;
            }
            if(age < 30)
            {
                normal_weight *= 0.89;//уменьшает 
            }
            else if(age > 50)
            {
                normal_weight *= 1.06;//увеличивает
            }
            //Определение категории веса
            if (Math.Abs(normal_weight - weight) < 0.1) //100 грамм(для округления)
            {
                result_label.Text = "Ваш вес в норме";
            }
            else if (normal_weight < weight)
            {
                result_label.Text = "У вас присутствует лишний вес";
            }
            else
            {
                result_label.Text = "У вас недостаток веса";
            }
            calories = norm_calories(weight, height, age, isMan);
            string goalMessage = "";
            if (target == 0)
            {
                goalMessage = $"\nНорма калорий для поддержания веса: {calories:F2} ккал";
            }
            else if (target == -1) //Снижение веса
            {
                if (target_weight >= weight)
                {
                    throw new UncorrectChooseException("Для похудения ваш целевой вес должен быть меньше текущего");
                }
                if (days < 7) // Минимальный срок - 7 дней (пример)
                {
                    MessageBox.Show("Срок похудения должен быть не менее 7 дней.");
                    return;
                }
                double calorieDeficit = weight_change(weight, target_weight, days);
                double maxSafeDeficit = 1000; // Пример: Максимальный дефицит 1000 ккал
                if (calorieDeficit > maxSafeDeficit)
                {
                    calorieDeficit = maxSafeDeficit;
                }
                calories -= calorieDeficit;
                goalMessage = $"\nНорма калорий для похудения: {calories:F2} ккал (дефицит: {calorieDeficit:F2} ккал)";
            }
            else if (target == 1) //Набор веса
            {
                if (target_weight <= weight)
                {
                    throw new UncorrectChooseException("Для набора веса ваш целевой вес должен быть больше текущего");
                }
                double calorieSurplus = weight_change(weight, target_weight, days);
                calories += calorieSurplus;
                goalMessage = $"\nНорма калорий для набора веса: {calories:F2} ккал (профицит: {calorieSurplus:F2} ккал)";
            }
            else
            {
                throw new ArgumentException("Некорректное значение для 'target'.  Допустимые значения: -1, 0, 1.");
            }

            //Проверка минимально безопасного уровня калорий
            double minSafeCalories = isMan ? 1500 : 1200;
            string safetyMessage = "";
            if (calories < minSafeCalories)
            {
                calories = minSafeCalories;
                safetyMessage = $"\nВнимание! Рассчитанная норма калорий ниже минимально безопасного уровня ({minSafeCalories} ккал). Скорректировано до {calories:F2} ккал. Проконсультируйтесь с врачом!";
            }

            result_label.Text = result_label.Text + goalMessage + safetyMessage;
        }
    }
}

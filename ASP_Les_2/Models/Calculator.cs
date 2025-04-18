using System.ComponentModel.DataAnnotations;
using System.Runtime.ExceptionServices;

namespace ASP_Les_2.Models
{
    public class Calculator
    {
        [Display(Name = "Первое число")]
        public double FirstNumber { get; set; }
        [Display(Name = "Второе число")]
        public double SecondNumber { get; set; }

        [Display(Name = "Операция")]
        public OperationType Operator { get; set; }

        public double? Result { get; set; }
    }

    public enum OperationType
    {
        [Display(Name = "+")]
        Addition,
        [Display(Name = "-")]
        Subtraction,
        [Display(Name = "*")]
        Multiplication,
        [Display(Name = "/")]
        Division
    }

}

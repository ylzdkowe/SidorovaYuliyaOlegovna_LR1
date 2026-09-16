using MyNotesApp.Models;
using MyNotesApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotesApp.ViewModels
{
    public class CalcViewModel
    {
        private readonly ICalculatorService _calcService;

        public CalcViewModel(ICalculatorService calcService)
        {
            _calcService = calcService;
        }

        public string Calculate(string a, string b)
        {
            try
            {
                var model = new CalculationResult
                {
                    Number1 = double.Parse(a),
                    Number2 = double.Parse(b)
                };

                var result = _calcService.Add(model);
                return $"Результат: {result.Result}";
            }
            catch (System.Exception ex)
            {
                return $"Ошибка: {ex.Message}";
            }
        }
    }
}
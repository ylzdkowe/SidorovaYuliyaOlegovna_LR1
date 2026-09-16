using MyNotesApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotesApp.Services
{
    public class CalculatorService : ICalculatorService
    {
        public CalculationResult Add(CalculationResult model)
        {
            if (model.Number1 > 1000 || model.Number2 > 1000)
                throw new ArgumentException("Числа слишком большие");

            model.Result = model.Number1 + model.Number2;
            return model;
        }
    }
}
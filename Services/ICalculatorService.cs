using MyNotesApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotesApp.Services
{
    public interface ICalculatorService
    {
        CalculationResult Add(CalculationResult model);
    }
}

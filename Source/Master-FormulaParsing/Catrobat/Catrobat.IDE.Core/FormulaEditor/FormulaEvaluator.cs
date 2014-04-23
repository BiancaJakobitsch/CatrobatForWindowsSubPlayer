﻿using System;
using Catrobat.IDE.Core.CatrobatObjects.Formulas.FormulaTree;

namespace Catrobat.IDE.Core.FormulaEditor
{
    class FormulaEvaluator
    {
        public static double EvaluateNumber(IFormulaTree formula)
        {
            return formula == null ? 0 : formula.EvaluateNumber();
        }

        public static bool EvaluateLogic(IFormulaTree formula)
        {
            return formula != null && formula.EvaluateLogic();
        }

        public static object Evaluate(IFormulaTree formula)
        {
            if (formula == null) return null;

#if DEBUG
            return formula.IsNumber() ? (object)formula.EvaluateNumber() : formula.EvaluateLogic();
#else
            try
            {
                return formula.IsNumber() ? (object)formula.EvaluateNumber() : formula.EvaluateLogic();
            }
            catch (Exception)
            {
                return null;
            }
#endif
        }
    }
}

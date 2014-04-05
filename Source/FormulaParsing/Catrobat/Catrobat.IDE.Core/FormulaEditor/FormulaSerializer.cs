﻿using Catrobat.IDE.Core.CatrobatObjects.Formulas.FormulaTree;

namespace Catrobat.IDE.Core.FormulaEditor
{
    public class FormulaSerializer
    {
        public static string EmptyChild = " ";

        public string Serialize(IFormulaTree formula)
        {
            if (formula == null) return string.Empty;
#if DEBUG
            return formula.Serialize();
#else
            try
            {
                return formula.Serialize();
            }
            catch (Exception)
            {
                return null;
            }
#endif
        }
    }
}

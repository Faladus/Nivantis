using System;
using System.Collections.Generic;
using System.Text;

namespace Nivantis.Exceptions
{
    class CalculationExceptions
    {
        public static string GrossPriceEqualZero = "Le prix d'achat brut ne peut être égal à 0";

        public static string DiscountUnderZero = "Le taux de réduction ne peut être inférieur à zero";

        public static string MultiplierUnderZero = "Le coefficient multiplicateur ne peut être inférieur à zero";

        public static string MissingValue = "Valeur(s) manquante...";
    }
}

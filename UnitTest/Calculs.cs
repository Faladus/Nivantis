using Nivantis.Services;
using System;
using Xunit;

namespace UnitTest
{
    public class Calculs
    {
        [Fact]
        public void TauxDeRemiseCalculTest()
        {
            decimal prixAchatNet = 10.25M;
            decimal prixAchatBrut = 12.67M;
            decimal tauxDeRemise = 19.10M;

            decimal result = Math.Round(CalculationService.Discount(prixAchatNet, prixAchatBrut), 2);

            Assert.Equal(tauxDeRemise, result);
        }

        [Fact]
        public void PrixAchatNetCalculTest()
        {
            decimal prixAchatBrut = 54.36M;
            decimal tauxDeRemise = 0.25M;
            decimal prixAchatNet = 40.77M;

            decimal result = Math.Round(CalculationService.NetPurchasePrice(prixAchatBrut, tauxDeRemise), 2);

            Assert.Equal(prixAchatNet, result);
        }

        [Fact]
        public void PrixVenteNetCalculTest()
        {
            decimal prixAchatNet = 37.26M;
            decimal CoefMultiplicateur = 2.12M;
            decimal prixVenteNet = 78.99M;

            decimal result = Math.Round(CalculationService.NetSellingPrice(prixAchatNet, CoefMultiplicateur), 2);

            Assert.Equal(prixVenteNet, result);
        }

        [Fact]
        public void CoefMultiplicateurCalculTest()
        {
            decimal prixVenteNet = 5M;
            decimal prixAchatNet= 3.20M;
            decimal coefMultiplicateur = 1.56M;

            decimal result = Math.Round(CalculationService.Multiplier(prixVenteNet, prixAchatNet), 2);

            Assert.Equal(coefMultiplicateur, result);
        }
    }
}

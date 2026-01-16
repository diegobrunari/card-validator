using System.Text.RegularExpressions;

namespace CreditCardValidator.Validators;

public static class CardValidator
{
    private static readonly Dictionary<CardBrand, string> BrandPatterns = new()
    {
        { CardBrand.Visa, @"^4[0-9]{12}(?:[0-9]{3})?$" },
        { CardBrand.Mastercard, @"^(5[1-5][0-9]{14}|2[2-7][0-9]{14})$" },
        { CardBrand.AmericanExpress, @"^3[47][0-9]{13}$" },
        { CardBrand.DinersClub, @"^3(?:0[0-5]|[68][0-9])[0-9]{11}$" },
        { CardBrand.Discover, @"^6(?:011|5[0-9]{2})[0-9]{12}$" },
        { CardBrand.JCB, @"^(?:2131|1800|35\d{3})\d{11}$" },
        { CardBrand.Elo, @"^(4011(78|79)|4312(74|75)|438935|451416|4576(31|32)|504175|5067(0[0-9]|1[0-9]|2[0-9])|509(0[0-9]{2}|1[0-9]{2}|2[0-9]{2})|627780|636297|636368)\d+$" },
        { CardBrand.Hipercard, @"^(38[0-9]{17}|60[0-9]{14,15})$" }
    };

    public static bool ValidateNumber(string cardNumber)
    {
        if (string.IsNullOrWhiteSpace(cardNumber))
            return false;

        cardNumber = Regex.Replace(cardNumber, @"\s|-", "");

        if (!Regex.IsMatch(cardNumber, @"^[0-9]+$"))
            return false;

        return LuhnCheck(cardNumber);
    }

    public static CardBrand GetBrand(string cardNumber)
    {
        cardNumber = Regex.Replace(cardNumber, @"\s|-", "");

        foreach (var item in BrandPatterns)
        {
            if (Regex.IsMatch(cardNumber, item.Value))
                return item.Key;
        }

        return CardBrand.Unknown;
    }

    private static bool LuhnCheck(string number)
    {
        int sum = 0;
        bool alternate = false;

        for (int i = number.Length - 1; i >= 0; i--)
        {
            int n = int.Parse(number[i].ToString());

            if (alternate)
            {
                n *= 2;
                if (n > 9)
                    n -= 9;
            }

            sum += n;
            alternate = !alternate;
        }

        return (sum % 10 == 0);
    }
}

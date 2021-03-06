namespace MyBanker;

internal class Mastercard : Card {
    public Mastercard(string cardOwner) :
        base(cardOwner, 14, Prefixes, DateTime.Today.AddYears(Random.Shared.Next(1, 6)), 0, 30000) { }

    // defines the prefixes for generating the card number
    private static readonly string[] Prefixes
        = { "51", "52", "53", "54", "55" };
}

namespace Tarot.Models;

public record TarotCard(
    string Name,
    string Short,
    string Upright,
    string[] UprightKeywords,
    string Reversed,
    string[] ReversedKeywords
);

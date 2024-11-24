using Tarot.Models;

namespace Tarot.Services.TarotFactory;

public class RandomChoiceTarotFactory : ITarotFactory {

    #region Predefined Cards
    // Advice used from https://xkqr.org/engeni/
    private readonly IList<TarotCard> _cards = [
        new(
            "The Fool",
            "trump00",
            "Embrace the unknown; take a leap of faith",
            "Be conservative; avoid undue risks."
        ),
        new(
            "The Magician",
            "trump01",
            "Make a sprint for your goals.",
            "Revise your goals."
        ),
        new(
            "The High Priestess",
            "trump02",
            "Be careful of the threshold.",
            "Find the centre and expose it."
        ),
        new(
            "The Empress",
            "trump03",
            "Choose form over function.",
            "Find trees and walk among them."
        ),
        new(
            "The Emperor",
            "trump04",
            "Teach someone something.",
            "Tear down unequal partnerships."
        ),
        new(
            "The Hierophant",
            "trump05",
            "Adhere religiously to conventions.",
            "Venture outside the conventions."
        ),
        new(
            "The Lovers",
            "trump06",
            "Imagine living with the choice for the rest of your life.",
            "Cut corners."
        ),
        new(
            "The Chariot",
            "trump07",
            "Ignore distractions.",
            "Turn 180°."
        ),
        new(
            "Strength",
            "trump08",
            "Remove the obstacle;don't go around it.",
            "Find the path of least resistance."
        ),
        new(
            "The Hermit",
            "trump09",
            "Write an FAQ on it.",
            "TK"
        ),
        new(
            "Wheel of Fortune",
            "trump10",
            "This, too, shall pass.",
            "Things are about to get much worse."
        ),
        new(
            "Justice",
            "trump11",
            "Does this make you proud?",
            "Take responsibility."
        ),
        new(
            "The Hanged Man",
            "trump12",
            "Let things rest for a day or two.",
            "Turn it upside down."
        ),
        new(
            "Death",
            "trump13",
            "It's not working; try something else.",
            "Pay more attention to your health."
        ),
        new(
            "Temperance",
            "trump14",
            "Blend, mix, rephrase, combine.",
            "Something throws off your balance."
        ),
        new(
            "The Devil",
            "trump15",
            "Admit you are powerless.",
            "You are close to success."
        ),
        new(
            "The Tower",
            "trump16",
            "What you see is an illusion.",
            "Your personal beliefs may end up changing."
        ),
        new(
            "The Star",
            "trump17",
            "Make it in abundance.",
            "What is the deeper life lesson here?"
        ),
        new(
            "The Moon",
            "trump18",
            "Be patient; you will soon know more.",
            "Don't ignore your inner voice."
        ),
        new(
            "The Sun",
            "trump19",
            "There's plenty hydrogen in the Sun yet.",
            "Take a break; play a game."
        ),
        new(
            "Judgment",
            "trump20",
            "Look to your past experience for guidance.",
            "Are you ready to do something bigger?"
        ),
        new(
            "The World",
            "trump21",
            "Imagine yourself succeeding.",
            "Let go of old goals."
        ),
        new(
            "Ace of Cups",
            "cups01",
            "Do something creative; try something new.",
            "Do what gives you pleasure."
        ),
        new(
            "Two of Cups",
            "cups02",
            "Discuss it with a stranger.",
            "Do the most difficult."
        ),
        new(
            "Three of Cups",
            "cups03",
            "Find a collaborator.",
            "Get some solitude."
        ),
        new(
            "Four of Cups",
            "cups04",
            "Take deeper breaths; slow down.",
            "Take a hot shower."
        ),
        new(
            "Five of Cups",
            "cups05",
            "Be bold.",
            "Move on to something else."
        ),
        new(
            "Six of Cups",
            "cups06",
            "What would ten-year old you do?",
            "Be playful."
        ),
        new(
            "Seven of Cups",
            "cups07",
            "What would you do if your dreams came true?",
            "Focus on what is important."
        ),
        new(
            "Eight of Cups",
            "cups08",
            "Look for what is missing.",
            "Try one more time."
        ),
        new(
            "Nine of Cups",
            "cups09",
            "Be thankful for what you have.",
            "Get rid of something."
        ),
        new(
            "Ten of Cups",
            "cups10",
            "Create something harmonious.",
            "Ensure there is discordance."
        ),
        new(
            "Page of Cups",
            "cups11",
            "Accept an opportunity.",
            "Reject an opportunity."
        ),
        new(
            "Knight of Cups",
            "cups12",
            "Think of who you admire.",
            "Do something unrealistic."
        ),
        new(
            "Queen of Cups",
            "cups13",
            "Block off some focus time.",
            "What would look impressive?"
        ),
        new(
            "King of Cups",
            "cups14",
            "Balance emotion with ruthlessness.",
            "Embrace ambiguity."
        ),
        new(
            "Ace of Swords",
            "swords01",
            "This will take more research.",
            "Insert an unexpected twist into the plan."
        ),
        new(
            "Two of Swords",
            "swords02",
            "Add frosting to the cake now.",
            "Open your eyes; take in reality mindfully."
        ),
        new(
            "Three of Swords",
            "swords03",
            "Do it even if it hurts.",
            "Lower your expectations."
        ),
        new(
            "Four of Swords",
            "swords04",
            "Take a step back; re-assess your priorities.",
            "Work on it until you are sick of it."
        ),
        new(
            "Five of Swords",
            "swords05",
            "Is this the hill you want to die on?",
            "Do it even if at the expense of others."
        ),
        new(
            "Six of Swords",
            "swords06",
            "Inject a transition.",
            "Resist the new."
        ),
        new(
            "Seven of Swords",
            "swords07",
            "Copy someone else's solution.",
            "Do it covertly."
        ),
        new(
            "Eight of Swords",
            "swords08",
            "Do something unexpected.",
            "Walk around it slowly; look at it from the outside."
        ),
        new(
            "Nine of Swords",
            "swords09",
            "Tend to what makes it hard to sleep.",
            "Share a secret."
        ),
        new(
            "Ten of Swords",
            "swords10",
            "Stop feeling like a victim; accept and take control.",
            "Change is inevitable; rip off the band-aid."
        ),
        new(
            "Page of Swords",
            "swords11",
            "Learn something new.",
            "Make a very ambitious plan."
        ),
        new(
            "Knight of Swords",
            "swords12",
            "Delete it all; start over.",
            "Sit and watch it unfold."
        ),
        new(
            "Queen of Swords",
            "swords13",
            "List pros and cons.",
            "Change your mind; be mercurial."
        ),
        new(
            "King of Swords",
            "swords14",
            "Pretend you have full authority.",
            "Resign all authority."
        ),
        new(
            "Ace of Pentacles",
            "pents01",
            "Grab the money without thinking.",
            "Let the opportunity pass you by."
        ),
        new(
            "Two of Pentacles",
            "pents02",
            "Increase concurrency.",
            "Reduce concurrency."
        ),
        new(
            "Three of Pentacles",
            "pents03",
            "Broaden the team.",
            "Step on some toes."
        ),
        new(
            "Four of Pentacles",
            "pents04",
            "Conserve what you have.",
            "Re-evaluate your risk tolerance."
        ),
        new(
            "Five of Pentacles",
            "pents05",
            "Pretend you have nothing.",
            "Focus on recovering what you lost."
        ),
        new(
            "Six of Pentacles",
            "pents06",
            "Share generously.",
            "Remove one from each."
        ),
        new(
            "Seven of Pentacles",
            "pents07",
            "Focus on long-term sustainability.",
            "Get to short-term results quickly."
        ),
        new(
            "Eight of Pentacles",
            "pents08",
            "Don't worry about repetition.",
            "Be a perfectionist."
        ),
        new(
            "Nine of Pentacles",
            "pents09",
            "You don't need more.",
            "Put in more time."
        ),
        new(
            "Ten of Pentacles",
            "pents10",
            "Ask your family.",
            "Stay late."
        ),
        new(
            "Page of Pentacles",
            "pents11",
            "Practice a skill.",
            "Blame someone else."
        ),
        new(
            "Knight of Pentacles",
            "pents12",
            "Make things the way they were before.",
            "Allow yourself to get bored."
        ),
        new(
            "Queen of Pentacles",
            "pents13",
            "Don't kill your darlings.",
            "Give yourself more spare time."
        ),
        new(
            "King of Pentacles",
            "pents14",
            "Think like a CEO.",
            "Abandon all hope."
        ),
        new(
            "Ace of Wands",
            "wands01",
            "Harvest what you planted last year.",
            "Lean into a distraction."
        ),
        new(
            "Two of Wands",
            "wands02",
            "Make a roadmap.",
            "Avoid uncertainties."
        ),
        new(
            "Three of Wands",
            "wands03",
            "Expand the scope.",
            "Reduce the scope."
        ),
        new(
            "Four of Wands",
            "wands04",
            "Celebrate what you have accomplished so far.",
            "Enjoy a beverage quietly."
        ),
        new(
            "Five of Wands",
            "wands05",
            "Lean into conflict.",
            "Avoid conflict at all costs."
        ),
        new(
            "Six of Wands",
            "wands06",
            "Give yourself a prize for a part of it.",
            "Disregard others and aim for personal goals."
        ),
        new(
            "Seven of Wands",
            "wands07",
            "Defend your controversial ideas.",
            "Abandon your controversial ideas."
        ),
        new(
            "Eight of Wands",
            "wands08",
            "Follow the path of least resistance.",
            "Find the critical flaw in your idea."
        ),
        new(
            "Nine of Wands",
            "wands09",
            "Keep to the tried-and-true.",
            "What if they are actually out to get you?"
        ),
        new(
            "Ten of Wands",
            "wands10",
            "Help someone else with their problem.",
            "Delegate your problem."
        ),
        new(
            "Page of Wands",
            "wands11",
            "Read a book.",
            "Try it in a pet project."
        ),
        new(
            "Knight of Wands",
            "wands12",
            "What would a high-energy state look like?",
            "What would a high-entropy state look like?"
        ),
        new(
            "Queen of Wands",
            "wands13",
            "Instigate others to join you.",
            "Find yourself again."
        ),
        new(
            "King of Wands",
            "wands14",
            "What would an entrepreneur do?",
            "Write down your expectations."
        ),
    ];
    #endregion

    public TarotCard Create() {
        Random random = new();

        return _cards[random.Next(_cards.Count)];
    }
}

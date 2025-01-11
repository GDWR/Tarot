using Tarot.Models;

namespace Tarot.Services.TarotFactory;

public class RandomChoiceTarotFactory : ITarotFactory {

    #region Predefined Cards
    // Advice used from https://xkqr.org/engeni/
    // Keywords used from https://labyrinthos.co/blogs/tarot-card-meanings-list
    private readonly IList<TarotCard> _cards = [
        new(
            "The Fool",
            "trump00",
            "Embrace the unknown; take a leap of faith",
            ["innocence", "new beginnings", "free spirit"],
            "Be conservative; avoid undue risks.",
            ["recklessness", "taken advantage of", "inconsideration"]
        ),
        new(
            "The Magician",
            "trump01",
            "Make a sprint for your goals.",
            ["willpower", "desire", "creation", "manifestation"],
            "Revise your goals.",
            ["trickery", "illusions", "out of touch"]
        ),
        new(
            "The High Priestess",
            "trump02",
            "Be careful of the threshold.",
            ["intuitive", "unconscious", "inner voice"],
            "Find the centre and expose it.",
            ["lack of center", "lost inner voice", "repressed feelings"]
        ),
        new(
            "The Empress",
            "trump03",
            "Choose form over function.",
            ["motherhood", "fertility", "nature"],
            "Find trees and walk among them.",
            ["dependence", "smothering", "emptiness", "nosiness"]
        ),
        new(
            "The Emperor",
            "trump04",
            "Teach someone something.",
            ["authority", "structure", "control", "fatherhood"],
            "Tear down unequal partnerships.",
            ["tyranny", "rigidity", "coldness"]
        ),
        new(
            "The Hierophant",
            "trump05",
            "Adhere religiously to conventions.",
            ["tradition", "conformity", "morality", "ethics"],
            "Venture outside the conventions.",
            ["rebellion", "subversiveness", "new approaches"]
        ),
        new(
            "The Lovers",
            "trump06",
            "Imagine living with the choice for the rest of your life.",
            ["partnerships", "duality", "union"],
            "Cut corners.",
            ["loss of balance", "one-sidedness", "disharmony"]
        ),
        new(
            "The Chariot",
            "trump07",
            "Ignore distractions.",
            ["direction", "control", "willpower"],
            "Turn 180°.",
            ["lack of control", "lack of direction", "aggression"]
        ),
        new(
            "Strength",
            "trump08",
            "Remove the obstacle;don't go around it.",
            ["inner strength", "bravery", "compassion", "focus"],
            "Find the path of least resistance.",
            ["self doubt", "weakness", "insecurity"]
        ),
        new(
            "The Hermit",
            "trump09",
            "Write an FAQ on it.",
            ["contemplation", "search for truth", "inner guidance"],
            "TK",
            ["loneliness", "isolation", "lost your way"]
        ),
        new(
            "Wheel of Fortune",
            "trump10",
            "This, too, shall pass.",
            ["change", "cycles", "inevitable fate"],
            "Things are about to get much worse.",
            ["no control", "clinging to control", "bad luck"]
        ),
        new(
            "Justice",
            "trump11",
            "Does this make you proud?",
            ["cause and effect", "clarity", "truth"],
            "Take responsibility.",
            ["dishonesty", "unaccountability", "unfairness"]
        ),
        new(
            "The Hanged Man",
            "trump12",
            "Let things rest for a day or two.",
            ["sacrifice", "release", "martyrdom"],
            "Turn it upside down.",
            ["stalling", "needless sacrifice", "fear of sacrifice"]
        ),
        new(
            "Death",
            "trump13",
            "It's not working; try something else.",
            ["end of cycle", "beginnings", "change", "metamorphosis"],
            "Pay more attention to your health.",
            ["fear of change", "holding on", "stagnation", "decay"]
        ),
        new(
            "Temperance",
            "trump14",
            "Blend, mix, rephrase, combine.",
            ["middle path", "patience", "finding meaning"],
            "Something throws off your balance.",
            ["extremes", "excess", "lack of balance"]
        ),
        new(
            "The Devil",
            "trump15",
            "Admit you are powerless.",
            ["addiction", "materialism", "playfulness"],
            "You are close to success.",
            ["freedom", "release", "restoring control"]
        ),
        new(
            "The Tower",
            "trump16",
            "What you see is an illusion.",
            ["sudden upheaval", "broken pride", "disaster"],
            "Your personal beliefs may end up changing.",
            ["disaster avoided", "delayed disaster", "fear of suffering"]
        ),
        new(
            "The Star",
            "trump17",
            "Make it in abundance.",
            ["hope", "faith", "rejuvenation"],
            "What is the deeper life lesson here?",
            ["faithlessness", "discouragement", "insecurity"]
        ),
        new(
            "The Moon",
            "trump18",
            "Be patient; you will soon know more.",
            ["unconscious", "illusions", "intuition"],
            "Don't ignore your inner voice.",
            ["confusion", "fear", "misinterpretation"]
        ),
        new(
            "The Sun",
            "trump19",
            "There's plenty hydrogen in the Sun yet.",
            ["joy", "success", "celebration", "positivity"],
            "Take a break; play a game.",
            ["negativity", "depression", "sadness"]
        ),
        new(
            "Judgment",
            "trump20",
            "Look to your past experience for guidance.",
            ["reflection", "reckoning", "awakening"],
            "Are you ready to do something bigger?",
            ["lack of self awareness", "doubt", "self loathing"]
        ),
        new(
            "The World",
            "trump21",
            "Imagine yourself succeeding.",
            ["fulfillment", "harmony", "completion"],
            "Let go of old goals.",
            ["incompletion", "no closure"]
        ),
        new(
            "Ace of Cups",
            "cups01",
            "Do something creative; try something new.",
            ["new feelings", "spirituality", "intuition"],
            "Do what gives you pleasure.",
            ["emotional loss", "blocked creativity", "emptiness"]
        ),
        new(
            "Two of Cups",
            "cups02",
            "Discuss it with a stranger.",
            ["unity", "partnership", "connection"],
            "Do the most difficult.",
            ["imbalance", "broken communication", "tension"]
        ),
        new(
            "Three of Cups",
            "cups03",
            "Find a collaborator.",
            ["friendship", "community", "happiness"],
            "Get some solitude.",
            ["overindulgence", "gossip", "isolation"]
        ),
        new(
            "Four of Cups",
            "cups04",
            "Take deeper breaths; slow down.",
            ["apathy", "contemplation", "disconnectedness"],
            "Take a hot shower.",
            ["sudden awareness", "choosing happiness", "acceptance"]
        ),
        new(
            "Five of Cups",
            "cups05",
            "Be bold.",
            ["loss", "grief", "self-pity"],
            "Move on to something else.",
            ["acceptance", "moving on", "finding peace"]
        ),
        new(
            "Six of Cups",
            "cups06",
            "What would ten-year old you do?",
            ["familiarity", "happy memories", "healing"],
            "Be playful.",
            ["moving forward", "leaving home", "independence"]
        ),
        new(
            "Seven of Cups",
            "cups07",
            "What would you do if your dreams came true?",
            ["searching for purpose", "choices", "daydreaming"],
            "Focus on what is important.",
            ["lack of purpose", "diversion", "confusion"]
        ),
        new(
            "Eight of Cups",
            "cups08",
            "Look for what is missing.",
            ["walking away", "disillusionment", "leaving behind"],
            "Try one more time.",
            ["avoidance", "fear of change", "fear of loss"]
        ),
        new(
            "Nine of Cups",
            "cups09",
            "Be thankful for what you have.",
            ["satisfaction", "emotional stability", "luxury"],
            "Get rid of something.",
            ["lack of inner joy", "smugness", "dissatisfaction"]
        ),
        new(
            "Ten of Cups",
            "cups10",
            "Create something harmonious.",
            ["inner happiness", "fulfillment", "dreams coming true"],
            "Ensure there is discordance.",
            ["shattered dreams", "broken family", "domestic disharmony"]
        ),
        new(
            "Page of Cups",
            "cups11",
            "Accept an opportunity.",
            ["happy surprise", "dreamer", "sensitivity"],
            "Reject an opportunity.",
            ["emotional immaturity", "insecurity", "disappointment"]
        ),
        new(
            "Knight of Cups",
            "cups12",
            "Think of who you admire.",
            ["following the heart", "idealist", "romantic"],
            "Do something unrealistic.",
            ["moodiness", "disappointment"]
        ),
        new(
            "Queen of Cups",
            "cups13",
            "Block off some focus time.",
            ["compassion", "calm", "comfort"],
            "What would look impressive?",
            ["martyrdom", "insecurity", "dependence"]
        ),
        new(
            "King of Cups",
            "cups14",
            "Balance emotion with ruthlessness.",
            ["compassion", "control", "balance"],
            "Embrace ambiguity.",
            ["coldness", "moodiness", "bad advice"]
        ),
        new(
            "Ace of Swords",
            "swords01",
            "This will take more research.",
            ["breakthrough", "clarity", "sharp mind"],
            "Insert an unexpected twist into the plan.",
            ["confusion", "brutality", "chaos"]
        ),
        new(
            "Two of Swords",
            "swords02",
            "Add frosting to the cake now.",
            ["difficult choices", "indecision", "stalemate"],
            "Open your eyes; take in reality mindfully.",
            ["lesser of two evils", "no right choice", "confusion"]
        ),
        new(
            "Three of Swords",
            "swords03",
            "Do it even if it hurts.",
            ["heartbreak", "suffering", "grief"],
            "Lower your expectations.",
            ["recovery", "forgiveness", "moving on"]
        ),
        new(
            "Four of Swords",
            "swords04",
            "Take a step back; re-assess your priorities.",
            ["rest", "restoration", "contemplation"],
            "Work on it until you are sick of it.",
            ["restlessness", "burnout", "stress"]
        ),
        new(
            "Five of Swords",
            "swords05",
            "Is this the hill you want to die on?",
            ["unbridled ambition", "win at all costs", "sneakiness"],
            "Do it even if at the expense of others.",
            ["lingering resentment", "desire to reconcile", "forgiveness"]
        ),
        new(
            "Six of Swords",
            "swords06",
            "Inject a transition.",
            ["transition", "leaving behind", "moving on"],
            "Resist the new.",
            ["emotional baggage", "unresolved issues", "resisting transition"]
        ),
        new(
            "Seven of Swords",
            "swords07",
            "Copy someone else's solution.",
            ["deception", "trickery", "tactics and strategy"],
            "Do it covertly.",
            ["coming clean", "rethinking approach", "deception"]
        ),
        new(
            "Eight of Swords",
            "swords08",
            "Do something unexpected.",
            ["imprisonment", "entrapment", "self-victimization"],
            "Walk around it slowly; look at it from the outside.",
            ["self acceptance", "new perspective", "freedom"]
        ),
        new(
            "Nine of Swords",
            "swords09",
            "Tend to what makes it hard to sleep.",
            ["anxiety", "hopelessness", "trauma"],
            "Share a secret.",
            ["hope", "reaching out", "despair"]
        ),
        new(
            "Ten of Swords",
            "swords10",
            "Stop feeling like a victim; accept and take control.",
            ["failure", "collapse", "defeat"],
            "Change is inevitable; rip off the band-aid.",
            ["can't get worse", "only upwards", "inevitable end"]
        ),
        new(
            "Page of Swords",
            "swords11",
            "Learn something new.",
            ["curiosity", "restlessness", "mental energy"],
            "Make a very ambitious plan.",
            ["deception", "manipulation", "all talk"]
        ),
        new(
            "Knight of Swords",
            "swords12",
            "Delete it all; start over.",
            ["action", "impulsiveness", "defending beliefs"],
            "Sit and watch it unfold.",
            ["no direction", "disregard for consequences", "unpredictability"]
        ),
        new(
            "Queen of Swords",
            "swords13",
            "List pros and cons.",
            ["complexity", "perceptiveness", "clear mindedness"],
            "Change your mind; be mercurial.",
            ["cold hearted", "cruel", "bitterness"]
        ),
        new(
            "King of Swords",
            "swords14",
            "Pretend you have full authority.",
            ["head over heart", "discipline", "truth"],
            "Resign all authority.",
            ["manipulative", "cruel", "weakness"]
        ),
        new(
            "Ace of Pentacles",
            "pents01",
            "Grab the money without thinking.",
            ["opportunity", "prosperity", "new venture"],
            "Let the opportunity pass you by.",
            ["lost opportunity", "missed chance", "bad investment"]
        ),
        new(
            "Two of Pentacles",
            "pents02",
            "Increase concurrency.",
            ["balancing decisions", "priorities", "adapting to change"],
            "Reduce concurrency.",
            ["loss of balance", "disorganized", "overwhelmed"]
        ),
        new(
            "Three of Pentacles",
            "pents03",
            "Broaden the team.",
            ["teamwork", "collaboration", "building"],
            "Step on some toes.",
            ["lack of teamwork", "disorganized", "group conflict"]
        ),
        new(
            "Four of Pentacles",
            "pents04",
            "Conserve what you have.",
            ["conservation", "frugality", "security"],
            "Re-evaluate your risk tolerance.",
            ["greediness", "stinginess", "possessiveness"]
        ),
        new(
            "Five of Pentacles",
            "pents05",
            "Pretend you have nothing.",
            ["need", "poverty", "insecurity"],
            "Focus on recovering what you lost.",
            ["recovery", "charity", "improvement"]
        ),
        new(
            "Six of Pentacles",
            "pents06",
            "Share generously.",
            ["charity", "generosity", "sharing"],
            "Remove one from each.",
            ["strings attached", "stinginess", "power and domination"]
        ),
        new(
            "Seven of Pentacles",
            "pents07",
            "Focus on long-term sustainability.",
            ["hard work", "perseverance", "diligence"],
            "Get to short-term results quickly.",
            ["work without results", "distractions", "lack of rewards"]
        ),
        new(
            "Eight of Pentacles",
            "pents08",
            "Don't worry about repetition.",
            ["apprenticeship", "passion", "high standards"],
            "Be a perfectionist.",
            ["lack of passion", "uninspired", "no motivation"]
        ),
        new(
            "Nine of Pentacles",
            "pents09",
            "You don't need more.",
            ["fruits of labor", "rewards", "luxury"],
            "Put in more time.",
            ["reckless spending", "living beyond means", "false success"]
        ),
        new(
            "Ten of Pentacles",
            "pents10",
            "Ask your family.",
            ["legacy", "culmination", "inheritance"],
            "Stay late.",
            ["fleeting success", "lack of stability", "lack of resources"]
        ),
        new(
            "Page of Pentacles",
            "pents11",
            "Practice a skill.",
            ["ambition", "desire", "diligence"],
            "Blame someone else.",
            ["lack of commitment", "greediness", "laziness"]
        ),
        new(
            "Knight of Pentacles",
            "pents12",
            "Make things the way they were before.",
            ["efficiency", "hard work", "responsibility"],
            "Allow yourself to get bored.",
            ["laziness", "obsessiveness", "work without reward"]
        ),
        new(
            "Queen of Pentacles",
            "pents13",
            "Don't kill your darlings.",
            ["practicality", "creature comforts", "financial security"],
            "Give yourself more spare time.",
            ["self-centeredness", "jealousy", "smothering"]
        ),
        new(
            "King of Pentacles",
            "pents14",
            "Think like a CEO.",
            ["abundance", "prosperity", "security"],
            "Abandon all hope.",
            ["greed", "indulgence", "sensuality"]
        ),
        new(
            "Ace of Wands",
            "wands01",
            "Harvest what you planted last year.",
            ["creation", "willpower", "inspiration", "desire"],
            "Lean into a distraction.",
            ["lack of energy", "lack of passion", "boredom"]
        ),
        new(
            "Two of Wands",
            "wands02",
            "Make a roadmap.",
            ["planning", "making decisions", "leaving home"],
            "Avoid uncertainties.",
            ["fear of change", "playing safe", "bad planning"]
        ),
        new(
            "Three of Wands",
            "wands03",
            "Expand the scope.",
            ["looking ahead", "expansion", "rapid growth"],
            "Reduce the scope.",
            ["obstacles", "delays", "frustration"]
        ),
        new(
            "Four of Wands",
            "wands04",
            "Celebrate what you have accomplished so far.",
            ["community", "home", "celebration"],
            "Enjoy a beverage quietly.",
            ["lack of support", "transience", "home conflicts"]
        ),
        new(
            "Five of Wands",
            "wands05",
            "Lean into conflict.",
            ["competition", "rivalry", "conflict"],
            "Avoid conflict at all costs.",
            ["avoiding conflict", "respecting differences"]
        ),
        new(
            "Six of Wands",
            "wands06",
            "Give yourself a prize for a part of it.",
            ["victory", "success", "public reward"],
            "Disregard others and aim for personal goals.",
            ["excess pride", "lack of recognition", "punishment"]
        ),
        new(
            "Seven of Wands",
            "wands07",
            "Defend your controversial ideas.",
            ["perseverance", "defensive", "maintaining control"],
            "Abandon your controversial ideas.",
            ["give up", "destroyed confidence", "overwhelmed"]
        ),
        new(
            "Eight of Wands",
            "wands08",
            "Follow the path of least resistance.",
            ["rapid action", "movement", "quick decisions"],
            "Find the critical flaw in your idea.",
            ["panic", "waiting", "slowdown"]
        ),
        new(
            "Nine of Wands",
            "wands09",
            "Keep to the tried-and-true.",
            ["resilience", "grit", "last stand"],
            "What if they are actually out to get you?",
            ["exhaustion", "fatigue", "questioning motivations"]
        ),
        new(
            "Ten of Wands",
            "wands10",
            "Help someone else with their problem.",
            ["accomplishment", "responsibility", "burden"],
            "Delegate your problem.",
            ["inability to delegate", "overstressed", "burnt out"]
        ),
        new(
            "Page of Wands",
            "wands11",
            "Read a book.",
            ["exploration", "excitement", "freedom"],
            "Try it in a pet project.",
            ["lack of direction", "procrastination", "creating conflict"]
        ),
        new(
            "Knight of Wands",
            "wands12",
            "What would a high-energy state look like?",
            ["action", "adventure", "fearlessness"],
            "What would a high-entropy state look like?",
            ["anger", "impulsiveness", "recklessness"]
        ),
        new(
            "Queen of Wands",
            "wands13",
            "Instigate others to join you.",
            ["courage", "determination", "joy"],
            "Find yourself again.",
            ["selfishness", "jealousy", "insecurities"]
        ),
        new(
            "King of Wands",
            "wands14",
            "What would an entrepreneur do?",
            ["big picture", "leader", "overcoming challenges"],
            "Write down your expectations.",
            ["impulsive", "overbearing", "unachievable expectations"]
        ),
    ];
    #endregion

    public TarotCard Create() {
        Random random = new();

        return _cards[random.Next(_cards.Count)];
    }
}

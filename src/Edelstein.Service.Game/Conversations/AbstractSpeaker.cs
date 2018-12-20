using System.Threading.Tasks;
using Edelstein.Service.Game.Conversations.Messages;

namespace Edelstein.Service.Game.Conversations
{
    public abstract class AbstractSpeaker : ISpeaker
    {
        private readonly IConversationContext _context;

        public abstract byte TypeID { get; }
        public abstract int TemplateID { get; }
        public abstract ScriptMessageParam Param { get; }

        public AbstractSpeaker(IConversationContext context)
            => _context = context;

        public byte Say(string text = "", bool prev = false, bool next = false)
            => SayAsync(text, prev, next).Result;

        public bool AskYesNo(string text = "")
            => AskYesNoAsync(text).Result;

        public bool AskAccept(string text = "")
            => AskAcceptAsync(text).Result;

        public string AskText(string text = "", string def = "", short lenMin = 0, short lenMax = short.MaxValue)
            => AskTextAsync(text, def, lenMin, lenMax).Result;

        public string AskBoxText(string text = "", string def = "", short cols = 24, short rows = 4)
            => AskBoxTextAsync(text, def, cols, rows).Result;

        public int AskNumber(string text = "", int def = 0, int min = int.MinValue, int max = int.MaxValue)
            => AskNumberAsync(text, def, min, max).Result;

        public Task<byte> SayAsync(string text = "", bool prev = false, bool next = false)
            => _context.Send<byte>(new SayMessage(this, text, prev, next));

        public Task<bool> AskYesNoAsync(string text = "")
            => _context.Send<bool>(new AskYesNoMessage(this, text));

        public Task<bool> AskAcceptAsync(string text = "")
            => _context.Send<bool>(new AskAcceptMessage(this, text));

        public Task<string> AskTextAsync(string text = "", string def = "", short lenMin = 0,
            short lenMax = short.MaxValue)
            => _context.Send<string>(new AskTextMessage(this, text, def, lenMin, lenMax));

        public Task<string> AskBoxTextAsync(string text = "", string def = "", short cols = 24, short rows = 4)
            => _context.Send<string>(new AskBoxTextMessage(this, text, def, cols, rows));

        public Task<int> AskNumberAsync(string text = "", int def = 0, int min = int.MinValue, int max = int.MaxValue)
            => _context.Send<int>(new AskNumberMessage(this, text, def, min, max));
    }
}
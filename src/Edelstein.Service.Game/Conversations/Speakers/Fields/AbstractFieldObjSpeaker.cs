using Edelstein.Service.Game.Fields;

namespace Edelstein.Service.Game.Conversations.Speakers.Fields
{
    public abstract class AbstractFieldObjSpeaker<T> : AbstractSpeaker
        where T : IFieldObj
    {
        public T Obj { get; }

        protected AbstractFieldObjSpeaker(IConversationContext context, T obj) : base(context)
            => Obj = obj;

        public FieldSpeaker GetField() => new FieldSpeaker(Context, Obj.Field);
    }
}
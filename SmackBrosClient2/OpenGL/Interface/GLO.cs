using System;
using System.Collections.Concurrent;

namespace NeptuneRenderEngine.Engine.Interface
{
// ReSharper disable InconsistentNaming
    public abstract class GLO
// ReSharper restore InconsistentNaming
    {
        private readonly string _typeString;
        protected GLO(string typeString, int defaultID = 0)
        {
            _typeString = typeString;
            _id = defaultID;
        }

        private int _id;
        public int ID
        {
            get
            {
                if (_id <= 0)
                {
                    _id = Generate();
                }
                return _id;
            }
        }

        protected abstract int Generate();

        public virtual void Regenerate()
        {
            Delete();
            _id = 0;
        }

        public void Bind()
        {
            Bind(ID);
        }

        public abstract void Bind(int id);

        public abstract void Delete();

        public override string ToString()
        {
            return string.Format("({0}): {1}", _typeString, ID);
        }
    }

    public static class BindingHelper<T> where T : GLO, new()
    {
        private readonly static ConcurrentStack<T> BindingStack;

        private static readonly T DefaultT;

        static BindingHelper()
        {
            BindingStack = new ConcurrentStack<T>();
            DefaultT = new T();
        }

        public static void Bind(T t)
        {
            BindingStack.Clear();
            if (t == null) {DefaultT.Bind(0); return;}
            t.Bind();
        }

        public static void Push(T t)
        {
            if (t == null) { DefaultT.Bind(0); BindingStack.Push(DefaultT); return; }
            t.Bind();
            BindingStack.Push(t);
        }

        public static T Pop()
        {
            T t;
            if (BindingStack.TryPop(out t))
            {
                T tPeek;
                if (BindingStack.TryPeek(out tPeek))
                {
                    tPeek.Bind();
                }
                else
                {
                    DefaultT.Bind(0);
                }
                return t;
            }
            DefaultT.Bind(0);

            return default(T);
        }

        public static void Use(T t, Action<T> action)
        {
            Push(t);

            action(t);
#if DEBUG
            var pop = Pop();
            if (t != pop)
            {
                throw new GLException(
                    string.Format(
                        "Use action is leaking bindings! Type '{0} with id '{1}' was not equal to resulting type '{0}' with id '{2}'",
                        typeof (T).Name, t.ID, pop.ID));
            }
#else
            Pop();
#endif

        }
    }
}

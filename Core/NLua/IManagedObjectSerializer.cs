using System;

namespace NLua
{
    public interface IManagedObjectSerializer
    {
		bool Serialize(Lua luaState, object obj, out object serializedObject);
    }
}


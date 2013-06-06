using System;

namespace NLua
{
    public interface IManagedObjectSecurityPolicy
    {
		bool PermitAccessToObject(object obj);
		bool PermitObjectConstruction(Type type);
		bool PermitAccessToStaticMembers(Type type);
    }
}


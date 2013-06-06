using System;

namespace NLua
{
    public class SimpleManagedObjectSecurityPolicy : IManagedObjectSecurityPolicy
    {
		private static readonly SimpleManagedObjectSecurityPolicy permitAll = new SimpleManagedObjectSecurityPolicy(true);
		private static readonly SimpleManagedObjectSecurityPolicy denyAll = new SimpleManagedObjectSecurityPolicy(false);

		public static IManagedObjectSecurityPolicy PermitAll
		{
			get { return permitAll; }
		}

		public static IManagedObjectSecurityPolicy DenyAll
		{
			get { return denyAll; }
		}

		private bool policy;

        private SimpleManagedObjectSecurityPolicy(bool policy)
		{
			this.policy = policy;
		}

		#region IManagedObjectSecurity implementation

		public bool PermitAccessToObject(object obj)
		{
			return policy;
		}

		public bool PermitObjectConstruction(Type type)
		{
			return policy;
		}

		public bool PermitAccessToStaticMembers(Type type)
		{
			return policy;
		}

		#endregion
    }
}


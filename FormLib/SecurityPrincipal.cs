using System;
using System.Threading;
using System.Security.Principal;

	/// <summary>
	/// Summary description for CheckUsersRight.
	/// </summary>
namespace SecurityLibrary
{
	public sealed class SecurityPrincipal
	{
		public static string GetUserName()
		{
			AppDomain.CurrentDomain.SetPrincipalPolicy(System.Security.Principal.PrincipalPolicy.WindowsPrincipal);
			WindowsPrincipal principal = (WindowsPrincipal)Thread.CurrentPrincipal;
			WindowsIdentity identity = (WindowsIdentity)principal.Identity;

			//имя пользователя с учётом домена

			string UserName = identity.Name;
			//имя пользователя без учёта домена
			//UserName = System.Environment.UserName;
			return UserName;
		}
		public static string GetUserNameShort()
		{
			return System.Environment.UserName;
		}
		public static string GetUserRights()
		{
			string _WindowsBuiltInRole = "unknown";

			AppDomain.CurrentDomain.SetPrincipalPolicy(System.Security.Principal.PrincipalPolicy.WindowsPrincipal);
			WindowsPrincipal principal = (WindowsPrincipal)Thread.CurrentPrincipal;
			WindowsIdentity identity = (WindowsIdentity)principal.Identity;

			IdentityReferenceCollection BuiltInRol = new IdentityReferenceCollection();
			BuiltInRol = identity.Groups;

			if (principal.IsInRole(WindowsBuiltInRole.Administrator) == true)
				_WindowsBuiltInRole = "Administrator";

			if (principal.IsInRole(WindowsBuiltInRole.Guest) == true)
				_WindowsBuiltInRole = "Guest";

			if (principal.IsInRole(WindowsBuiltInRole.User) == true)
				_WindowsBuiltInRole = "User";

			return _WindowsBuiltInRole;
		}
	}
}


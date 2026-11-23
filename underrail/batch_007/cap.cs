using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Ouroboros.Core.Logging;

// Token: 0x02000650 RID: 1616
public static class cap
{
	// Token: 0x06002911 RID: 10513 RVA: 0x000EA498 File Offset: 0x000E8698
	public static void a()
	{
		if (!cap.a)
		{
			cap.b = new Dictionary<string, bsb>();
			foreach (Type type in bpo.GetServiceOrThrow<ei2>().av2(new Func<Type, bool>(cap.a.a.a)))
			{
				try
				{
					if (type.IsClass && !type.IsAbstract)
					{
						if (type.GetConstructor(Type.EmptyTypes) != null)
						{
							bsb bsb = (bsb)Activator.CreateInstance(type);
							cap.b.Add(bsb.hn(), bsb);
						}
						else
						{
							dux.b(LogSeverity.Error, "GlobalEntityProviderManager: Failed to instantiated global entity provider {0}. Default constructor not found.", new object[]
							{
								type.AssemblyQualifiedName
							});
						}
					}
				}
				catch (Exception a_)
				{
					dux.a(LogSeverity.Error, a_, "GlobalEntityProviderManager: Failed to instantiated global entity provider.", new object[0]);
				}
			}
			cap.a = true;
		}
	}

	// Token: 0x06002912 RID: 10514 RVA: 0x000EA5C0 File Offset: 0x000E87C0
	public static bsb a(string A_0)
	{
		cap.a();
		bsb result;
		cap.b.TryGetValue(A_0, out result);
		return result;
	}

	// Token: 0x0400166A RID: 5738
	private static bool a;

	// Token: 0x0400166B RID: 5739
	private static Dictionary<string, bsb> b;

	// Token: 0x02000651 RID: 1617
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06002915 RID: 10517 RVA: 0x000EA5F8 File Offset: 0x000E87F8
		internal bool a(Type A_0)
		{
			return typeof(bsb).IsAssignableFrom(A_0);
		}

		// Token: 0x0400166C RID: 5740
		public static readonly cap.a a = new cap.a();

		// Token: 0x0400166D RID: 5741
		public static Func<Type, bool> b;
	}
}

using System;
using Ouroboros.Core.Logging;

// Token: 0x02001334 RID: 4916
public static class dv0
{
	// Token: 0x06006F5A RID: 28506 RVA: 0x002EC06C File Offset: 0x002EA26C
	public static cze a(string A_0)
	{
		if (!string.IsNullOrWhiteSpace(A_0))
		{
			Type type = bpo.GetServiceOrThrow<ei2>().av3(A_0, "X", false);
			if (type != null)
			{
				try
				{
					cze cze = Activator.CreateInstance(type) as cze;
					if (cze == null)
					{
						dux.b(LogSeverity.Warning, "Attempted to create a job instance from a type that is not a job: '{0}' (DM: '{1}')", new object[]
						{
							type.FullName,
							A_0
						});
					}
					return cze;
				}
				catch (Exception a_)
				{
					dux.a(LogSeverity.Error, a_, "Failed to create an instance of a job of type '{0}' (DM: '{1}').", new object[]
					{
						type.FullName,
						A_0
					});
					goto IL_9D;
				}
			}
			return ea5.a(A_0);
		}
		dux.b(LogSeverity.Warning, "Attempted to create instance of nameless job.", new object[0]);
		IL_9D:
		return null;
	}

	// Token: 0x06006F5B RID: 28507 RVA: 0x002EC12C File Offset: 0x002EA32C
	public static void a(cqh A_0)
	{
		if (A_0 != null && A_0.OnReadJobs != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
			{
				foreach (string a_ in A_0.OnReadJobs)
				{
					cze cze = dv0.a(a_);
					if (cze != null)
					{
						cze.ym(serviceOrThrow.aqu().v().b(), null, null);
					}
				}
			}
		}
	}
}

using System;
using Ouroboros.Core.Logging;

// Token: 0x0200122C RID: 4652
public static class a4p
{
	// Token: 0x0600644B RID: 25675 RVA: 0x002B1544 File Offset: 0x002AF744
	public static cf9 a(els A_0)
	{
		if (!A_0.ControllerActivated)
		{
			A_0.Controller = a4p.a(A_0.ControllerName);
			A_0.ControllerActivated = true;
		}
		return A_0.Controller as cf9;
	}

	// Token: 0x0600644C RID: 25676 RVA: 0x002B1580 File Offset: 0x002AF780
	public static cf9 a(string A_0)
	{
		if (!string.IsNullOrWhiteSpace(A_0))
		{
			Type type = bpo.GetServiceOrThrow<ei2>().av3(A_0, "X", false);
			if (type != null)
			{
				try
				{
					cf9 cf = Activator.CreateInstance(type) as cf9;
					if (cf == null)
					{
						dux.b(LogSeverity.Warning, "Attempted to create a status effect controller instance instance from a type that is not a IStatusEffectController: '{0}' (DM: '{1}')", new object[]
						{
							type.FullName,
							A_0
						});
					}
					return cf;
				}
				catch (Exception a_)
				{
					dux.a(LogSeverity.Error, a_, "Failed to create an instance of a status effect controller of type '{0}' (DM: '{1}').", new object[]
					{
						type.FullName,
						A_0
					});
				}
			}
		}
		return null;
	}
}

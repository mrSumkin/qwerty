using System;

// Token: 0x020000B2 RID: 178
public sealed class vi
{
	// Token: 0x06000416 RID: 1046 RVA: 0x00013710 File Offset: 0x00011910
	public static object a(Delegate A_0, AppDomain A_1, params object[] A_2)
	{
		if (!A_0.Method.IsStatic)
		{
			throw new Exception("Method has to be static in order to run in new application domain!");
		}
		vi.a a = new vi.a(A_0, A_2, A_0.GetHashCode());
		A_1.DoCallBack(new CrossAppDomainDelegate(a.Invoke));
		return A_1.GetData("appDomainResult" + A_0.GetHashCode().ToString());
	}

	// Token: 0x06000417 RID: 1047 RVA: 0x00013778 File Offset: 0x00011978
	public static object b(Delegate A_0, params object[] A_1)
	{
		AppDomain appDomain = AppDomain.CreateDomain("domain_RunInAppDomain" + A_0.GetHashCode().ToString());
		object result = null;
		try
		{
			result = vi.a(A_0, appDomain, A_1);
		}
		finally
		{
			AppDomain.Unload(appDomain);
		}
		return result;
	}

	// Token: 0x06000418 RID: 1048 RVA: 0x000137CC File Offset: 0x000119CC
	public static object a(Delegate A_0, params object[] A_1)
	{
		AppDomainSetup appDomainSetup = new AppDomainSetup();
		appDomainSetup.ApplicationBase = AppDomain.CurrentDomain.BaseDirectory;
		AppDomain appDomain = AppDomain.CreateDomain("domain_RunInAppDomain" + A_0.GetHashCode().ToString(), null, appDomainSetup);
		object result = null;
		try
		{
			result = vi.a(A_0, appDomain, A_1);
		}
		finally
		{
			AppDomain.Unload(appDomain);
		}
		return result;
	}

	// Token: 0x020000B3 RID: 179
	[Serializable]
	internal class a
	{
		// Token: 0x0600041A RID: 1050 RVA: 0x00013840 File Offset: 0x00011A40
		public a(Delegate A_0, object[] A_1, int A_2)
		{
			this.a = A_0;
			this.b = A_1;
			this.c = A_2;
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00013860 File Offset: 0x00011A60
		public void Invoke()
		{
			if (this.a != null)
			{
				AppDomain.CurrentDomain.SetData("appDomainResult" + this.c.ToString(), this.a.DynamicInvoke(this.b));
			}
		}

		// Token: 0x04000434 RID: 1076
		private Delegate a;

		// Token: 0x04000435 RID: 1077
		private object[] b;

		// Token: 0x04000436 RID: 1078
		private int c;
	}
}

using System;

// Token: 0x0200115B RID: 4443
public static class eh5
{
	// Token: 0x06005F1F RID: 24351 RVA: 0x002855D8 File Offset: 0x002837D8
	public static bool a(string A_0)
	{
		return eh5.b() != null && eh5.b().StatusEffects.a(A_0);
	}

	// Token: 0x06005F20 RID: 24352 RVA: 0x002855F8 File Offset: 0x002837F8
	public static au2 b()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			return serviceOrThrow.aqu().v();
		}
		return null;
	}

	// Token: 0x06005F21 RID: 24353 RVA: 0x00285624 File Offset: 0x00283824
	public static c5x a()
	{
		au2 au = eh5.b();
		if (au != null)
		{
			return au.b() as c5x;
		}
		return null;
	}
}

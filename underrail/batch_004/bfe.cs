using System;

// Token: 0x020007CB RID: 1995
public static class bfe
{
	// Token: 0x0600320F RID: 12815 RVA: 0x00133BA8 File Offset: 0x00131DA8
	public static c5x a(c5x A_0, float A_1 = 1f, float A_2 = 0.75f)
	{
		if (A_0 != null)
		{
			a6p aspect = A_0.GetAspect<a6p>();
			if (aspect != null)
			{
				aspect.d().Add("-modifiers");
			}
			amc aspect2 = A_0.GetAspect<amc>();
			if (aspect2 != null)
			{
				aspect2.aa().BaseMovementSpeed = (float)cuo.a.NextDouble() * (A_1 - A_2) + A_2;
				aspect2.aa().bl();
			}
		}
		return A_0;
	}

	// Token: 0x06003210 RID: 12816 RVA: 0x00133C10 File Offset: 0x00131E10
	public static c5x a(c5x A_0, bool A_1 = false)
	{
		if (A_0 != null && A_0.h.b != null && A_0.h.b.aa().Vehicle != null)
		{
			A_0.h.b.aa().Vehicle.b(A_1);
		}
		return A_0;
	}
}

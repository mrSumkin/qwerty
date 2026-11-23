using System;

// Token: 0x02001B64 RID: 7012
public sealed class c6r : cb6
{
	// Token: 0x060097E8 RID: 38888 RVA: 0x003B2D20 File Offset: 0x003B0F20
	public c6r(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060097E9 RID: 38889 RVA: 0x003B2D30 File Offset: 0x003B0F30
	public int aha()
	{
		return this.a;
	}

	// Token: 0x060097EA RID: 38890 RVA: 0x003B2D3C File Offset: 0x003B0F3C
	public bool ahb(coh A_0)
	{
		fv fv = A_0 as fv;
		return fv != null && fv.TypedDefinition.i() == ms.d && fv.Definition.a7().GetPrimitivePropertyValue<int>("Infusion", new int?(0)).Value == 0;
	}

	// Token: 0x04003A4F RID: 14927
	private int a;
}

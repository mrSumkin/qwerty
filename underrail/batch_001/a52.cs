using System;

// Token: 0x02001901 RID: 6401
public sealed class a52 : bp2
{
	// Token: 0x060087F8 RID: 34808 RVA: 0x00385850 File Offset: 0x00383A50
	public bool cx(coh A_0)
	{
		return A_0 != null && A_0.Definition != null && (A_0.Definition is dgr || A_0.Definition is sz);
	}

	// Token: 0x060087F9 RID: 34809 RVA: 0x00385888 File Offset: 0x00383A88
	public override string ToString()
	{
		return "Боеприпасы";
	}
}

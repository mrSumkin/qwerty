using System;

// Token: 0x02001B66 RID: 7014
public sealed class e00 : cb6
{
	// Token: 0x060097EE RID: 38894 RVA: 0x003B2DF4 File Offset: 0x003B0FF4
	public e00(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060097EF RID: 38895 RVA: 0x003B2E04 File Offset: 0x003B1004
	public int aha()
	{
		return this.a;
	}

	// Token: 0x060097F0 RID: 38896 RVA: 0x003B2E10 File Offset: 0x003B1010
	public bool ahb(coh A_0)
	{
		return A_0 != null && A_0.Definition != null && !A_0.Definition.a9() && A_0.MaxDurability > 0 && !A_0.Definition.bb();
	}

	// Token: 0x04003A51 RID: 14929
	private int a;
}

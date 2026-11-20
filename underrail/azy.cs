using System;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001E2F RID: 7727
public sealed class azy : ValueBasedRequirement<int>
{
	// Token: 0x0600AB39 RID: 43833 RVA: 0x003F6070 File Offset: 0x003F4270
	public azy(int A_0) : base(A_0)
	{
	}

	// Token: 0x0600AB3A RID: 43834 RVA: 0x003F607C File Offset: 0x003F427C
	public override int og()
	{
		return base.c();
	}

	// Token: 0x0600AB3B RID: 43835 RVA: 0x003F6084 File Offset: 0x003F4284
	public override bool oh(efk A_0)
	{
		czh.a(A_0, "character");
		return A_0.Level >= base.c();
	}

	// Token: 0x0600AB3C RID: 43836 RVA: 0x003F60A4 File Offset: 0x003F42A4
	public override string ToString()
	{
		return dh9.c("Level") + " " + base.c().ToString();
	}
}

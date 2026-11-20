using System;
using TimelapseVertigo.Rules.Comm;

// Token: 0x020016A3 RID: 5795
[d1q("empGrenade")]
public sealed class bcr : as9
{
	// Token: 0x06007E86 RID: 32390 RVA: 0x00358358 File Offset: 0x00356558
	protected override string hq()
	{
		return "empGrenade";
	}

	// Token: 0x06007E87 RID: 32391 RVA: 0x00358360 File Offset: 0x00356560
	protected override CombatSpeakEvent[] hr()
	{
		return new CombatSpeakEvent[]
		{
			CombatSpeakEvent.Battlecry_Emp
		};
	}

	// Token: 0x06007E88 RID: 32392 RVA: 0x00358370 File Offset: 0x00356570
	protected override double hs()
	{
		return (double)aju.bd;
	}

	// Token: 0x06007E89 RID: 32393 RVA: 0x00358378 File Offset: 0x00356578
	protected override cuu ht()
	{
		return new dug();
	}

	// Token: 0x06007E8A RID: 32394 RVA: 0x00358380 File Offset: 0x00356580
	protected override blv hu()
	{
		return bby.c();
	}

	// Token: 0x06007E8B RID: 32395 RVA: 0x00358388 File Offset: 0x00356588
	protected override int hv()
	{
		return bby.b();
	}

	// Token: 0x06007E8C RID: 32396 RVA: 0x00358390 File Offset: 0x00356590
	protected override string hw()
	{
		return bby.a();
	}

	// Token: 0x06007E8D RID: 32397 RVA: 0x00358398 File Offset: 0x00356598
	protected override string w0()
	{
		return "EmpBlast";
	}
}

using System;
using System.Collections.Generic;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001E7E RID: 7806
[ayj("closeVent")]
public sealed class ao1 : m0
{
	// Token: 0x0600AE35 RID: 44597 RVA: 0x003FC010 File Offset: 0x003FA210
	public override string y8()
	{
		return "Закрыть вентиляционную решётку";
	}

	// Token: 0x0600AE36 RID: 44598 RVA: 0x003FC018 File Offset: 0x003FA218
	public override string os()
	{
		return "closeVent";
	}

	// Token: 0x0600AE37 RID: 44599 RVA: 0x003FC020 File Offset: 0x003FA220
	public override ci8 bg()
	{
		return ci8.a;
	}

	// Token: 0x0600AE38 RID: 44600 RVA: 0x003FC024 File Offset: 0x003FA224
	public override TimelapseCursor? bj()
	{
		return new TimelapseCursor?(TimelapseCursor.Lockpick);
	}

	// Token: 0x0600AE39 RID: 44601 RVA: 0x003FC030 File Offset: 0x003FA230
	public override string c1()
	{
		return "Закрывает";
	}

	// Token: 0x0600AE3A RID: 44602 RVA: 0x003FC038 File Offset: 0x003FA238
	public override bool q2()
	{
		return false;
	}

	// Token: 0x0600AE3C RID: 44604 RVA: 0x003FC044 File Offset: 0x003FA244
	public override string bm(cnm A_0)
	{
		return "Abilities.23";
	}

	// Token: 0x0600AE3D RID: 44605 RVA: 0x003FC04C File Offset: 0x003FA24C
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.OpenVentilationShaft;
	}

	// Token: 0x0600AE3E RID: 44606 RVA: 0x003FC050 File Offset: 0x003FA250
	public override string bo(cnm A_0)
	{
		return "Закрывает вентиляционную решётку.";
	}

	// Token: 0x0600AE3F RID: 44607 RVA: 0x003FC058 File Offset: 0x003FA258
	public override string bp(cnm A_0)
	{
		return "Закрывает вентиляционную решётку.";
	}

	// Token: 0x0600AE40 RID: 44608 RVA: 0x003FC060 File Offset: 0x003FA260
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return d7f.o;
	}

	// Token: 0x0600AE41 RID: 44609 RVA: 0x003FC068 File Offset: 0x003FA268
	public override IList<string> bi()
	{
		return d7f.p;
	}

	// Token: 0x0600AE42 RID: 44610 RVA: 0x003FC070 File Offset: 0x003FA270
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}

	// Token: 0x0600AE43 RID: 44611 RVA: 0x003FC074 File Offset: 0x003FA274
	protected override int br(cnm A_0)
	{
		return 10000;
	}

	// Token: 0x0600AE44 RID: 44612 RVA: 0x003FC07C File Offset: 0x003FA27C
	protected override float f0(cnm A_0)
	{
		return as3.bk;
	}
}

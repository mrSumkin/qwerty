using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001EDE RID: 7902
[ayj("ThrowCarriedObject")]
public sealed class b0t : c0z
{
	// Token: 0x0600B387 RID: 45959 RVA: 0x004069E0 File Offset: 0x00404BE0
	public override string y8()
	{
		return "Бросок взятого объекта";
	}

	// Token: 0x0600B388 RID: 45960 RVA: 0x004069E8 File Offset: 0x00404BE8
	public override string os()
	{
		return "ThrowCarriedObject";
	}

	// Token: 0x0600B389 RID: 45961 RVA: 0x004069F0 File Offset: 0x00404BF0
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B38A RID: 45962 RVA: 0x004069F4 File Offset: 0x00404BF4
	public override int e8()
	{
		return 1;
	}

	// Token: 0x0600B38B RID: 45963 RVA: 0x004069F8 File Offset: 0x00404BF8
	public override string c1()
	{
		return "Бросает";
	}

	// Token: 0x0600B38C RID: 45964 RVA: 0x00406A00 File Offset: 0x00404C00
	public b0t()
	{
		this.a = new List<string>();
	}

	// Token: 0x0600B38D RID: 45965 RVA: 0x00406A14 File Offset: 0x00404C14
	public override string bm(cnm A_0)
	{
		return "Misc.0";
	}

	// Token: 0x0600B38E RID: 45966 RVA: 0x00406A1C File Offset: 0x00404C1C
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.DiscoveredPenetrableSpot;
	}

	// Token: 0x0600B38F RID: 45967 RVA: 0x00406A20 File Offset: 0x00404C20
	public override string bo(cnm A_0)
	{
		return "";
	}

	// Token: 0x0600B390 RID: 45968 RVA: 0x00406A28 File Offset: 0x00404C28
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>();
	}

	// Token: 0x0600B391 RID: 45969 RVA: 0x00406A30 File Offset: 0x00404C30
	public override IList<string> bi()
	{
		return this.a;
	}

	// Token: 0x0600B392 RID: 45970 RVA: 0x00406A38 File Offset: 0x00404C38
	protected override int br(cnm A_0)
	{
		return 1000;
	}

	// Token: 0x0600B393 RID: 45971 RVA: 0x00406A40 File Offset: 0x00404C40
	protected override float f0(cnm A_0)
	{
		return 10f;
	}

	// Token: 0x0600B394 RID: 45972 RVA: 0x00406A48 File Offset: 0x00404C48
	protected override int hi(cnm A_0)
	{
		return 1;
	}

	// Token: 0x0400419B RID: 16795
	private new List<string> a;
}

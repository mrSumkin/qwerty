using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001E81 RID: 7809
[ayj("dfr")]
public sealed class bhq : m0
{
	// Token: 0x0600AE66 RID: 44646 RVA: 0x003FC220 File Offset: 0x003FA420
	public override string y8()
	{
		return "Deploy Fishing Rod";
	}

	// Token: 0x0600AE67 RID: 44647 RVA: 0x003FC228 File Offset: 0x003FA428
	public override string os()
	{
		return "DepFishRd";
	}

	// Token: 0x0600AE68 RID: 44648 RVA: 0x003FC230 File Offset: 0x003FA430
	public override ci8 bg()
	{
		return ci8.a;
	}

	// Token: 0x0600AE69 RID: 44649 RVA: 0x003FC234 File Offset: 0x003FA434
	public override string c1()
	{
		return "Устанавливает";
	}

	// Token: 0x0600AE6A RID: 44650 RVA: 0x003FC23C File Offset: 0x003FA43C
	public override v5 c2()
	{
		return v5.b;
	}

	// Token: 0x0600AE6B RID: 44651 RVA: 0x003FC240 File Offset: 0x003FA440
	public override bool q2()
	{
		return false;
	}

	// Token: 0x0600AE6C RID: 44652 RVA: 0x003FC244 File Offset: 0x003FA444
	public bhq()
	{
		this.a = new List<string>();
	}

	// Token: 0x0600AE6D RID: 44653 RVA: 0x003FC258 File Offset: 0x003FA458
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600AE6E RID: 44654 RVA: 0x003FC25C File Offset: 0x003FA45C
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.DiscoveredUnoccupiedTraversableSpot;
	}

	// Token: 0x0600AE6F RID: 44655 RVA: 0x003FC260 File Offset: 0x003FA460
	public override string bo(cnm A_0)
	{
		return string.Empty;
	}

	// Token: 0x0600AE70 RID: 44656 RVA: 0x003FC268 File Offset: 0x003FA468
	public override string bp(cnm A_0)
	{
		return qv.b("Items\\Utilities/FishingRod");
	}

	// Token: 0x0600AE71 RID: 44657 RVA: 0x003FC274 File Offset: 0x003FA474
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>();
	}

	// Token: 0x0600AE72 RID: 44658 RVA: 0x003FC27C File Offset: 0x003FA47C
	public override IList<string> bi()
	{
		return this.a;
	}

	// Token: 0x0600AE73 RID: 44659 RVA: 0x003FC284 File Offset: 0x003FA484
	public override dsk cv(cnm A_0)
	{
		return dsk.a;
	}

	// Token: 0x0600AE74 RID: 44660 RVA: 0x003FC288 File Offset: 0x003FA488
	protected override int br(cnm A_0)
	{
		return 3000;
	}

	// Token: 0x0600AE75 RID: 44661 RVA: 0x003FC290 File Offset: 0x003FA490
	protected override float f0(cnm A_0)
	{
		return 1.5f;
	}

	// Token: 0x04004079 RID: 16505
	private new List<string> a;
}

using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001EB5 RID: 7861
[ayj("Charge")]
public sealed class cto : bon
{
	// Token: 0x0600B115 RID: 45333 RVA: 0x0040173C File Offset: 0x003FF93C
	public override string y8()
	{
		return "Напор";
	}

	// Token: 0x0600B116 RID: 45334 RVA: 0x00401744 File Offset: 0x003FF944
	public override string os()
	{
		return "Charge";
	}

	// Token: 0x0600B117 RID: 45335 RVA: 0x0040174C File Offset: 0x003FF94C
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B118 RID: 45336 RVA: 0x00401750 File Offset: 0x003FF950
	public override bool cs()
	{
		return true;
	}

	// Token: 0x0600B119 RID: 45337 RVA: 0x00401754 File Offset: 0x003FF954
	public override int ct()
	{
		return 1;
	}

	// Token: 0x0600B11A RID: 45338 RVA: 0x00401758 File Offset: 0x003FF958
	public cto()
	{
		this.c = new List<string>();
		this.c.Add(d7f.a);
		this.c.Add("SAt.Charge");
	}

	// Token: 0x0600B11B RID: 45339 RVA: 0x0040178C File Offset: 0x003FF98C
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600B11C RID: 45340 RVA: 0x00401790 File Offset: 0x003FF990
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B11D RID: 45341 RVA: 0x00401794 File Offset: 0x003FF994
	public override string bo(cnm A_0)
	{
		return "";
	}

	// Token: 0x0600B11E RID: 45342 RVA: 0x0040179C File Offset: 0x003FF99C
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		list.Add(new cfd("SAt.Charge", cto.b, false, false));
		return list;
	}

	// Token: 0x0600B11F RID: 45343 RVA: 0x004017E8 File Offset: 0x003FF9E8
	public override IList<string> bi()
	{
		return this.c;
	}

	// Token: 0x0600B120 RID: 45344 RVA: 0x004017F0 File Offset: 0x003FF9F0
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && (A_0 != null && A_0.b8() != null) && !A_0.b8().SpecialStates.b;
	}

	// Token: 0x0600B121 RID: 45345 RVA: 0x00401828 File Offset: 0x003FFA28
	protected override int hi(cnm A_0)
	{
		return 35;
	}

	// Token: 0x04004100 RID: 16640
	private new const string a = "SAt.Charge";

	// Token: 0x04004101 RID: 16641
	public static readonly int b = 5000;

	// Token: 0x04004102 RID: 16642
	private List<string> c;
}

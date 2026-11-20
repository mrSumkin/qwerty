using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F3C RID: 7996
[ayj("coretechTrackingDeviceActivation")]
public sealed class c0 : m0
{
	// Token: 0x0600B9F9 RID: 47609 RVA: 0x0041286C File Offset: 0x00410A6C
	public override string y8()
	{
		return "coretechTrackingDeviceActivation";
	}

	// Token: 0x0600B9FA RID: 47610 RVA: 0x00412874 File Offset: 0x00410A74
	public override string os()
	{
		return "coretechTrackingDeviceActivation";
	}

	// Token: 0x0600B9FB RID: 47611 RVA: 0x0041287C File Offset: 0x00410A7C
	public override ci8 bg()
	{
		return ci8.a;
	}

	// Token: 0x0600B9FC RID: 47612 RVA: 0x00412880 File Offset: 0x00410A80
	public override bool cz()
	{
		return true;
	}

	// Token: 0x0600B9FD RID: 47613 RVA: 0x00412884 File Offset: 0x00410A84
	public override a3b c0()
	{
		return new a3b
		{
			c = c0e.d
		};
	}

	// Token: 0x0600B9FE RID: 47614 RVA: 0x00412898 File Offset: 0x00410A98
	public override string c1()
	{
		return "Читает";
	}

	// Token: 0x0600B9FF RID: 47615 RVA: 0x004128A0 File Offset: 0x00410AA0
	public override v5 c2()
	{
		return v5.b;
	}

	// Token: 0x0600BA00 RID: 47616 RVA: 0x004128A4 File Offset: 0x00410AA4
	public c0()
	{
		this.c = new List<string>();
		this.c.Add("CoretechTrackingDeviceActivation");
	}

	// Token: 0x0600BA01 RID: 47617 RVA: 0x004128C8 File Offset: 0x00410AC8
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600BA02 RID: 47618 RVA: 0x004128CC File Offset: 0x00410ACC
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600BA03 RID: 47619 RVA: 0x004128D0 File Offset: 0x00410AD0
	public override string bo(cnm A_0)
	{
		return "";
	}

	// Token: 0x0600BA04 RID: 47620 RVA: 0x004128D8 File Offset: 0x00410AD8
	public override string bp(cnm A_0)
	{
		return qv.b("Items\\Custom/CoretechTrackingDeviceActivation");
	}

	// Token: 0x0600BA05 RID: 47621 RVA: 0x004128E4 File Offset: 0x00410AE4
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("CoretechTrackingDeviceActivation", global::c0.b, false, false)
		};
	}

	// Token: 0x0600BA06 RID: 47622 RVA: 0x00412904 File Offset: 0x00410B04
	public override IList<string> bi()
	{
		return this.c;
	}

	// Token: 0x0600BA07 RID: 47623 RVA: 0x0041290C File Offset: 0x00410B0C
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}

	// Token: 0x0600BA08 RID: 47624 RVA: 0x00412910 File Offset: 0x00410B10
	protected override int hi(cnm A_0)
	{
		return 0;
	}

	// Token: 0x0400439A RID: 17306
	private new const string a = "CoretechTrackingDeviceActivation";

	// Token: 0x0400439B RID: 17307
	public static readonly int b = 3000;

	// Token: 0x0400439C RID: 17308
	private List<string> c;
}

using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F41 RID: 8001
[ayj("emitterTrackerNecklaceActivation")]
public sealed class ek : m0
{
	// Token: 0x0600BA50 RID: 47696 RVA: 0x00412BC4 File Offset: 0x00410DC4
	public override string y8()
	{
		return "emitterTrackerNecklaceActivation";
	}

	// Token: 0x0600BA51 RID: 47697 RVA: 0x00412BCC File Offset: 0x00410DCC
	public override string os()
	{
		return "emitterTrackerNecklaceActivation";
	}

	// Token: 0x0600BA52 RID: 47698 RVA: 0x00412BD4 File Offset: 0x00410DD4
	public override ci8 bg()
	{
		return ci8.a;
	}

	// Token: 0x0600BA53 RID: 47699 RVA: 0x00412BD8 File Offset: 0x00410DD8
	public override bool cz()
	{
		return true;
	}

	// Token: 0x0600BA54 RID: 47700 RVA: 0x00412BDC File Offset: 0x00410DDC
	public override a3b c0()
	{
		return new a3b
		{
			c = c0e.j
		};
	}

	// Token: 0x0600BA55 RID: 47701 RVA: 0x00412BF0 File Offset: 0x00410DF0
	public override string c1()
	{
		return "Читает";
	}

	// Token: 0x0600BA56 RID: 47702 RVA: 0x00412BF8 File Offset: 0x00410DF8
	public ek()
	{
		this.c = new List<string>();
		this.c.Add("EmitterTrackerNecklaceActivation");
	}

	// Token: 0x0600BA57 RID: 47703 RVA: 0x00412C1C File Offset: 0x00410E1C
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600BA58 RID: 47704 RVA: 0x00412C20 File Offset: 0x00410E20
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600BA59 RID: 47705 RVA: 0x00412C24 File Offset: 0x00410E24
	public override string bo(cnm A_0)
	{
		return "";
	}

	// Token: 0x0600BA5A RID: 47706 RVA: 0x00412C2C File Offset: 0x00410E2C
	public override string bp(cnm A_0)
	{
		return qv.b("Items\\Custom/EmitterTrackerNecklaceActivation");
	}

	// Token: 0x0600BA5B RID: 47707 RVA: 0x00412C38 File Offset: 0x00410E38
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("EmitterTrackerNecklaceActivation", ek.b, false, false)
		};
	}

	// Token: 0x0600BA5C RID: 47708 RVA: 0x00412C58 File Offset: 0x00410E58
	public override IList<string> bi()
	{
		return this.c;
	}

	// Token: 0x0600BA5D RID: 47709 RVA: 0x00412C60 File Offset: 0x00410E60
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}

	// Token: 0x0600BA5E RID: 47710 RVA: 0x00412C64 File Offset: 0x00410E64
	protected override int hi(cnm A_0)
	{
		return 0;
	}

	// Token: 0x040043A6 RID: 17318
	private new const string a = "EmitterTrackerNecklaceActivation";

	// Token: 0x040043A7 RID: 17319
	public static readonly int b = 5000;

	// Token: 0x040043A8 RID: 17320
	private List<string> c;
}

using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F3B RID: 7995
[ayj("PlaceC4ExplosiveCharge")]
public sealed class b0f : m0
{
	// Token: 0x0600B9E6 RID: 47590 RVA: 0x004127A8 File Offset: 0x004109A8
	public override string y8()
	{
		return "PlaceC4ExplosiveCharge";
	}

	// Token: 0x0600B9E7 RID: 47591 RVA: 0x004127B0 File Offset: 0x004109B0
	public override string os()
	{
		return "PlaceC4ExplosiveCharge";
	}

	// Token: 0x0600B9E8 RID: 47592 RVA: 0x004127B8 File Offset: 0x004109B8
	public override ci8 bg()
	{
		return ci8.a;
	}

	// Token: 0x0600B9E9 RID: 47593 RVA: 0x004127BC File Offset: 0x004109BC
	public override bool cz()
	{
		return true;
	}

	// Token: 0x0600B9EA RID: 47594 RVA: 0x004127C0 File Offset: 0x004109C0
	public override a3b c0()
	{
		return new a3b
		{
			a = c0e.d
		};
	}

	// Token: 0x0600B9EB RID: 47595 RVA: 0x004127D4 File Offset: 0x004109D4
	public override string c1()
	{
		return "Устанавливает";
	}

	// Token: 0x0600B9EC RID: 47596 RVA: 0x004127DC File Offset: 0x004109DC
	public override v5 c2()
	{
		return v5.b;
	}

	// Token: 0x0600B9ED RID: 47597 RVA: 0x004127E0 File Offset: 0x004109E0
	public override IList<string> bi()
	{
		return this.c;
	}

	// Token: 0x0600B9EE RID: 47598 RVA: 0x004127E8 File Offset: 0x004109E8
	public b0f()
	{
		this.c = new List<string>();
		this.c.Add("PlaceC4ExplosiveCharge");
	}

	// Token: 0x0600B9EF RID: 47599 RVA: 0x0041280C File Offset: 0x00410A0C
	public override bool c3(cnm A_0)
	{
		return false;
	}

	// Token: 0x0600B9F0 RID: 47600 RVA: 0x00412810 File Offset: 0x00410A10
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600B9F1 RID: 47601 RVA: 0x00412814 File Offset: 0x00410A14
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.LoadBearingColumn;
	}

	// Token: 0x0600B9F2 RID: 47602 RVA: 0x0041281C File Offset: 0x00410A1C
	public override string bo(cnm A_0)
	{
		return "";
	}

	// Token: 0x0600B9F3 RID: 47603 RVA: 0x00412824 File Offset: 0x00410A24
	public override string bp(cnm A_0)
	{
		return qv.b("Items\\Custom/PlaceC4ExplosiveCharge");
	}

	// Token: 0x0600B9F4 RID: 47604 RVA: 0x00412830 File Offset: 0x00410A30
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("PlaceC4ExplosiveCharge", b0f.b, false, false)
		};
	}

	// Token: 0x0600B9F5 RID: 47605 RVA: 0x00412850 File Offset: 0x00410A50
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}

	// Token: 0x0600B9F6 RID: 47606 RVA: 0x00412854 File Offset: 0x00410A54
	protected override int hi(cnm A_0)
	{
		return 0;
	}

	// Token: 0x0600B9F7 RID: 47607 RVA: 0x00412858 File Offset: 0x00410A58
	protected override int br(cnm A_0)
	{
		return 8000;
	}

	// Token: 0x04004397 RID: 17303
	private new const string a = "PlaceC4ExplosiveCharge";

	// Token: 0x04004398 RID: 17304
	public static readonly int b = 1000;

	// Token: 0x04004399 RID: 17305
	private List<string> c;
}

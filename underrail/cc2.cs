using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F47 RID: 8007
[ayj("Exsurge")]
public sealed class cc2 : c0z
{
	// Token: 0x0600BAB9 RID: 47801 RVA: 0x0041378C File Offset: 0x0041198C
	public override string y8()
	{
		return "Воспрянь";
	}

	// Token: 0x0600BABA RID: 47802 RVA: 0x00413794 File Offset: 0x00411994
	public override string os()
	{
		return "Exsurge";
	}

	// Token: 0x0600BABB RID: 47803 RVA: 0x0041379C File Offset: 0x0041199C
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600BABC RID: 47804 RVA: 0x004137A0 File Offset: 0x004119A0
	public override a3b c0()
	{
		return new a3b
		{
			c = c0e.a,
			d = new int?(10)
		};
	}

	// Token: 0x0600BABD RID: 47805 RVA: 0x004137C0 File Offset: 0x004119C0
	public override bool hl()
	{
		return true;
	}

	// Token: 0x0600BABE RID: 47806 RVA: 0x004137C4 File Offset: 0x004119C4
	public override bool bk()
	{
		return true;
	}

	// Token: 0x0600BABF RID: 47807 RVA: 0x004137C8 File Offset: 0x004119C8
	public cc2()
	{
		this.d = new List<string>();
		this.d.Add("SA.Exsurge");
	}

	// Token: 0x0600BAC0 RID: 47808 RVA: 0x004137EC File Offset: 0x004119EC
	public override string bm(cnm A_0)
	{
		return "Exsurge";
	}

	// Token: 0x0600BAC1 RID: 47809 RVA: 0x004137F4 File Offset: 0x004119F4
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600BAC2 RID: 47810 RVA: 0x004137F8 File Offset: 0x004119F8
	public override string bo(cnm A_0)
	{
		return qv.b("Items\\Utilities/Exsurge");
	}

	// Token: 0x0600BAC3 RID: 47811 RVA: 0x00413804 File Offset: 0x00411A04
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x0600BAC4 RID: 47812 RVA: 0x00413810 File Offset: 0x00411A10
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("SA.Exsurge", cc2.b * d0u.b, false, false)
		};
	}

	// Token: 0x0600BAC5 RID: 47813 RVA: 0x00413834 File Offset: 0x00411A34
	public override IList<string> bi()
	{
		return this.d;
	}

	// Token: 0x0600BAC6 RID: 47814 RVA: 0x0041383C File Offset: 0x00411A3C
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}

	// Token: 0x0600BAC7 RID: 47815 RVA: 0x00413840 File Offset: 0x00411A40
	public override bool hm(cnm A_0)
	{
		return A_0 != null && A_0.b8() != null && !A_0.b8().SpecialStates.h && !A_0.b8().SpecialStates.k && !A_0.b8().SpecialStates.a && !A_0.b8().StatusEffects.a(b34.c) && base.t(A_0);
	}

	// Token: 0x0600BAC8 RID: 47816 RVA: 0x004138CC File Offset: 0x00411ACC
	protected override int hi(cnm A_0)
	{
		return cc2.c;
	}

	// Token: 0x040043CC RID: 17356
	private new const string a = "SA.Exsurge";

	// Token: 0x040043CD RID: 17357
	public static readonly int b = 10;

	// Token: 0x040043CE RID: 17358
	public static readonly int c = 20;

	// Token: 0x040043CF RID: 17359
	private List<string> d;
}

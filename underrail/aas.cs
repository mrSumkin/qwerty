using System;
using System.Collections.Generic;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F43 RID: 8003
[ayj("TechnomedicExoskeletonRecharge")]
public sealed class aas : c0z
{
	// Token: 0x0600BA76 RID: 47734 RVA: 0x00412F38 File Offset: 0x00411138
	public override string y8()
	{
		return "Беспроводная подзарядка оборудования";
	}

	// Token: 0x0600BA77 RID: 47735 RVA: 0x00412F40 File Offset: 0x00411140
	public override string os()
	{
		return "TechnomedicExoskeletonRecharge";
	}

	// Token: 0x0600BA78 RID: 47736 RVA: 0x00412F48 File Offset: 0x00411148
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600BA79 RID: 47737 RVA: 0x00412F4C File Offset: 0x0041114C
	public override int e8()
	{
		return 11;
	}

	// Token: 0x0600BA7A RID: 47738 RVA: 0x00412F50 File Offset: 0x00411150
	public override bool hl()
	{
		return false;
	}

	// Token: 0x0600BA7B RID: 47739 RVA: 0x00412F54 File Offset: 0x00411154
	public override IList<string> bi()
	{
		return this.f;
	}

	// Token: 0x0600BA7C RID: 47740 RVA: 0x00412F5C File Offset: 0x0041115C
	public override TimelapseCursor? bj()
	{
		return new TimelapseCursor?(TimelapseCursor.InvokeSpell);
	}

	// Token: 0x0600BA7D RID: 47741 RVA: 0x00412F64 File Offset: 0x00411164
	public override bool bk()
	{
		return true;
	}

	// Token: 0x0600BA7E RID: 47742 RVA: 0x00412F68 File Offset: 0x00411168
	public aas()
	{
		this.f = new List<string>();
		this.f.Add("SAt.TechnomedicExoskeletonRecharge");
	}

	// Token: 0x0600BA7F RID: 47743 RVA: 0x00412F8C File Offset: 0x0041118C
	public override a3b bl(cnm A_0, efk A_1)
	{
		return new a3b
		{
			a = c0e.d,
			c = c0e.j
		};
	}

	// Token: 0x0600BA80 RID: 47744 RVA: 0x00412FAC File Offset: 0x004111AC
	public override string bm(cnm A_0)
	{
		return "Abilities.112";
	}

	// Token: 0x0600BA81 RID: 47745 RVA: 0x00412FB4 File Offset: 0x004111B4
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Humanoid;
	}

	// Token: 0x0600BA82 RID: 47746 RVA: 0x00412FB8 File Offset: 0x004111B8
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x0600BA83 RID: 47747 RVA: 0x00412FC4 File Offset: 0x004111C4
	public override string bo(cnm A_0)
	{
		return qv.a("SpecialAbilities/TechnomedicExoskeletonRecharge", new object[]
		{
			aas.d,
			aas.e.ToString("P0")
		});
	}

	// Token: 0x0600BA84 RID: 47748 RVA: 0x00413004 File Offset: 0x00411204
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("SAt.TechnomedicExoskeletonRecharge", aas.b, false, false)
		};
	}

	// Token: 0x0600BA85 RID: 47749 RVA: 0x00413028 File Offset: 0x00411228
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && (A_0 != null && A_0.b8() != null && A_0.b8().Gear.l().Item != null) && A_0.b8().Gear.l().Item.Battery >= (double)aas.d;
	}

	// Token: 0x0600BA86 RID: 47750 RVA: 0x00413098 File Offset: 0x00411298
	public override dsk cv(cnm A_0)
	{
		return dsk.b;
	}

	// Token: 0x0600BA87 RID: 47751 RVA: 0x0041309C File Offset: 0x0041129C
	protected override int br(cnm A_0)
	{
		return 1500;
	}

	// Token: 0x0600BA88 RID: 47752 RVA: 0x004130A4 File Offset: 0x004112A4
	protected override int hi(cnm A_0)
	{
		return aas.c;
	}

	// Token: 0x0600BA89 RID: 47753 RVA: 0x004130AC File Offset: 0x004112AC
	protected override float f0(cnm A_0)
	{
		return as3.bk;
	}

	// Token: 0x040043B1 RID: 17329
	private new const string a = "SAt.TechnomedicExoskeletonRecharge";

	// Token: 0x040043B2 RID: 17330
	public static readonly int b = d0u.b * 10;

	// Token: 0x040043B3 RID: 17331
	public static readonly int c = 10;

	// Token: 0x040043B4 RID: 17332
	public static readonly int d = 25;

	// Token: 0x040043B5 RID: 17333
	public new static readonly double e = 0.8;

	// Token: 0x040043B6 RID: 17334
	private List<string> f;
}

using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001EB9 RID: 7865
[ayj("HeavyPunch")]
public sealed class bs : bon
{
	// Token: 0x0600B154 RID: 45396 RVA: 0x00401E4C File Offset: 0x0040004C
	public override string y8()
	{
		return "Тяжёлая рука";
	}

	// Token: 0x0600B155 RID: 45397 RVA: 0x00401E54 File Offset: 0x00400054
	public override string os()
	{
		return "HeavyPunch";
	}

	// Token: 0x0600B156 RID: 45398 RVA: 0x00401E5C File Offset: 0x0040005C
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B157 RID: 45399 RVA: 0x00401E60 File Offset: 0x00400060
	public override bool cs()
	{
		return true;
	}

	// Token: 0x0600B158 RID: 45400 RVA: 0x00401E64 File Offset: 0x00400064
	public override int ct()
	{
		return 2;
	}

	// Token: 0x0600B159 RID: 45401 RVA: 0x00401E68 File Offset: 0x00400068
	public bs()
	{
		this.e = new List<string>();
		this.e.Add(d7f.a);
		this.e.Add("SAt.HeavyPunch");
	}

	// Token: 0x0600B15A RID: 45402 RVA: 0x00401E9C File Offset: 0x0040009C
	public override string bm(cnm A_0)
	{
		return "SpecialAttack.HeavyPunch";
	}

	// Token: 0x0600B15B RID: 45403 RVA: 0x00401EA4 File Offset: 0x004000A4
	public override bool cu(cnm A_0)
	{
		return base.cu(A_0) && A_0 != null && A_0.b8() != null && (euf.o(A_0.b8().Offense.u()) || euf.n(A_0.b8().Offense.u()));
	}

	// Token: 0x0600B15C RID: 45404 RVA: 0x00401F04 File Offset: 0x00400104
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B15D RID: 45405 RVA: 0x00401F0C File Offset: 0x0040010C
	public override string bo(cnm A_0)
	{
		double num = bs.a(A_0);
		return qv.a("SpecialAttacks/HeavyPunch", new object[]
		{
			Convert.ToInt32(num * 100.0)
		});
	}

	// Token: 0x0600B15E RID: 45406 RVA: 0x00401F48 File Offset: 0x00400148
	public new static double a(cnm A_0)
	{
		return bs.b + (double)c3n.GetSpecSafe<cjz>(A_0) * cjz.a;
	}

	// Token: 0x0600B15F RID: 45407 RVA: 0x00401F60 File Offset: 0x00400160
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		list.Add(new cfd("SAt.HeavyPunch", bs.d * d0u.b, false, false));
		return list;
	}

	// Token: 0x0600B160 RID: 45408 RVA: 0x00401FB0 File Offset: 0x004001B0
	public override IList<string> bi()
	{
		return this.e;
	}

	// Token: 0x0600B161 RID: 45409 RVA: 0x00401FB8 File Offset: 0x004001B8
	public override dsk cv(cnm A_0)
	{
		return dsk.b;
	}

	// Token: 0x0600B162 RID: 45410 RVA: 0x00401FC0 File Offset: 0x004001C0
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && A_0 != null && A_0.b8() != null && (euf.o(A_0.b8().Offense.u()) || euf.n(A_0.b8().Offense.u()));
	}

	// Token: 0x0600B163 RID: 45411 RVA: 0x00402020 File Offset: 0x00400220
	protected override int br(cnm A_0)
	{
		return 500;
	}

	// Token: 0x0600B164 RID: 45412 RVA: 0x00402028 File Offset: 0x00400228
	protected override float cl(cnm A_0)
	{
		return Convert.ToSingle(bs.c - (double)c3n.GetSpecSafe<aot>(A_0) * aot.a);
	}

	// Token: 0x04004110 RID: 16656
	private new const string a = "SAt.HeavyPunch";

	// Token: 0x04004111 RID: 16657
	public static readonly double b = 3.0;

	// Token: 0x04004112 RID: 16658
	public static readonly double c = 1.5;

	// Token: 0x04004113 RID: 16659
	public static readonly int d = 3;

	// Token: 0x04004114 RID: 16660
	private new List<string> e;
}

using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001EB7 RID: 7863
[ayj("ExposeWeakness")]
public sealed class csr : bon
{
	// Token: 0x0600B134 RID: 45364 RVA: 0x00401AE4 File Offset: 0x003FFCE4
	public override string y8()
	{
		return "Раскрыть уязвимость";
	}

	// Token: 0x0600B135 RID: 45365 RVA: 0x00401AEC File Offset: 0x003FFCEC
	public override string os()
	{
		return "ExposeWeakness";
	}

	// Token: 0x0600B136 RID: 45366 RVA: 0x00401AF4 File Offset: 0x003FFCF4
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B137 RID: 45367 RVA: 0x00401AF8 File Offset: 0x003FFCF8
	public override bool cs()
	{
		return true;
	}

	// Token: 0x0600B138 RID: 45368 RVA: 0x00401AFC File Offset: 0x003FFCFC
	public override int ct()
	{
		return 3;
	}

	// Token: 0x0600B139 RID: 45369 RVA: 0x00401B00 File Offset: 0x003FFD00
	public csr()
	{
		this.f = new List<string>();
		this.f.Add(d7f.a);
		this.f.Add("SAt.ExposeWeakness");
	}

	// Token: 0x0600B13A RID: 45370 RVA: 0x00401B34 File Offset: 0x003FFD34
	public override string bm(cnm A_0)
	{
		return "SpecialAttack.ExposeWeakness";
	}

	// Token: 0x0600B13B RID: 45371 RVA: 0x00401B3C File Offset: 0x003FFD3C
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && A_0 != null && A_0.b8() != null && A_0.b8().Offense.u() != null && A_0.b8().Offense.u().TypedDefinition != null && A_0.b8().Offense.u().TypedDefinition.e() == btz.g;
	}

	// Token: 0x0600B13C RID: 45372 RVA: 0x00401BB4 File Offset: 0x003FFDB4
	public override bool cu(cnm A_0)
	{
		return A_0 != null && A_0.b8() != null && A_0.b8().Offense.u() != null && A_0.b8().Offense.u().TypedDefinition != null && A_0.b8().Offense.u().TypedDefinition.e() == btz.g;
	}

	// Token: 0x0600B13D RID: 45373 RVA: 0x00401C20 File Offset: 0x003FFE20
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B13E RID: 45374 RVA: 0x00401C24 File Offset: 0x003FFE24
	public override string bo(cnm A_0)
	{
		return qv.a("SpecialAttacks/ExposeWeakness", new object[]
		{
			Convert.ToInt32(csr.b(A_0) * 100.0),
			l4.a(csr.a(A_0), false)
		});
	}

	// Token: 0x0600B13F RID: 45375 RVA: 0x00401C64 File Offset: 0x003FFE64
	public static double b(cnm A_0)
	{
		double num = csr.b;
		int? num2;
		if (A_0 == null)
		{
			num2 = null;
		}
		else
		{
			efk efk = A_0.b8();
			num2 = ((efk != null) ? new int?(efk.BaseAbilities.Intelligence) : null);
		}
		int? num3 = num2;
		return num + (double)num3.GetValueOrDefault() * csr.c + (double)c3n.GetSpecSafe<etr>(A_0) * etr.a;
	}

	// Token: 0x0600B140 RID: 45376 RVA: 0x00401CD4 File Offset: 0x003FFED4
	public new static int a(cnm A_0)
	{
		return csr.d + c3n.GetSpecSafe<oc>(A_0) * oc.a;
	}

	// Token: 0x0600B141 RID: 45377 RVA: 0x00401CEC File Offset: 0x003FFEEC
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		list.Add(new cfd("SAt.ExposeWeakness", csr.e * d0u.b, false, false));
		return list;
	}

	// Token: 0x0600B142 RID: 45378 RVA: 0x00401D3C File Offset: 0x003FFF3C
	public override IList<string> bi()
	{
		return this.f;
	}

	// Token: 0x0600B143 RID: 45379 RVA: 0x00401D44 File Offset: 0x003FFF44
	protected override int br(cnm A_0)
	{
		return 500;
	}

	// Token: 0x04004107 RID: 16647
	private new const string a = "SAt.ExposeWeakness";

	// Token: 0x04004108 RID: 16648
	public static readonly double b = 0.3;

	// Token: 0x04004109 RID: 16649
	public static readonly double c = 0.02;

	// Token: 0x0400410A RID: 16650
	public static readonly int d = 2;

	// Token: 0x0400410B RID: 16651
	public new static readonly int e = 5;

	// Token: 0x0400410C RID: 16652
	private List<string> f;
}

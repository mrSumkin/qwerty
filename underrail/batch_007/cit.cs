using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001ECD RID: 7885
[ayj("SnipeAttack")]
public sealed class cit : bon
{
	// Token: 0x0600B26C RID: 45676 RVA: 0x00404A30 File Offset: 0x00402C30
	public override string y8()
	{
		return "Снайперский выстрел";
	}

	// Token: 0x0600B26D RID: 45677 RVA: 0x00404A38 File Offset: 0x00402C38
	public override string os()
	{
		return "Snipe";
	}

	// Token: 0x0600B26E RID: 45678 RVA: 0x00404A40 File Offset: 0x00402C40
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B26F RID: 45679 RVA: 0x00404A44 File Offset: 0x00402C44
	public override bool cs()
	{
		return false;
	}

	// Token: 0x0600B270 RID: 45680 RVA: 0x00404A48 File Offset: 0x00402C48
	public override int ct()
	{
		return 2;
	}

	// Token: 0x0600B271 RID: 45681 RVA: 0x00404A4C File Offset: 0x00402C4C
	public cit()
	{
		this.e = new List<string>();
		this.e.Add(d7f.a);
		this.e.Add("SAt.Snipe");
	}

	// Token: 0x0600B272 RID: 45682 RVA: 0x00404A80 File Offset: 0x00402C80
	public override string bm(cnm A_0)
	{
		return "Snipe";
	}

	// Token: 0x0600B273 RID: 45683 RVA: 0x00404A8C File Offset: 0x00402C8C
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && A_0 != null && A_0.b8() != null && A_0.b8().SpecialStates.g && A_0.b8().Offense.u() != null && A_0.b8().Offense.u().TypedDefinition != null && (A_0.b8().Offense.u().TypedDefinition.e() == btz.f || A_0.b8().Offense.u().TypedDefinition.e() == btz.d);
	}

	// Token: 0x0600B274 RID: 45684 RVA: 0x00404B3C File Offset: 0x00402D3C
	public override bool cu(cnm A_0)
	{
		return A_0 != null && A_0.b8() != null && A_0.b8().SpecialStates.g && A_0.b8().Offense.u() != null && A_0.b8().Offense.u().TypedDefinition != null && (A_0.b8().Offense.u().TypedDefinition.e() == btz.f || A_0.b8().Offense.u().TypedDefinition.e() == btz.d);
	}

	// Token: 0x0600B275 RID: 45685 RVA: 0x00404BE0 File Offset: 0x00402DE0
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B276 RID: 45686 RVA: 0x00404BE8 File Offset: 0x00402DE8
	public override string bo(cnm A_0)
	{
		string text = qv.b("SpecialAttacks/Snipe");
		string result = string.Empty;
		if (!string.IsNullOrEmpty(text))
		{
			try
			{
				result = string.Format(text, Convert.ToInt32(cit.a(A_0.b8()) * 100f));
			}
			catch
			{
			}
		}
		return result;
	}

	// Token: 0x0600B277 RID: 45687 RVA: 0x00404C50 File Offset: 0x00402E50
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		list.Add(new cfd("SAt.Snipe", cit.b, false, false));
		return list;
	}

	// Token: 0x0600B278 RID: 45688 RVA: 0x00404C9C File Offset: 0x00402E9C
	public override IList<string> bi()
	{
		return this.e;
	}

	// Token: 0x0600B279 RID: 45689 RVA: 0x00404CA8 File Offset: 0x00402EA8
	public static float a(efk A_0)
	{
		return (float)(1.0 + cit.c + (cit.d + (double)A_0.GetSpecializationValue<cjp>(true) * cjp.a) * (double)A_0.Skills.Get<a2n>().g());
	}

	// Token: 0x0600B27A RID: 45690 RVA: 0x00404CEC File Offset: 0x00402EEC
	public override dsk cv(cnm A_0)
	{
		return dsk.b;
	}

	// Token: 0x0600B27B RID: 45691 RVA: 0x00404CF0 File Offset: 0x00402EF0
	protected override int br(cnm A_0)
	{
		return 4000;
	}

	// Token: 0x04004155 RID: 16725
	private new const string a = "SAt.Snipe";

	// Token: 0x04004156 RID: 16726
	public static readonly int b = 15000;

	// Token: 0x04004157 RID: 16727
	public static readonly double c = 1.25;

	// Token: 0x04004158 RID: 16728
	public static readonly double d = 0.01;

	// Token: 0x04004159 RID: 16729
	private new List<string> e;
}

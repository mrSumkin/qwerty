using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001EFB RID: 7931
[ayj("EvasiveManeuvers")]
public sealed class enw : c0z
{
	// Token: 0x0600B578 RID: 46456 RVA: 0x00409A3C File Offset: 0x00407C3C
	public override string y8()
	{
		return "Манёвр уворота";
	}

	// Token: 0x0600B579 RID: 46457 RVA: 0x00409A44 File Offset: 0x00407C44
	public override string os()
	{
		return "EvasiveManeuvers";
	}

	// Token: 0x0600B57A RID: 46458 RVA: 0x00409A4C File Offset: 0x00407C4C
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600B57B RID: 46459 RVA: 0x00409A50 File Offset: 0x00407C50
	public override int e8()
	{
		return 3;
	}

	// Token: 0x0600B57C RID: 46460 RVA: 0x00409A54 File Offset: 0x00407C54
	public override a3b c0()
	{
		return new a3b
		{
			c = c0e.j
		};
	}

	// Token: 0x0600B57D RID: 46461 RVA: 0x00409A68 File Offset: 0x00407C68
	public override bool hl()
	{
		return false;
	}

	// Token: 0x0600B57E RID: 46462 RVA: 0x00409A6C File Offset: 0x00407C6C
	public enw()
	{
		this.d = new List<string>();
		this.d.Add("SA.EvasiveManeuvers");
	}

	// Token: 0x0600B57F RID: 46463 RVA: 0x00409A90 File Offset: 0x00407C90
	public override string bm(cnm A_0)
	{
		return "EvasiveManeuvers";
	}

	// Token: 0x0600B580 RID: 46464 RVA: 0x00409A98 File Offset: 0x00407C98
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600B581 RID: 46465 RVA: 0x00409A9C File Offset: 0x00407C9C
	public override string bo(cnm A_0)
	{
		return qv.a("SpecialAbilities/EvasiveManeuvers", new object[]
		{
			(int)(enw.a(A_0) * 100.0),
			l4.a(enw.c, false)
		});
	}

	// Token: 0x0600B582 RID: 46466 RVA: 0x00409AD8 File Offset: 0x00407CD8
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("SA.EvasiveManeuvers", uf.a(enw.b * d0u.b, A_0, new CooldownCategory[]
			{
				CooldownCategory.EvasiveManeuvers
			}), false, false)
		};
	}

	// Token: 0x0600B583 RID: 46467 RVA: 0x00409B1C File Offset: 0x00407D1C
	public override bool hm(cnm A_0)
	{
		if (!base.hm(A_0))
		{
			return false;
		}
		if (A_0 != null && A_0.b8() != null && !A_0.b8().SpecialStates.b)
		{
			io service = bpo.GetService<io>();
			if (service != null && service.ahg())
			{
				return service.ahw(A_0.b8()) > 0;
			}
		}
		return false;
	}

	// Token: 0x0600B584 RID: 46468 RVA: 0x00409B88 File Offset: 0x00407D88
	public override IList<string> bi()
	{
		return this.d;
	}

	// Token: 0x0600B585 RID: 46469 RVA: 0x00409B90 File Offset: 0x00407D90
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}

	// Token: 0x0600B586 RID: 46470 RVA: 0x00409B94 File Offset: 0x00407D94
	public new static double a(cnm A_0)
	{
		double num = 3.0;
		if (A_0 != null && A_0.b8() != null)
		{
			num += (double)A_0.b8().GetSpecializationValue<j1>(true) * j1.a;
		}
		return num;
	}

	// Token: 0x0600B587 RID: 46471 RVA: 0x00409BD4 File Offset: 0x00407DD4
	protected override int hi(cnm A_0)
	{
		return 0;
	}

	// Token: 0x0400421B RID: 16923
	private new const string a = "SA.EvasiveManeuvers";

	// Token: 0x0400421C RID: 16924
	public static readonly int b = 3;

	// Token: 0x0400421D RID: 16925
	public static readonly int c = 2;

	// Token: 0x0400421E RID: 16926
	private List<string> d;
}

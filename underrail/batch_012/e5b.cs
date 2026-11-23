using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F01 RID: 7937
[ayj("StealthMode")]
public sealed class e5b : cx6
{
	// Token: 0x0600B5D9 RID: 46553 RVA: 0x0040A28C File Offset: 0x0040848C
	public override string y8()
	{
		return "Режим скрытности";
	}

	// Token: 0x0600B5DA RID: 46554 RVA: 0x0040A294 File Offset: 0x00408494
	public override string os()
	{
		return "StealthMode";
	}

	// Token: 0x0600B5DB RID: 46555 RVA: 0x0040A29C File Offset: 0x0040849C
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600B5DC RID: 46556 RVA: 0x0040A2A0 File Offset: 0x004084A0
	public override IList<string> bi()
	{
		return new List<string>
		{
			e5b.d
		};
	}

	// Token: 0x0600B5DD RID: 46557 RVA: 0x0040A2B4 File Offset: 0x004084B4
	public override int bh()
	{
		return int.MinValue;
	}

	// Token: 0x0600B5DE RID: 46558 RVA: 0x0040A2BC File Offset: 0x004084BC
	public override v5 c2()
	{
		return v5.a;
	}

	// Token: 0x0600B5DF RID: 46559 RVA: 0x0040A2C0 File Offset: 0x004084C0
	public override bool hl()
	{
		return false;
	}

	// Token: 0x0600B5E0 RID: 46560 RVA: 0x0040A2C4 File Offset: 0x004084C4
	public override string bm(cnm A_0)
	{
		return "Abilities.0";
	}

	// Token: 0x0600B5E1 RID: 46561 RVA: 0x0040A2D0 File Offset: 0x004084D0
	public override string bo(cnm A_0)
	{
		return qv.a("SpecialAbilities/Stealth", new object[]
		{
			Convert.ToInt32(e5b.b(A_0.b8()) * 100.0),
			e5b.a(A_0.b8())
		});
	}

	// Token: 0x0600B5E2 RID: 46562 RVA: 0x0040A324 File Offset: 0x00408524
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		int num = uf.a(10000, A_0, new CooldownCategory[]
		{
			CooldownCategory.Stealth
		});
		List<cfd> list = new List<cfd>();
		if (num > 0)
		{
			list.Add(new cfd(e5b.d, num, false, false));
		}
		return list;
	}

	// Token: 0x0600B5E3 RID: 46563 RVA: 0x0040A368 File Offset: 0x00408568
	public override List<els> j8(cnm A_0)
	{
		List<els> list = new List<els>();
		list.Add(new dmy());
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<oh>())
		{
			list.Add(new ak3(0));
		}
		return list;
	}

	// Token: 0x0600B5E4 RID: 46564 RVA: 0x0040A3BC File Offset: 0x004085BC
	public static double b(efk A_0)
	{
		double result;
		if (A_0 != null && A_0.Feats.Contains<c4y>())
		{
			result = (double)aiy.b0 - (double)A_0.GetSpecializationValue<cag>(true) * cag.a;
		}
		else
		{
			result = (double)aiy.bz;
		}
		return result;
	}

	// Token: 0x0600B5E5 RID: 46565 RVA: 0x0040A404 File Offset: 0x00408604
	public static int a(efk A_0)
	{
		int result = aiy.b1;
		if (A_0 != null && A_0.Feats.Contains<c4y>())
		{
			result = aiy.b2 + A_0.GetSpecializationValue<cag>(true) * cag.b;
		}
		return result;
	}

	// Token: 0x0600B5E6 RID: 46566 RVA: 0x0040A444 File Offset: 0x00408644
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && (A_0 != null && A_0.b8() != null && !A_0.b8().StatusEffects.a(bk9.a)) && !A_0.b8().StatusEffects.a(ex.a);
	}

	// Token: 0x0600B5E7 RID: 46567 RVA: 0x0040A4A4 File Offset: 0x004086A4
	public override bool cu(cnm A_0)
	{
		return (A_0 == null || A_0.b8() == null || !A_0.b8().StatusEffects.a(bdm.a)) && (!this.EquippedItemBased || base.t(A_0)) && (A_0.b8() == null || this.CanBeUsedWhileDriving || A_0.b8().Vehicle == null) && (A_0 != null && A_0.b8() != null && !A_0.b8().StatusEffects.a(bk9.a)) && !A_0.b8().StatusEffects.a(ex.a);
	}

	// Token: 0x0600B5E8 RID: 46568 RVA: 0x0040A564 File Offset: 0x00408764
	protected override int hi(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null && !(A_0.b8() is e3q))
		{
			return 0;
		}
		if (A_0 != null)
		{
			coh coh = A_0.b9() as coh;
			if (coh != null && coh.Definition.a5() == "vanishingPowder")
			{
				return 0;
			}
		}
		return 10;
	}

	// Token: 0x04004233 RID: 16947
	private new const string a = "Stealth Mode";

	// Token: 0x04004234 RID: 16948
	private const string b = "StealthMode";

	// Token: 0x04004235 RID: 16949
	private const int c = 10000;

	// Token: 0x04004236 RID: 16950
	public static readonly string d = "SA.Stealth";
}

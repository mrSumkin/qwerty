using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001FA3 RID: 8099
[ayj("HealthHypoConsumation")]
public sealed class cwn : awn
{
	// Token: 0x0600BE57 RID: 48727 RVA: 0x00418BA0 File Offset: 0x00416DA0
	public override string y8()
	{
		return "Стимулятор";
	}

	// Token: 0x0600BE58 RID: 48728 RVA: 0x00418BA8 File Offset: 0x00416DA8
	public override string os()
	{
		return "HealthHypoConsumation";
	}

	// Token: 0x0600BE59 RID: 48729 RVA: 0x00418BB0 File Offset: 0x00416DB0
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600BE5A RID: 48730 RVA: 0x00418BB4 File Offset: 0x00416DB4
	public cwn()
	{
		this.a = new List<string>();
		this.a.Add(d7f.h);
	}

	// Token: 0x0600BE5B RID: 48731 RVA: 0x00418BD8 File Offset: 0x00416DD8
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600BE5C RID: 48732 RVA: 0x00418BE0 File Offset: 0x00416DE0
	public override string bo(cnm A_0)
	{
		string text = string.Format("Мгновенно восстанавливает {0} очков здоровья.", cwn.a(A_0));
		if (cwn.b(A_0))
		{
			text += string.Format(" Имеет {0}% шанс исцеления в двукратном размере.", Convert.ToInt32(cy9.a * 100.0));
		}
		return text;
	}

	// Token: 0x0600BE5D RID: 48733 RVA: 0x00418C3C File Offset: 0x00416E3C
	public static bool b(cnm A_0)
	{
		if (A_0 != null)
		{
			coh coh = A_0.b9() as coh;
			if (coh != null && coh.Definition != null && coh.Definition.a7().GetPrimitivePropertyValue<bool>("Enriched", new bool?(false)).Value)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600BE5E RID: 48734 RVA: 0x00418C98 File Offset: 0x00416E98
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_0 != null && A_0.b8() is e3q)
		{
			int healingCooldown = euf.b().HealingCooldown;
			if (healingCooldown > 0)
			{
				list.Add(new cfd(d7f.h, d0u.b * healingCooldown, false, false));
			}
		}
		else
		{
			list.Add(d7f.j);
		}
		return list;
	}

	// Token: 0x0600BE5F RID: 48735 RVA: 0x00418D00 File Offset: 0x00416F00
	public override IList<string> bi()
	{
		return this.a;
	}

	// Token: 0x0600BE60 RID: 48736 RVA: 0x00418D0C File Offset: 0x00416F0C
	public new static int a(cnm A_0)
	{
		int num = 80;
		if (A_0 != null)
		{
			coh coh = A_0.b9() as coh;
			if (coh != null && coh.Definition != null)
			{
				num = coh.Definition.a7().GetPrimitivePropertyValue<int>("HealAmount", new int?(num)).Value;
			}
		}
		if (A_0 != null && A_0.b8() is e3q)
		{
			num = (int)((float)num * euf.b().HealingModifier);
		}
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<yn>())
		{
			num = Convert.ToInt32((double)num * (1.0 + yn.a + (double)A_0.b8().GetSpecializationValue<aog>(true) * aog.a));
		}
		return num;
	}

	// Token: 0x0400445C RID: 17500
	private new List<string> a;
}

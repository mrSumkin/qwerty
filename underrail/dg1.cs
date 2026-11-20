using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F4C RID: 8012
public abstract class dg1 : c0r
{
	// Token: 0x0600BB09 RID: 47881 RVA: 0x00413FFC File Offset: 0x004121FC
	public override string c1()
	{
		return "Устанавливает";
	}

	// Token: 0x0600BB0A RID: 47882 RVA: 0x00414004 File Offset: 0x00412204
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.TrappableSpot;
	}

	// Token: 0x0600BB0B RID: 47883 RVA: 0x00414008 File Offset: 0x00412208
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600BB0C RID: 47884 RVA: 0x0041400C File Offset: 0x0041220C
	public override a3b c0()
	{
		return new a3b
		{
			a = c0e.d
		};
	}

	// Token: 0x0600BB0D RID: 47885 RVA: 0x00414020 File Offset: 0x00412220
	public override v5 c2()
	{
		return v5.b;
	}

	// Token: 0x0600BB0E RID: 47886 RVA: 0x00414024 File Offset: 0x00412224
	public override bool q2()
	{
		return false;
	}

	// Token: 0x0600BB0F RID: 47887 RVA: 0x00414028 File Offset: 0x00412228
	public override bool c3(cnm A_0)
	{
		return A_0 != null && A_0.b8() != null && A_0.b8().StatusEffects.a(a4l.a);
	}

	// Token: 0x0600BB10 RID: 47888 RVA: 0x00414054 File Offset: 0x00412254
	public override string bo(cnm A_0)
	{
		return string.Empty;
	}

	// Token: 0x0600BB11 RID: 47889 RVA: 0x0041405C File Offset: 0x0041225C
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600BB12 RID: 47890 RVA: 0x00414060 File Offset: 0x00412260
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>();
	}

	// Token: 0x0600BB13 RID: 47891 RVA: 0x00414068 File Offset: 0x00412268
	public override IList<string> bi()
	{
		return new List<string>();
	}

	// Token: 0x0600BB14 RID: 47892 RVA: 0x00414070 File Offset: 0x00412270
	public static int a(efk A_0)
	{
		int num = dg1.a;
		if (A_0 != null)
		{
			num = Math.Max(0, num - A_0.GetSpecializationValue<ec5>(true) * ec5.a);
		}
		return num;
	}

	// Token: 0x0600BB15 RID: 47893 RVA: 0x004140A0 File Offset: 0x004122A0
	protected override int br(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null && A_0.b8().StatusEffects.a(a4l.a))
		{
			return 250;
		}
		return 7000;
	}

	// Token: 0x0600BB16 RID: 47894 RVA: 0x004140D8 File Offset: 0x004122D8
	protected override int hi(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null && A_0.b8().StatusEffects.a(a4l.a))
		{
			return dg1.a(A_0.b8());
		}
		return dg1.a;
	}

	// Token: 0x0600BB17 RID: 47895 RVA: 0x00414124 File Offset: 0x00412324
	protected override float te(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<c62>())
		{
			return (float)(1.0 - (c62.a + (double)A_0.b8().GetSpecializationValue<v6>(true) * v6.a));
		}
		return 1f;
	}

	// Token: 0x0600BB18 RID: 47896 RVA: 0x00414184 File Offset: 0x00412384
	protected override float f0(cnm A_0)
	{
		return as3.bk;
	}

	// Token: 0x0600BB19 RID: 47897 RVA: 0x0041418C File Offset: 0x0041238C
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}

	// Token: 0x0600BB1A RID: 47898 RVA: 0x00414190 File Offset: 0x00412390
	public override bool hm(cnm A_0)
	{
		if (!base.hm(A_0))
		{
			return false;
		}
		if (A_0 != null && A_0.b8() != null)
		{
			if (A_0.b8().IsInCombat && !A_0.b8().StatusEffects.a(a4l.a))
			{
				return false;
			}
			coh coh = A_0.b9() as coh;
			if (coh != null)
			{
				c4j c4j = coh.Definition as c4j;
				if (c4j != null)
				{
					return A_0.b8().Skills.Get<c0b>().g() >= c4j.b();
				}
			}
		}
		return false;
	}

	// Token: 0x040043DC RID: 17372
	public new static readonly int a = 25;
}

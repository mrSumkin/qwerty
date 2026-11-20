using System;
using System.Collections.Generic;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001E6D RID: 7789
[ayj("EtherealTorchAttack")]
public sealed class v3 : m0, a5q
{
	// Token: 0x0600AD1F RID: 44319 RVA: 0x003FAE54 File Offset: 0x003F9054
	public override string y8()
	{
		return "Взорвать эфирным факелом";
	}

	// Token: 0x0600AD20 RID: 44320 RVA: 0x003FAE5C File Offset: 0x003F905C
	public override string os()
	{
		return "EtherealTorchAttack";
	}

	// Token: 0x0600AD21 RID: 44321 RVA: 0x003FAE64 File Offset: 0x003F9064
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600AD22 RID: 44322 RVA: 0x003FAE68 File Offset: 0x003F9068
	public override bool cz()
	{
		return true;
	}

	// Token: 0x0600AD23 RID: 44323 RVA: 0x003FAE6C File Offset: 0x003F906C
	public override a3b c0()
	{
		return new a3b
		{
			c = c0e.j
		};
	}

	// Token: 0x0600AD24 RID: 44324 RVA: 0x003FAE80 File Offset: 0x003F9080
	public override string c1()
	{
		return "Подготавливает";
	}

	// Token: 0x0600AD25 RID: 44325 RVA: 0x003FAE88 File Offset: 0x003F9088
	public override TimelapseCursor? bj()
	{
		return new TimelapseCursor?(TimelapseCursor.GroundAttack);
	}

	// Token: 0x0600AD26 RID: 44326 RVA: 0x003FAE94 File Offset: 0x003F9094
	public v3()
	{
		this.b = new List<string>();
		this.b.Add(d7f.a);
	}

	// Token: 0x0600AD27 RID: 44327 RVA: 0x003FAEB8 File Offset: 0x003F90B8
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600AD28 RID: 44328 RVA: 0x003FAEBC File Offset: 0x003F90BC
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.DiscoveredPenetrableSpot;
	}

	// Token: 0x0600AD29 RID: 44329 RVA: 0x003FAEC4 File Offset: 0x003F90C4
	public override string bp(cnm A_0)
	{
		return qv.a("Items\\Utilities/EtherealTorchAttack", new object[]
		{
			this.a(A_0).a(true),
			Convert.ToInt32(v3.a * 100.0)
		});
	}

	// Token: 0x0600AD2A RID: 44330 RVA: 0x003FAF10 File Offset: 0x003F9110
	public override string bo(cnm A_0)
	{
		return this.bp(A_0);
	}

	// Token: 0x0600AD2B RID: 44331 RVA: 0x003FAF1C File Offset: 0x003F911C
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, 3000, true, false));
		}
		return list;
	}

	// Token: 0x0600AD2C RID: 44332 RVA: 0x003FAF50 File Offset: 0x003F9150
	public override IList<string> bi()
	{
		return this.b;
	}

	// Token: 0x0600AD2D RID: 44333 RVA: 0x003FAF5C File Offset: 0x003F915C
	public a1q a(cnm A_0)
	{
		double num = 1.0;
		if (A_0 != null && A_0.b8() != null && A_0.b8().StatusEffects.a(cwy.a))
		{
			num = 1.5;
		}
		return new a1q(DamageType.Energy, Convert.ToInt32(40.0 * num), Convert.ToInt32(80.0 * num));
	}

	// Token: 0x0600AD2E RID: 44334 RVA: 0x003FAFD0 File Offset: 0x003F91D0
	public double[] f2(cnm A_0, double A_1, bool A_2, cmn A_3)
	{
		int a_ = this.b(A_0);
		return euf.a(A_0.b8(), a_, A_1, 0.0);
	}

	// Token: 0x0600AD2F RID: 44335 RVA: 0x003FAFFC File Offset: 0x003F91FC
	public int b(cnm A_0)
	{
		int result;
		if (A_0 != null && A_0.b8() != null)
		{
			result = c2h.a(A_0.b8().BaseAbilities.Will / 2 + 4, A_0.b8().Level, 5.0);
			if (A_0.b8().StatusEffects.a(cwy.a))
			{
				result = c2h.a(Math.Max(12, A_0.b8().BaseAbilities.Will), A_0.b8().Level, 5.0);
			}
		}
		else
		{
			result = 50;
		}
		return result;
	}

	// Token: 0x0600AD30 RID: 44336 RVA: 0x003FB09C File Offset: 0x003F929C
	protected override float f0(cnm A_0)
	{
		return 10f;
	}

	// Token: 0x0600AD31 RID: 44337 RVA: 0x003FB0A4 File Offset: 0x003F92A4
	protected override int hi(cnm A_0)
	{
		return 25;
	}

	// Token: 0x0600AD32 RID: 44338 RVA: 0x003FB0A8 File Offset: 0x003F92A8
	protected override int d2(cnm A_0)
	{
		return 2;
	}

	// Token: 0x04004067 RID: 16487
	public new static readonly double a = 0.5;

	// Token: 0x04004068 RID: 16488
	private List<string> b;
}

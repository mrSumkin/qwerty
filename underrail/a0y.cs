using System;
using System.Collections.Generic;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001E8C RID: 7820
public abstract class a0y : ehl, bix
{
	// Token: 0x0600AEFD RID: 44797 RVA: 0x003FD070 File Offset: 0x003FB270
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600AEFE RID: 44798 RVA: 0x003FD074 File Offset: 0x003FB274
	public override string c1()
	{
		return "Бросает";
	}

	// Token: 0x0600AEFF RID: 44799 RVA: 0x003FD07C File Offset: 0x003FB27C
	public override bool cz()
	{
		return true;
	}

	// Token: 0x0600AF00 RID: 44800 RVA: 0x003FD080 File Offset: 0x003FB280
	public override a3b c0()
	{
		return new a3b
		{
			a = c0e.i,
			b = new int?(int.MaxValue),
			c = c0e.i
		};
	}

	// Token: 0x0600AF01 RID: 44801 RVA: 0x003FD0B0 File Offset: 0x003FB2B0
	public override IList<string> bi()
	{
		return new List<string>();
	}

	// Token: 0x0600AF02 RID: 44802 RVA: 0x003FD0B8 File Offset: 0x003FB2B8
	public override TimelapseCursor? bj()
	{
		return new TimelapseCursor?(TimelapseCursor.InvokeHostileSpellWithChance);
	}

	// Token: 0x0600AF03 RID: 44803 RVA: 0x003FD0C4 File Offset: 0x003FB2C4
	public override string bo(cnm A_0)
	{
		return string.Empty;
	}

	// Token: 0x0600AF04 RID: 44804 RVA: 0x003FD0CC File Offset: 0x003FB2CC
	public override string bp(cnm A_0)
	{
		return qv.a("ThrowingKnives/Regular", new object[]
		{
			a0y.a(A_0).a(true),
			Convert.ToInt32(as3.a2 * 100.0),
			Convert.ToInt32(a0y.e * 100f),
			Convert.ToInt32(a0y.d * 100.0)
		});
	}

	// Token: 0x0600AF05 RID: 44805 RVA: 0x003FD14C File Offset: 0x003FB34C
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600AF06 RID: 44806 RVA: 0x003FD150 File Offset: 0x003FB350
	public override dsk cv(cnm A_0)
	{
		return dsk.b;
	}

	// Token: 0x0600AF07 RID: 44807 RVA: 0x003FD154 File Offset: 0x003FB354
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600AF08 RID: 44808 RVA: 0x003FD15C File Offset: 0x003FB35C
	public new static a1q a(cnm A_0)
	{
		int num;
		if (A_0 != null && A_0.b8() != null)
		{
			num = A_0.b8().Skills.Get<dei>().g();
		}
		else
		{
			num = 0;
		}
		return new a1q(DamageType.Mechanical, (int)(8.0 + 0.12 * (double)num), (int)(9.0 + 0.24 * (double)num));
	}

	// Token: 0x0600AF09 RID: 44809 RVA: 0x003FD1CC File Offset: 0x003FB3CC
	public bg3 bs(cnm A_0, efk A_1, double A_2, double A_3, bool A_4, bool A_5, c3u A_6)
	{
		if (A_0 != null && A_0.b8() != null)
		{
			double a_ = 0.0;
			ea3 microfeat = A_0.b8().GetMicrofeat<ea3>();
			if (microfeat != null)
			{
				a_ = microfeat.a();
			}
			return euf.a(A_0.b8(), A_1, A_2, A_3, A_4, A_5, 1.0, c3u.a, a_);
		}
		return null;
	}

	// Token: 0x0600AF0A RID: 44810 RVA: 0x003FD230 File Offset: 0x003FB430
	protected override int br(cnm A_0)
	{
		return 500;
	}

	// Token: 0x0600AF0B RID: 44811 RVA: 0x003FD238 File Offset: 0x003FB438
	protected override float f0(cnm A_0)
	{
		return (float)as3.aw;
	}

	// Token: 0x0600AF0C RID: 44812 RVA: 0x003FD240 File Offset: 0x003FB440
	protected override int hi(cnm A_0)
	{
		int num = 0;
		double num2;
		if (A_0 != null && A_0.b8() != null)
		{
			num2 = euf.a(A_0.b8());
			au9 microfeat = A_0.b8().GetMicrofeat<au9>();
			if (microfeat != null)
			{
				num = microfeat.a();
			}
		}
		else
		{
			num2 = 1.0;
		}
		return Math.Max(0, (int)((double)as3.az * num2) + num);
	}

	// Token: 0x04004093 RID: 16531
	private new const double a = 8.0;

	// Token: 0x04004094 RID: 16532
	private const double b = 0.12;

	// Token: 0x04004095 RID: 16533
	private const double c = 0.24;

	// Token: 0x04004096 RID: 16534
	public static readonly double d = 0.75;

	// Token: 0x04004097 RID: 16535
	public new static readonly float e = 1.3f;
}

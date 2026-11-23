using System;
using System.Collections.Generic;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001E8A RID: 7818
[ayj("ShockShurikenThrow")]
public sealed class ew2 : ehl, bix
{
	// Token: 0x0600AEE4 RID: 44772 RVA: 0x003FCD38 File Offset: 0x003FAF38
	public override string y8()
	{
		return "Бросок шокового сюрикена";
	}

	// Token: 0x0600AEE5 RID: 44773 RVA: 0x003FCD40 File Offset: 0x003FAF40
	public override string os()
	{
		return "ShockShurikenThrow";
	}

	// Token: 0x0600AEE6 RID: 44774 RVA: 0x003FCD48 File Offset: 0x003FAF48
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600AEE7 RID: 44775 RVA: 0x003FCD4C File Offset: 0x003FAF4C
	public override string c1()
	{
		return "Бросает";
	}

	// Token: 0x0600AEE8 RID: 44776 RVA: 0x003FCD54 File Offset: 0x003FAF54
	public override bool cz()
	{
		return true;
	}

	// Token: 0x0600AEE9 RID: 44777 RVA: 0x003FCD58 File Offset: 0x003FAF58
	public override a3b c0()
	{
		return new a3b
		{
			a = c0e.j,
			b = new int?(int.MaxValue),
			c = c0e.j,
			d = new int?(40)
		};
	}

	// Token: 0x0600AEEA RID: 44778 RVA: 0x003FCD94 File Offset: 0x003FAF94
	public override IList<string> bi()
	{
		return new List<string>();
	}

	// Token: 0x0600AEEB RID: 44779 RVA: 0x003FCD9C File Offset: 0x003FAF9C
	public override TimelapseCursor? bj()
	{
		return new TimelapseCursor?(TimelapseCursor.InvokeHostileSpellWithChance);
	}

	// Token: 0x0600AEEC RID: 44780 RVA: 0x003FCDA8 File Offset: 0x003FAFA8
	public override string bo(cnm A_0)
	{
		return string.Empty;
	}

	// Token: 0x0600AEED RID: 44781 RVA: 0x003FCDB4 File Offset: 0x003FAFB4
	public override string bp(cnm A_0)
	{
		return qv.a("ThrowingKnives/ShockShuriken", new object[]
		{
			ew2.b(A_0).a(true),
			ew2.a(A_0).a(true),
			Convert.ToInt32(as3.a2 * 100.0),
			Convert.ToInt32(a0y.e * 100f),
			Convert.ToInt32(ew2.g * 100.0)
		});
	}

	// Token: 0x0600AEEE RID: 44782 RVA: 0x003FCE48 File Offset: 0x003FB048
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600AEEF RID: 44783 RVA: 0x003FCE4C File Offset: 0x003FB04C
	public override dsk cv(cnm A_0)
	{
		return dsk.b;
	}

	// Token: 0x0600AEF0 RID: 44784 RVA: 0x003FCE50 File Offset: 0x003FB050
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600AEF1 RID: 44785 RVA: 0x003FCE54 File Offset: 0x003FB054
	public static a1q b(cnm A_0)
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
		return new a1q(DamageType.Mechanical, (int)(6.0 + 0.06 * (double)num), (int)(16.0 + 0.16 * (double)num));
	}

	// Token: 0x0600AEF2 RID: 44786 RVA: 0x003FCEC4 File Offset: 0x003FB0C4
	public new static a1q a(cnm A_0)
	{
		return new a1q(DamageType.Electricity, 30, 45);
	}

	// Token: 0x0600AEF3 RID: 44787 RVA: 0x003FCED4 File Offset: 0x003FB0D4
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

	// Token: 0x0600AEF4 RID: 44788 RVA: 0x003FCF38 File Offset: 0x003FB138
	protected override int br(cnm A_0)
	{
		return 0;
	}

	// Token: 0x0600AEF5 RID: 44789 RVA: 0x003FCF3C File Offset: 0x003FB13C
	protected override float f0(cnm A_0)
	{
		return (float)as3.aw;
	}

	// Token: 0x0600AEF6 RID: 44790 RVA: 0x003FCF44 File Offset: 0x003FB144
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

	// Token: 0x0400408C RID: 16524
	private new const int a = 6;

	// Token: 0x0400408D RID: 16525
	private const int b = 16;

	// Token: 0x0400408E RID: 16526
	private const double c = 0.06;

	// Token: 0x0400408F RID: 16527
	private const double d = 0.16;

	// Token: 0x04004090 RID: 16528
	private new const int e = 30;

	// Token: 0x04004091 RID: 16529
	private const int f = 45;

	// Token: 0x04004092 RID: 16530
	public new static readonly double g = 0.35;
}

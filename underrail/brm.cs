using System;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001E87 RID: 7815
public abstract class brm : ehl, bix
{
	// Token: 0x0600AEC9 RID: 44745 RVA: 0x003FCAF4 File Offset: 0x003FACF4
	public override string y8()
	{
		return "Бросок колбы с кислотой";
	}

	// Token: 0x0600AECA RID: 44746 RVA: 0x003FCAFC File Offset: 0x003FACFC
	public override string c1()
	{
		return "Бросает";
	}

	// Token: 0x0600AECB RID: 44747 RVA: 0x003FCB04 File Offset: 0x003FAD04
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600AECC RID: 44748 RVA: 0x003FCB08 File Offset: 0x003FAD08
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600AECD RID: 44749 RVA: 0x003FCB0C File Offset: 0x003FAD0C
	public override a3b c0()
	{
		return new a3b
		{
			a = c0e.i,
			b = new int?(int.MaxValue),
			c = c0e.i
		};
	}

	// Token: 0x0600AECE RID: 44750 RVA: 0x003FCB3C File Offset: 0x003FAD3C
	public override TimelapseCursor? bj()
	{
		return new TimelapseCursor?(TimelapseCursor.InvokeHostileSpellWithChance);
	}

	// Token: 0x0600AED0 RID: 44752 RVA: 0x003FCB50 File Offset: 0x003FAD50
	public override string bo(cnm A_0)
	{
		return string.Empty;
	}

	// Token: 0x0600AED1 RID: 44753 RVA: 0x003FCB58 File Offset: 0x003FAD58
	public override string bp(cnm A_0)
	{
		return string.Empty;
	}

	// Token: 0x0600AED2 RID: 44754 RVA: 0x003FCB60 File Offset: 0x003FAD60
	public override string bm(cnm A_0)
	{
		return "Misc.0";
	}

	// Token: 0x0600AED3 RID: 44755 RVA: 0x003FCB6C File Offset: 0x003FAD6C
	public bg3 bs(cnm A_0, efk A_1, double A_2, double A_3, bool A_4, bool A_5, c3u A_6)
	{
		if (A_0 != null && A_0.b8() != null)
		{
			return euf.a(A_0.b8(), A_1, A_2, A_3, A_4, A_5, 1.0, c3u.a, 0.0);
		}
		return null;
	}

	// Token: 0x0600AED4 RID: 44756 RVA: 0x003FCBB4 File Offset: 0x003FADB4
	protected override int br(cnm A_0)
	{
		return 1000;
	}

	// Token: 0x0600AED5 RID: 44757 RVA: 0x003FCBBC File Offset: 0x003FADBC
	protected override float f0(cnm A_0)
	{
		return 7f;
	}

	// Token: 0x0600AED6 RID: 44758 RVA: 0x003FCBC4 File Offset: 0x003FADC4
	public override dsk cv(cnm A_0)
	{
		return dsk.b;
	}

	// Token: 0x0600AED7 RID: 44759 RVA: 0x003FCBC8 File Offset: 0x003FADC8
	protected override int hi(cnm A_0)
	{
		double num;
		if (A_0 != null && A_0.b8() != null)
		{
			num = euf.a(A_0.b8());
		}
		else
		{
			num = 1.0;
		}
		return Convert.ToInt32(30.0 * num);
	}
}

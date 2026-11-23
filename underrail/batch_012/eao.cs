using System;

// Token: 0x02001F5B RID: 8027
[ayj("PlacePoisonedBearTrap")]
public sealed class eao : blb
{
	// Token: 0x0600BB6A RID: 47978 RVA: 0x00414C0C File Offset: 0x00412E0C
	public override string y8()
	{
		return "Place Poisoned Bear Trap";
	}

	// Token: 0x0600BB6B RID: 47979 RVA: 0x00414C14 File Offset: 0x00412E14
	public override string os()
	{
		return "PlacePoisonedBearTrap";
	}

	// Token: 0x0600BB6C RID: 47980 RVA: 0x00414C1C File Offset: 0x00412E1C
	public override string bp(cnm A_0)
	{
		coh a_ = (A_0 != null) ? (A_0.b9() as coh) : null;
		int num = eao.a(a_);
		string text = cl5.b(a_);
		if (string.IsNullOrEmpty(text))
		{
			text = "poison";
		}
		else
		{
			text = text.ToLowerInvariant();
		}
		string a_2;
		if (num > 1)
		{
			a_2 = "Traps/PoisonedBearTrapStacked";
		}
		else
		{
			a_2 = "Traps/PoisonedBearTrap";
		}
		return qv.a(a_2, new object[]
		{
			blb.a().a(true),
			(int)(blb.c * 100.0),
			l4.a(blb.d, false),
			l4.a(blb.e, false),
			num,
			text,
			cl5.a(a_, (A_0 != null) ? A_0.b8() : null),
			cl5.d(a_)
		});
	}

	// Token: 0x0600BB6D RID: 47981 RVA: 0x00414D14 File Offset: 0x00412F14
	public new static int a(coh A_0)
	{
		if (A_0 != null)
		{
			return Math.Max(1, cl5.a(A_0) / 2);
		}
		return 1;
	}
}

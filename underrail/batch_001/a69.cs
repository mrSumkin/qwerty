using System;
using System.Linq;

// Token: 0x020008AF RID: 2223
public sealed class a69 : el4
{
	// Token: 0x0600373E RID: 14142 RVA: 0x0014BC08 File Offset: 0x00149E08
	protected override esj a3()
	{
		return new esj(3, 3);
	}

	// Token: 0x0600373F RID: 14143 RVA: 0x0014BC14 File Offset: 0x00149E14
	public override string a4()
	{
		return "Xpbl_SOR_MHC1";
	}

	// Token: 0x06003740 RID: 14144 RVA: 0x0014BC1C File Offset: 0x00149E1C
	public override string a5()
	{
		return "Global Event - Sørmirbæren Honey Collectors 1";
	}

	// Token: 0x06003741 RID: 14145 RVA: 0x0014BC24 File Offset: 0x00149E24
	public override string ix()
	{
		return "xpbl";
	}

	// Token: 0x06003742 RID: 14146 RVA: 0x0014BC2C File Offset: 0x00149E2C
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		return base.e2(A_0, A_1, A_2) && !A_0.r().GetPrimitivePropertyValue<bool>("faction_xpbl_sormirbaren_defeated", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_camp_underAttack", new bool?(false)).Value;
	}

	// Token: 0x06003743 RID: 14147 RVA: 0x0014BC90 File Offset: 0x00149E90
	public override double ke()
	{
		return 0.11;
	}

	// Token: 0x06003744 RID: 14148 RVA: 0x0014BC9C File Offset: 0x00149E9C
	public override bool fk()
	{
		return true;
	}

	// Token: 0x06003745 RID: 14149 RVA: 0x0014BCA0 File Offset: 0x00149EA0
	public override bool fl()
	{
		return true;
	}

	// Token: 0x06003746 RID: 14150 RVA: 0x0014BCA4 File Offset: 0x00149EA4
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(60.0));
	}

	// Token: 0x06003747 RID: 14151 RVA: 0x0014BCBC File Offset: 0x00149EBC
	public a69() : base(new string[]
	{
		ega.a7
	})
	{
	}

	// Token: 0x06003748 RID: 14152 RVA: 0x0014BCD4 File Offset: 0x00149ED4
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		foreach (aud aud in Enumerable.ToList<aud>(A_1.Areas))
		{
			foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
			{
				c5x c5x = (c5x)b0b;
				if (c5x.h.b != null && c5x.h.b.aa().FactionId == asp.ge)
				{
					cya aspect = c5x.GetAspect<cya>();
					if (aspect != null)
					{
						aspect.a(0);
						aspect.c(0);
					}
					c5x.h.b.aa().a(null, null, false);
				}
			}
		}
	}
}

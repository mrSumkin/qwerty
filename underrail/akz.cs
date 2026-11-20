using System;
using System.Linq;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02000BC8 RID: 3016
public sealed class akz : eny
{
	// Token: 0x06004519 RID: 17689 RVA: 0x001C1870 File Offset: 0x001BFA70
	public override string mt()
	{
		return "ironHead";
	}

	// Token: 0x0600451A RID: 17690 RVA: 0x001C1878 File Offset: 0x001BFA78
	public override int? mu()
	{
		return new int?(5);
	}

	// Token: 0x0600451B RID: 17691 RVA: 0x001C1880 File Offset: 0x001BFA80
	public override int? mv()
	{
		return new int?(15);
	}

	// Token: 0x0600451C RID: 17692 RVA: 0x001C188C File Offset: 0x001BFA8C
	public override void mw(coh A_0, int A_1)
	{
		int num = base.b(A_1);
		base.mw(A_0, num);
		bqu bqu = A_0.Definition as bqu;
		if (bqu != null)
		{
			double num2 = base.a(num);
			if (bqu.i().Count > 0)
			{
				bqu.i()[0] = new du2(DamageType.Mechanical, Convert.ToInt32(3.0 + 2.0 * num2 * cuo.a(0.3)), Math.Round(0.03 + 0.02 * num2 * cuo.a(0.3), 2));
			}
			if (bqu.f().Count > 0)
			{
				eey eey = bqu.f()[0] as eey;
				if (eey != null)
				{
					eey.Bonus = d05.c(0.5 + num2 * 0.5 * cuo.a(0.2), 0.05);
				}
			}
			l5 l = Enumerable.FirstOrDefault<l5>(Enumerable.OfType<l5>(bqu.ar()));
			if (l != null)
			{
				l.Modifier = Math.Round(-0.03 - 0.035 * num2 * cuo.a(0.3), 3);
			}
			dcp dcp = Enumerable.FirstOrDefault<dcp>(Enumerable.OfType<dcp>(bqu.ar()));
			if (dcp != null)
			{
				dcp.Modifier = Math.Round(-0.1 - 0.06 * num2 * cuo.a(0.3), 2);
			}
			base.a(bqu, num, 0.35);
		}
	}
}

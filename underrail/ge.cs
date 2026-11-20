using System;
using System.Linq;

// Token: 0x02000354 RID: 852
public sealed class ge : d24
{
	// Token: 0x06001820 RID: 6176 RVA: 0x00079F74 File Offset: 0x00078174
	public override abg f7()
	{
		bzv bzv = new bzv(base.b().c().y6());
		int num = 0;
		foreach (blk blk in bzv.b())
		{
			if (blk.e() != null && blk.e().a8() != null && blk.e().aa().FactionId == asp.ax && blk.e().aa().Offense.u().TypedDefinition.a5() == "openShellWeapon" && (blk.e().a8().s() - base.b().g().a8().s()).Length() <= 10f)
			{
				num++;
			}
		}
		cng cng = Enumerable.FirstOrDefault<cng>(base.b().g().aa().StatusEffects.Get<cng>());
		if (num == 0)
		{
			if (cng != null)
			{
				base.b().g().aa().StatusEffects.d(cng);
			}
			base.b().d()["psiSynergy"] = 0;
		}
		else
		{
			int a_ = d05.a(1, Convert.ToInt32((double)(num * 5) * this.a), 99);
			if (cng != null)
			{
				cng.Stacks = a_;
				cng.ad();
			}
			else
			{
				cng = new cng(d0u.b * 2);
				cng.Stacks = a_;
				base.b().g().aa().StatusEffects.a(cng, false, false, false);
			}
			base.b().d()["psiSynergy"] = cng.Stacks / 5;
		}
		base.b().g().aa().bl();
		return base.f7();
	}

	// Token: 0x04000E22 RID: 3618
	public new double a = 1.0;
}

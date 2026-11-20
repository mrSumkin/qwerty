using System;
using System.Linq;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001220 RID: 4640
public class cen : dip
{
	// Token: 0x060063EF RID: 25583 RVA: 0x002B0014 File Offset: 0x002AE214
	public override string md()
	{
		return "rc";
	}

	// Token: 0x060063F0 RID: 25584 RVA: 0x002B001C File Offset: 0x002AE21C
	public override string me()
	{
		return "LargeRock";
	}

	// Token: 0x060063F1 RID: 25585 RVA: 0x002B0024 File Offset: 0x002AE224
	protected virtual string as5()
	{
		return "LargeRockImpact";
	}

	// Token: 0x060063F2 RID: 25586 RVA: 0x002B002C File Offset: 0x002AE22C
	public override void q5(ak1 A_0, c5x A_1)
	{
		if (A_0 != null && A_0.Area != null && A_0.c.Count > 0)
		{
			c5x a_ = Enumerable.FirstOrDefault<b0b>(A_0.c.Values) as c5x;
			if (!aw1.a(A_0, false, null, l9.b))
			{
				eym.a(a_, (double)aju.bz);
				a_.c().a("RockSplash");
				boj.d(A_0);
				return;
			}
			eym.a(a_, (double)aju.by);
			a_.c().a("RockCrash");
			aud a_2 = A_0.Area;
			Vector3 a_3 = A_0.Location.a();
			HorizontalDirection? a_4 = (A_1 != null) ? new HorizontalDirection?(A_1.VisualDirection) : null;
			string a_5 = this.as5();
			int a_6 = 1;
			double maxValue = double.MaxValue;
			float? a_7 = dz6.b();
			boj.a(a_2, a_3, a_4, a_5, a_6, maxValue, null, null, a_7, null);
			awb awb = new awb(A_0, new asi(), null, 1f, null, null, false);
			awb.r = true;
			A_0.Zone.ActionManager.g9(awb, atp.a);
			dz6.a(awb);
		}
	}

	// Token: 0x060063F3 RID: 25587 RVA: 0x002B0174 File Offset: 0x002AE374
	protected override cd1 mf(efk A_0)
	{
		bke bke = new bke();
		bke.g("Rock");
		bke.k("sp:Rock");
		bke.f("Misc.0");
		bke.a(35);
		bke.f(0.05);
		bke.c(as3.bk);
		bke.d(as3.bk);
		bke.b((float)bke.v() * d0u.c);
		bke.a(btz.g);
		bke.a(ImpactSpeed.VeryLow);
		bke.a(esu.f);
		bke.a(bhx.e);
		bke.a(AmmoType.Sledgehammer);
		bke.g(true);
		bke.a(new WeaponSubtype?(WeaponSubtype.Sledgehammer));
		bke.am().Add("RockHitHeavy");
		bke.l().Add(new a1q(DamageType.Mechanical, 40, 65));
		return new cd1(new IndependentItemDefinitionProvider<bke>(bke));
	}
}

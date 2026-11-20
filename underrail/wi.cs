using System;
using System.Linq;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02000BCA RID: 3018
public sealed class wi : eny
{
	// Token: 0x06004523 RID: 17699 RVA: 0x001C1B30 File Offset: 0x001BFD30
	public override string mt()
	{
		return "boningKnife";
	}

	// Token: 0x06004524 RID: 17700 RVA: 0x001C1B38 File Offset: 0x001BFD38
	public override int? mu()
	{
		return new int?(5);
	}

	// Token: 0x06004525 RID: 17701 RVA: 0x001C1B40 File Offset: 0x001BFD40
	public override int? mv()
	{
		return new int?(15);
	}

	// Token: 0x06004526 RID: 17702 RVA: 0x001C1B4C File Offset: 0x001BFD4C
	public override void mw(coh A_0, int A_1)
	{
		int num = base.b(A_1);
		base.mw(A_0, num);
		bke bke = A_0.Definition as bke;
		if (bke != null)
		{
			double num2 = base.a(num);
			double a_ = 0.1 + num2 * 0.3 * cuo.a(0.3);
			int a_2 = Math.Max(1, Convert.ToInt32(7.0 * num2 * cuo.a(0.5)));
			erz erz = Enumerable.FirstOrDefault<erz>(Enumerable.OfType<erz>(bke.ar()));
			if (erz != null)
			{
				erz.DamageBonus = a_;
			}
			dpw dpw = Enumerable.FirstOrDefault<dpw>(Enumerable.Where<dpw>(Enumerable.OfType<dpw>(bke.ar()), new Func<dpw, bool>(wi.a.a.a)));
			if (dpw != null)
			{
				dpw.a(a_2);
			}
			bke.l().Clear();
			b1j b1j = c4r.a(null, WeaponSubtype.Knife, (double)num, 1.1, null, null);
			bke.l().Add(new a1q(DamageType.Mechanical, (int)b1j.b, (int)b1j.c));
			base.a(bke, num, 0.35);
		}
	}

	// Token: 0x02000BCB RID: 3019
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600452A RID: 17706 RVA: 0x001C1CC4 File Offset: 0x001BFEC4
		internal bool a(dpw A_0)
		{
			return A_0.SkillName == SkillEnum.Biology.ToString();
		}

		// Token: 0x04001C6A RID: 7274
		public static readonly wi.a a = new wi.a();

		// Token: 0x04001C6B RID: 7275
		public static Func<dpw, bool> b;
	}
}

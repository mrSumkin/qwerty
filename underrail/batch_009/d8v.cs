using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x020016AF RID: 5807
[eiz("SXWSA")]
[Serializable]
public sealed class d8v : a6k, ISerializable
{
	// Token: 0x06007EBB RID: 32443 RVA: 0x00358CA4 File Offset: 0x00356EA4
	private d8v(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007EBC RID: 32444 RVA: 0x00358CB0 File Offset: 0x00356EB0
	public d8v()
	{
	}

	// Token: 0x06007EBD RID: 32445 RVA: 0x00358CBC File Offset: 0x00356EBC
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.vg().q() == null || base.vg().q().h == null || base.vg().q().h.b == null)
		{
			return dc4.e;
		}
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h == null || c5x.h.b == null)
		{
			return dc4.e;
		}
		c8d c8d = base.vg().q().h.b.aa().Gear.l().Item;
		if (c8d == null || c8d.Battery < (double)bti.c)
		{
			return dc4.e;
		}
		base.vg().q().c().a("WristbladeShing");
		c8d.Battery -= (double)bti.c;
		bke bke = sy.b(base.vg().e());
		cd1 cd = new cd1(new IndependentItemDefinitionProvider<bke>(bke));
		a1q a_ = sy.a(base.vg().e());
		cmn cmn = awq.b(base.vg().q().h.b, c5x.h.b, null);
		cmn.a = c3u.a;
		efk a_2 = base.vg().e().b8();
		efk a_3 = c5x.h.b.aa();
		cmn a_4 = cmn;
		double a_5 = 0.0;
		cd1 a_6 = cd;
		cwt cwt = euf.a(a_2, a_3, a_4, a_5, null, 1.0, a_6, false);
		cwt.f.Clear();
		cwt.f.Add(euf.a(a_, cwt.e ? (1.0 + bke.y()) : 1.0));
		cwt.k = "Наручный клинок";
		awq.a(base.vg().q().h.b, c5x.h.b, cwt, cd, new d8v.a(this));
		return dc4.c;
	}

	// Token: 0x020016B0 RID: 5808
	[eiz("SXWSAa")]
	[Serializable]
	private new sealed class a : enp, ISerializable
	{
		// Token: 0x06007EBE RID: 32446 RVA: 0x00358EE0 File Offset: 0x003570E0
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.a = (A_0.GetValue("SXWSAa:P", typeof(d8v)) as d8v);
		}

		// Token: 0x06007EBF RID: 32447 RVA: 0x00358F08 File Offset: 0x00357108
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("SXWSAa:P", this.a);
		}

		// Token: 0x06007EC0 RID: 32448 RVA: 0x00358F1C File Offset: 0x0035711C
		public a(d8v A_0)
		{
			this.a = A_0;
		}

		// Token: 0x06007EC1 RID: 32449 RVA: 0x00358F2C File Offset: 0x0035712C
		public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
		{
			if (cuo.a.NextDouble() >= (double)sy.d)
			{
				return;
			}
			if (A_1 != null && A_0 != null && A_2.b && (A_3 == null || !A_3.c) && A_3.a != null && A_3.a.Count > 0 && ((!A_1.aa().Passive && !A_1.aa().b(d8o.e)) || !A_1.aa().d(CharacterImmunities.Bleeding)))
			{
				int num = Enumerable.Sum<csk>(Enumerable.Where<csk>(A_3.a, new Func<csk, bool>(d8v.a.a.a.a)), new Func<csk, int>(d8v.a.a.a.b));
				if (num > 0)
				{
					int a_ = (int)Math.Max(sy.e * (float)num / (float)sy.f, 1f);
					a5e a_2 = new a5e((A_2.i != null) ? A_2.i.b : null, sy.f * d0u.b, a_, "bleedingWound", null);
					A_1.aa().StatusEffects.a(a_2, false, false, false);
					awq.c(A_0, A_1);
				}
			}
		}

		// Token: 0x0400321F RID: 12831
		private d8v a;

		// Token: 0x020016B1 RID: 5809
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x06007EC4 RID: 32452 RVA: 0x003590AC File Offset: 0x003572AC
			internal bool a(csk A_0)
			{
				return A_0.DamageType == DamageType.Mechanical;
			}

			// Token: 0x06007EC5 RID: 32453 RVA: 0x003590B8 File Offset: 0x003572B8
			internal int b(csk A_0)
			{
				return A_0.Amount;
			}

			// Token: 0x04003220 RID: 12832
			public static readonly d8v.a.a a = new d8v.a.a();

			// Token: 0x04003221 RID: 12833
			public static Func<csk, bool> b;

			// Token: 0x04003222 RID: 12834
			public static Func<csk, int> c;
		}
	}
}

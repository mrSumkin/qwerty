using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001539 RID: 5433
[eiz("R79")]
[Serializable]
public sealed class bv1 : d64, ISerializable
{
	// Token: 0x0600794F RID: 31055 RVA: 0x0032CDF4 File Offset: 0x0032AFF4
	private bv1(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007950 RID: 31056 RVA: 0x0032CE00 File Offset: 0x0032B000
	public bv1()
	{
	}

	// Token: 0x06007951 RID: 31057 RVA: 0x0032CE08 File Offset: 0x0032B008
	protected override bool gq()
	{
		if (!base.gq())
		{
			return false;
		}
		awq.a(base.c().aa());
		cd1 cd = base.c().aa().Offense.u();
		if (cd.TypedDefinition != null && base.b().a8().j == cgy.b && base.b().a8().Area == base.c().a8().Area)
		{
			double a_ = aw1.b(base.c().a8(), base.b().a8());
			double a_2 = awq.a(base.vg().e(), base.b(), a_);
			cwt cwt = euf.a(base.c().aa(), base.b().aa(), a_, awq.a(base.c(), base.b(), null, null), 0.0, base.b().a8().l(), base.c().aa().Darkvision, cd.CurrentBullet, awq.f(base.c()), a_2, false, null, null, true, null);
			double a_3;
			if (cwt.e)
			{
				a_3 = 1.0 + base.c().aa().Offense.am();
			}
			else
			{
				a_3 = 1.0;
			}
			int a_4 = eyv.a(base.vg().e().b9() as coh);
			bool a_5 = base.b().aa().c(d8o.e) || cwt.c.GetValueOrDefault();
			cwt.f.Add(euf.a(n7.a(base.vg().e().b8(), a_4, a_5), a_3));
			cwt.ad["IsAcidWeapon"] = true;
			awq.a(base.c(), base.b(), cwt, cd, new bv1.a(this, a_4), true, null, null, null, false, false, true, null, null);
			return true;
		}
		return false;
	}

	// Token: 0x0200153A RID: 5434
	[eiz("R79a")]
	[Serializable]
	private new sealed class a : enp, ISerializable
	{
		// Token: 0x06007952 RID: 31058 RVA: 0x0032D048 File Offset: 0x0032B248
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.a = (A_0.GetValue("R79a:P", typeof(bv1)) as bv1);
			this.b = A_0.GetInt32("R79a:O");
		}

		// Token: 0x06007953 RID: 31059 RVA: 0x0032D084 File Offset: 0x0032B284
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("R79a:P", this.a);
			info.AddValue("R79a:O", this.b);
		}

		// Token: 0x06007954 RID: 31060 RVA: 0x0032D0A8 File Offset: 0x0032B2A8
		public a(bv1 A_0, int A_1)
		{
			this.a = A_0;
			this.b = A_1;
		}

		// Token: 0x06007955 RID: 31061 RVA: 0x0032D0C0 File Offset: 0x0032B2C0
		public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
		{
			if (A_1 != null && A_2.b)
			{
				dtb dtb = new dtb();
				dtb.b(false);
				dtb.c(false);
				List<auv> list = dtb.ad();
				c5x a_ = A_1.a8();
				string a_2 = "RustingAcidSplash";
				int a_3 = 1;
				double maxValue = double.MaxValue;
				bool a_4 = true;
				bool a_5 = true;
				float? a_6 = dz6.b();
				list.Add(new a7j(a_, a_2, a_3, maxValue, a_4, a_5, null, null, null, a_6, false, null));
				dtb.ad().Add(new a4s(new bfq(Guid.NewGuid().ToString(), "AcidFizz"), null, new ar7(A_1.a8()), null));
				if (A_3.a != null)
				{
					if (Enumerable.Sum<csk>(Enumerable.Where<csk>(A_3.a, new Func<csk, bool>(bv1.a.a.a.b)), new Func<csk, int>(bv1.a.a.a.a)) > 0)
					{
						dtb.ad().Add(new amd(A_1, new els[]
						{
							new ce(ce.b * d0u.b)
						}));
					}
				}
				A_1.a8().Zone.ActionManager.g9(dtb, atp.a);
				dz6.a(dtb);
			}
		}

		// Token: 0x0400309A RID: 12442
		private bv1 a;

		// Token: 0x0400309B RID: 12443
		private int b;

		// Token: 0x0200153B RID: 5435
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x06007958 RID: 31064 RVA: 0x0032D248 File Offset: 0x0032B448
			internal bool b(csk A_0)
			{
				return A_0.DamageType == DamageType.Acid;
			}

			// Token: 0x06007959 RID: 31065 RVA: 0x0032D254 File Offset: 0x0032B454
			internal int a(csk A_0)
			{
				return A_0.Amount;
			}

			// Token: 0x0400309C RID: 12444
			public static readonly bv1.a.a a = new bv1.a.a();

			// Token: 0x0400309D RID: 12445
			public static Func<csk, bool> b;

			// Token: 0x0400309E RID: 12446
			public static Func<csk, int> c;
		}
	}
}

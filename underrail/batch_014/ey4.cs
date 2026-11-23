using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001555 RID: 5461
[eiz("S79")]
[Serializable]
public sealed class ey4 : d64, ISerializable
{
	// Token: 0x060079B7 RID: 31159 RVA: 0x0032EFB4 File Offset: 0x0032D1B4
	private ey4(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060079B8 RID: 31160 RVA: 0x0032EFC0 File Offset: 0x0032D1C0
	public ey4()
	{
	}

	// Token: 0x060079B9 RID: 31161 RVA: 0x0032EFCC File Offset: 0x0032D1CC
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
			cwt.f.Add(euf.a(aao.a(base.vg().e().b8(), a_4), a_3));
			cwt.ad["IsAcidWeapon"] = true;
			awq.a(base.c(), base.b(), cwt, cd, new ey4.a(this, a_4), true, null, null, null, false, false, true, null, null);
			return true;
		}
		return false;
	}

	// Token: 0x02001556 RID: 5462
	[eiz("S79a")]
	[Serializable]
	private new sealed class a : enp, ISerializable
	{
		// Token: 0x060079BA RID: 31162 RVA: 0x0032F1DC File Offset: 0x0032D3DC
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.a = (A_0.GetValue("S79a:P", typeof(ey4)) as ey4);
			this.b = A_0.GetInt32("S79a:O");
		}

		// Token: 0x060079BB RID: 31163 RVA: 0x0032F218 File Offset: 0x0032D418
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("S79a:P", this.a);
			info.AddValue("S79a:O", this.b);
		}

		// Token: 0x060079BC RID: 31164 RVA: 0x0032F23C File Offset: 0x0032D43C
		public a(ey4 A_0, int A_1)
		{
			this.a = A_0;
			this.b = A_1;
		}

		// Token: 0x060079BD RID: 31165 RVA: 0x0032F254 File Offset: 0x0032D454
		public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
		{
			if (A_1 != null && A_2.b)
			{
				dtb dtb = new dtb();
				dtb.b(false);
				dtb.c(false);
				List<auv> list = dtb.ad();
				c5x a_ = A_1.a8();
				string a_2 = "CorrosiveAcidSplash";
				int a_3 = 1;
				double maxValue = double.MaxValue;
				bool a_4 = true;
				bool a_5 = true;
				float? a_6 = dz6.b();
				list.Add(new a7j(a_, a_2, a_3, maxValue, a_4, a_5, null, null, null, a_6, false, null));
				dtb.ad().Add(new a4s(new bfq(Guid.NewGuid().ToString(), "AcidFizz"), null, new ar7(A_1.a8()), null));
				if (Enumerable.Sum<csk>(Enumerable.Where<csk>(A_3.a, new Func<csk, bool>(ey4.a.a.a.b)), new Func<csk, int>(ey4.a.a.a.a)) > 0)
				{
					dtb.ad().Add(new amd(A_1, new els[]
					{
						new deu(deu.c * d0u.b)
					}));
				}
				A_1.a8().Zone.ActionManager.g9(dtb, atp.a);
				dz6.a(dtb);
			}
		}

		// Token: 0x040030BD RID: 12477
		private ey4 a;

		// Token: 0x040030BE RID: 12478
		private int b;

		// Token: 0x02001557 RID: 5463
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x060079C0 RID: 31168 RVA: 0x0032F3D0 File Offset: 0x0032D5D0
			internal bool b(csk A_0)
			{
				return A_0.DamageType == DamageType.Acid;
			}

			// Token: 0x060079C1 RID: 31169 RVA: 0x0032F3DC File Offset: 0x0032D5DC
			internal int a(csk A_0)
			{
				return A_0.Amount;
			}

			// Token: 0x040030BF RID: 12479
			public static readonly ey4.a.a a = new ey4.a.a();

			// Token: 0x040030C0 RID: 12480
			public static Func<csk, bool> b;

			// Token: 0x040030C1 RID: 12481
			public static Func<csk, int> c;
		}
	}
}

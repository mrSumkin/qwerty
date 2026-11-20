using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02001531 RID: 5425
[eiz("FTA8")]
[Serializable]
public sealed class edl : a6k, ISerializable
{
	// Token: 0x06007934 RID: 31028 RVA: 0x0032BF74 File Offset: 0x0032A174
	private edl(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (Guid)A_0.GetValue("FTA8:I", typeof(Guid));
		this.b = A_0.GetInt32("FTA8:F");
	}

	// Token: 0x06007935 RID: 31029 RVA: 0x0032BFC4 File Offset: 0x0032A1C4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("FTA8:I", this.a);
		info.AddValue("FTA8:F", this.b);
	}

	// Token: 0x06007936 RID: 31030 RVA: 0x0032BFF8 File Offset: 0x0032A1F8
	public edl()
	{
		this.a = Guid.NewGuid();
	}

	// Token: 0x06007937 RID: 31031 RVA: 0x0032C014 File Offset: 0x0032A214
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		amc amc = base.vg().q().h.b;
		c5x c5x = base.vg().h() as c5x;
		amc amc2 = (c5x != null) ? c5x.h.b : null;
		if (amc == null || amc2 == null)
		{
			return dc4.e;
		}
		if (amc2.aa().Dead)
		{
			return dc4.e;
		}
		cd1 cd = amc.aa().Offense.u();
		if (cd.TypedDefinition != null && amc2.a8().j == cgy.b && amc2.a8().Area == amc.a8().Area)
		{
			cmn cmn = awq.b(amc, amc2, null);
			cmn.b += amc.aa().Offense.an();
			cwt cwt = euf.a(amc.aa(), amc2.aa(), cmn, 0.0, null, 1.0, null, true);
			cwt.k = "Шквал";
			awq.a(amc, amc2, cwt, cd, new edl.a(this));
			c5x a_ = amc.a8();
			string a_2 = "Flurry" + this.b.ToString();
			int a_3 = 1;
			double maxValue = double.MaxValue;
			bool a_4 = true;
			bool a_5 = true;
			Vector3? a_6 = new Vector3?(new Vector3(0f, 0f, (float)(-0.2 + 0.4 * cuo.a.NextDouble())));
			float? a_7 = dz6.b();
			boj.a(a_, a_2, a_3, maxValue, a_4, a_5, a_6, null, null, a_7, false);
			int num = this.b + 1;
			this.b = num;
			if (num > 2)
			{
				this.b = 1;
			}
			return dc4.c;
		}
		return dc4.e;
	}

	// Token: 0x04003095 RID: 12437
	private new Guid a;

	// Token: 0x04003096 RID: 12438
	private int b = 1;

	// Token: 0x02001532 RID: 5426
	[eiz("FTA8a")]
	[Serializable]
	private new sealed class a : enp, ISerializable
	{
		// Token: 0x06007938 RID: 31032 RVA: 0x0032C1E4 File Offset: 0x0032A3E4
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.a = (A_0.GetValue("FTA8a:P", typeof(edl)) as edl);
		}

		// Token: 0x06007939 RID: 31033 RVA: 0x0032C20C File Offset: 0x0032A40C
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("FTA8a:P", this.a);
		}

		// Token: 0x0600793A RID: 31034 RVA: 0x0032C220 File Offset: 0x0032A420
		public a(edl A_0)
		{
			this.a = A_0;
		}

		// Token: 0x0600793B RID: 31035 RVA: 0x0032C230 File Offset: 0x0032A430
		public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
		{
			if (A_0 != null && A_1 != null)
			{
				if (A_2.b && A_3.a != null)
				{
					if (Enumerable.Sum<csk>(A_3.a, new Func<csk, int>(edl.a.a.a.a)) > 0)
					{
						c53 a_ = new c53();
						A_0.aa().StatusEffects.a(a_, false, false, false);
						return;
					}
				}
				c53 c = Enumerable.FirstOrDefault<c53>(A_0.aa().StatusEffects.Get<c53>());
				if (c != null)
				{
					A_0.aa().StatusEffects.d(c);
				}
				A_0.aa().Cooldowns.a(new cfd[]
				{
					new cfd(b67.a, b67.b(this.a.vg().e()) * d0u.b, false, false)
				});
				if (A_0.a8() != null && A_0.a8().i.b != null)
				{
					A_0.a8().i.b.a(m7.b, true, false);
				}
			}
		}

		// Token: 0x04003097 RID: 12439
		private edl a;

		// Token: 0x02001533 RID: 5427
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x0600793E RID: 31038 RVA: 0x0032C36C File Offset: 0x0032A56C
			internal int a(csk A_0)
			{
				return A_0.Amount;
			}

			// Token: 0x04003098 RID: 12440
			public static readonly edl.a.a a = new edl.a.a();

			// Token: 0x04003099 RID: 12441
			public static Func<csk, int> b;
		}
	}
}

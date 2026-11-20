using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200168B RID: 5771
[eiz("NBMA")]
[Serializable]
public sealed class bwg : h3, ISerializable
{
	// Token: 0x06007DDB RID: 32219 RVA: 0x003531E8 File Offset: 0x003513E8
	private bwg(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		di7.ReadList<Guid>("NBMA:AE", ref this.a, A_0);
		this.b = (Guid)A_0.GetValue("NBMA:I", typeof(Guid));
		this.c = (Point)A_0.GetValue("NBMA:S", typeof(Point));
	}

	// Token: 0x06007DDC RID: 32220 RVA: 0x0035325C File Offset: 0x0035145C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<Guid>("NBMA:AE", this.a, info);
		info.AddValue("NBMA:I", this.b);
		info.AddValue("NBMA:S", this.c);
	}

	// Token: 0x06007DDD RID: 32221 RVA: 0x003532B0 File Offset: 0x003514B0
	public bwg()
	{
		this.b = Guid.NewGuid();
	}

	// Token: 0x06007DDE RID: 32222 RVA: 0x003532D0 File Offset: 0x003514D0
	public override void cq(aud A_0, Point A_1, float A_2)
	{
		if (A_2 == 0f)
		{
			this.c = A_1;
			boj.c(A_0, A_1);
			Vector3 a_ = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
			HorizontalDirection? a_2 = null;
			string a_3 = "ExplosionStreak";
			int a_4 = 1;
			double maxValue = double.MaxValue;
			float? a_5 = dz6.b();
			boj.a(A_0, a_, a_2, a_3, a_4, maxValue, null, null, a_5, null);
			qy qy = new qy();
			qy.ad().Add(new bm3(dz6.b(200)));
			qy.ad().Add(new au0(A_0, A_1.a() + new Vector3(0.4f, 0.4f, 0f), "BlurredSmokeSlow" + (cuo.a.Next(3) + 1).ToString(), 1, double.MaxValue, new float?(0.66f), null, null));
			A_0.Zone.ActionManager.g9(qy, atp.a);
		}
		if (base.d() != null)
		{
			ak1 ak = A_0.b(A_1.X, A_1.Y);
			if (ak != null)
			{
				if (A_2 != 0f)
				{
					int num = 0;
					while ((float)num < A_2)
					{
						qy qy2 = new qy();
						int a_6 = dz6.b(Convert.ToInt32((double)(15f + Math.Max(0f, 3f - A_2) * 75f) * 0.75 + 0.5 * cuo.a.NextDouble()));
						qy2.ad().Add(new bm3(a_6));
						Vector3 a_7 = this.c.a() + new Vector3(0f, 0f, 0.2f) + new Vector3(0.75f, 0.75f, 0.3f) * Convert.ToSingle(cuo.a.NextDouble());
						Vector3 a_8 = ak.Location.a() + new Vector3(0f, 0f, 0.2f) + new Vector3(0.75f, 0.75f, 0.3f) * Convert.ToSingle(cuo.a.NextDouble());
						a6c item = new a6c(a_7, a_8, ak.Area, "NailCluster", null);
						qy2.ad().Add(item);
						ak.Zone.ActionManager.g9(qy2, atp.a);
						num++;
					}
				}
				foreach (b0b b0b in Enumerable.ToList<b0b>(ak.Entities))
				{
					c5x c5x = b0b as c5x;
					if (c5x != null)
					{
						if (c5x.h.b != null && !this.a.Contains(b0b.qe()))
						{
							this.a(c5x.h.b, A_2);
							this.a.Add(c5x.qe());
						}
						if (c5x.y.b != null)
						{
							c5x.y.b.a(null);
							this.a.Add(c5x.qe());
						}
					}
				}
			}
		}
	}

	// Token: 0x06007DDF RID: 32223 RVA: 0x00353668 File Offset: 0x00351868
	private void a(amc A_0, float A_1)
	{
		if (base.d() != null)
		{
			if (base.c() != null && !A_0.a8().IsPlayer)
			{
				awq.a(base.c(), A_0, true, true, null, true, true, false, false);
			}
			A_0.u();
			double a_ = c18.a(base.c().aa());
			int num = Convert.ToInt32(A_1);
			int num2 = c9.a;
			double num3 = 0.9 - (double)num * 0.18;
			for (int i = c9.a + 1; i <= c9.b; i++)
			{
				if (cuo.a.NextDouble() < num3)
				{
					num2++;
				}
			}
			for (int j = 0; j < num2; j++)
			{
				bool flag = !A_0.aa().ImmuneToCriticalHits && euf.a(a_);
				cwt cwt = new cwt();
				cwt.af = this.b;
				cwt.f.Add(euf.a(c9.a(), (double)(flag ? 2 : 1)));
				cwt.b = true;
				cwt.e = flag;
				cwt.q = true;
				if (base.d().b8() != null)
				{
					cwt.i = new ap9(base.d().b8());
				}
				cwt.h = ImpactSpeed.Medium;
				cwt.k = "бомба с гвоздями";
				cwt.v = "nail";
				cwt.ad["IsGrenade"] = true;
				cru cru = A_0.aa().Defense.a(cwt);
				if (!A_0.aa().b(d8o.e) && !A_0.aa().d(CharacterImmunities.Bleeding) && cru != null && cru.a != null)
				{
					int num4 = Enumerable.Sum<csk>(cru.a, new Func<csk, int>(bwg.a.a.a));
					if (num4 >= c9.g && cuo.a.NextDouble() < c9.e)
					{
						int a_2 = num4 / c9.g;
						a5e a5e = new a5e(base.c().aa().FactionId, c9.g * d0u.b, a_2, "bleedingWound", null);
						A_0.aa().StatusEffects.a(a5e, false, false, false);
						if (cuo.a.NextDouble() < c9.h)
						{
							e1l a_3 = new e1l(a5e.Duration, c6t.a, c6t.b);
							A_0.aa().StatusEffects.a(a_3, false, false, false);
						}
					}
				}
			}
		}
	}

	// Token: 0x040031E3 RID: 12771
	private new List<Guid> a = new List<Guid>();

	// Token: 0x040031E4 RID: 12772
	private Guid b;

	// Token: 0x040031E5 RID: 12773
	private Point c;

	// Token: 0x0200168C RID: 5772
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06007DE2 RID: 32226 RVA: 0x00353940 File Offset: 0x00351B40
		internal int a(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x040031E6 RID: 12774
		public static readonly bwg.a a = new bwg.a();

		// Token: 0x040031E7 RID: 12775
		public static Func<csk, int> b;
	}
}

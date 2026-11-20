using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200168E RID: 5774
[eiz("SBG")]
[Serializable]
public sealed class blo : h3, ISerializable
{
	// Token: 0x06007DEE RID: 32238 RVA: 0x00353F9C File Offset: 0x0035219C
	private blo(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		di7.ReadList<Guid>("SBG:AE", ref this.a, A_0);
		if (ell.a() >= 634)
		{
			this.b = (Point)A_0.GetValue("SBG:S", typeof(Point));
		}
	}

	// Token: 0x06007DEF RID: 32239 RVA: 0x00353FFC File Offset: 0x003521FC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<Guid>("SBG:AE", this.a, info);
		info.AddValue("SBG:S", this.b);
	}

	// Token: 0x06007DF0 RID: 32240 RVA: 0x00354030 File Offset: 0x00352230
	public blo()
	{
	}

	// Token: 0x06007DF1 RID: 32241 RVA: 0x00354044 File Offset: 0x00352244
	public override void cq(aud A_0, Point A_1, float A_2)
	{
		if (A_2 == 0f)
		{
			this.b = A_1;
			boj.c(A_0, A_1);
			Vector3 a_ = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
			HorizontalDirection? a_2 = null;
			string a_3 = "StingballExplosion";
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
				qy qy2 = new qy();
				qy2.b(false);
				qy2.c(false);
				if (A_2 != 0f)
				{
					int num = 0;
					while ((float)num < A_2)
					{
						int a_6 = dz6.b(Convert.ToInt32((double)(15f + Math.Max(0f, 3f - A_2) * 30f) * 0.75 + 0.5 * cuo.a.NextDouble()));
						qy2.ad().Add(new bm3(a_6));
						Vector3 a_7 = this.b.a() + new Vector3(0f, 0f, 0.2f) + new Vector3(0.75f, 0.75f, 0.3f) * Convert.ToSingle(cuo.a.NextDouble());
						Vector3 a_8 = ak.Location.a() + new Vector3(0f, 0f, 0.2f) + new Vector3(0.75f, 0.75f, 0.3f) * Convert.ToSingle(cuo.a.NextDouble());
						a6c item = new a6c(a_7, a_8, ak.Area, "Stingballs", null);
						qy2.ad().Add(item);
						num++;
					}
				}
				foreach (b0b b0b in Enumerable.ToList<b0b>(ak.Entities))
				{
					c5x c5x = b0b as c5x;
					if (c5x != null && c5x.h.b != null && !this.a.Contains(b0b.qe()))
					{
						this.a(qy2, c5x.h.b);
						this.a.Add(c5x.qe());
					}
				}
				ak.Zone.ActionManager.g9(qy2, atp.a);
				dz6.a(qy2);
			}
		}
	}

	// Token: 0x06007DF2 RID: 32242 RVA: 0x003543BC File Offset: 0x003525BC
	private void a(qy A_0, amc A_1)
	{
		if (base.c() != null)
		{
			if (!A_1.a8().IsPlayer && !A_1.aa().Passive && !A_1.aa().c(d8o.e))
			{
				awq.a(base.c(), A_1, true, true, null, true, true, false, false);
			}
			A_1.u();
			cwt cwt = new cwt();
			cwt.f.Add(euf.a(e0d.b(), 1.0));
			cwt.i = new ap9(base.c().aa());
			cwt.j = new ap9(A_1.aa());
			cwt.b = true;
			cwt.q = true;
			cwt.h = ImpactSpeed.Medium;
			cwt.ad["IsGrenade"] = true;
			string a_;
			string a_2;
			string a_3;
			string a_4;
			float a_5;
			float a_6;
			awq.a(A_1, new esu?(esu.e), out a_, out a_2, out a_3, out a_4, out a_5, out a_6, null, false);
			enp a_7 = new kg(new blo.a(), a_, a_2, a_3, a_4, a_5, a_6);
			akg item = new akg(base.c(), A_1, cwt, a_7, false);
			A_0.ad().Add(item);
		}
	}

	// Token: 0x040031EF RID: 12783
	private new List<Guid> a = new List<Guid>();

	// Token: 0x040031F0 RID: 12784
	private Point b;

	// Token: 0x0200168F RID: 5775
	[eiz("SBGa")]
	[Serializable]
	private new sealed class a : ISerializable, enp
	{
		// Token: 0x06007DF3 RID: 32243 RVA: 0x003544E4 File Offset: 0x003526E4
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
		}

		// Token: 0x06007DF4 RID: 32244 RVA: 0x003544EC File Offset: 0x003526EC
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x06007DF5 RID: 32245 RVA: 0x003544F0 File Offset: 0x003526F0
		public a()
		{
		}

		// Token: 0x06007DF6 RID: 32246 RVA: 0x003544FC File Offset: 0x003526FC
		public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
		{
			if (A_3 != null && A_3.a != null)
			{
				if (Enumerable.Sum<csk>(Enumerable.Where<csk>(A_3.a, new Func<csk, bool>(blo.a.a.a.b)), new Func<csk, int>(blo.a.a.a.a)) > 0 && !A_1.aa().Passive)
				{
					if (A_1.aa().d(CharacterImmunities.Stun) || A_1.aa().c(d8o.e))
					{
						etm a_ = new etm(new ap9(A_1.aa()), "оглушению");
						bey.a(a_, A_1.aa(), A_1);
						a7v.a(a_);
						bmj.a(A_1.a8(), new ba0());
						return;
					}
					if (euf.e(e0d.a(), A_1.aa()))
					{
						c6f a_2 = new c6f(new ap9(A_1.aa()), null, "оглушению");
						bey.a(a_2, A_1.aa(), A_1);
						a7v.a(a_2);
						bmj.a(A_1.a8(), new dym());
						return;
					}
					string str;
					els els = awq.a(A_1.aa(), e0d.c(), out str);
					A_1.aa().StatusEffects.a(els, false, false, false);
					A_1.aa().bl();
					if (els is ab3 && !(A_1.aa() is e3q) && A_0 != null && A_0.aa() is e3q)
					{
						cxc.a(eyy.by);
					}
					vr a_3 = new vr(new ap9(A_1.aa()), null, "{0}: " + str + ".", new Color?(adi.j), null);
					bey.a(a_3, A_1.aa(), A_1);
					a7v.a(a_3);
				}
			}
		}

		// Token: 0x02001690 RID: 5776
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x06007DF9 RID: 32249 RVA: 0x003546F4 File Offset: 0x003528F4
			internal bool b(csk A_0)
			{
				return A_0.DamageType == DamageType.Mechanical;
			}

			// Token: 0x06007DFA RID: 32250 RVA: 0x00354700 File Offset: 0x00352900
			internal int a(csk A_0)
			{
				return A_0.Amount;
			}

			// Token: 0x040031F1 RID: 12785
			public static readonly blo.a.a a = new blo.a.a();

			// Token: 0x040031F2 RID: 12786
			public static Func<csk, bool> b;

			// Token: 0x040031F3 RID: 12787
			public static Func<csk, int> c;
		}
	}
}

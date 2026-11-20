using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200151F RID: 5407
[eiz("SA9")]
[Serializable]
public sealed class r1 : d64, ISerializable
{
	// Token: 0x060078F0 RID: 30960 RVA: 0x00329F24 File Offset: 0x00328124
	private r1(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060078F1 RID: 30961 RVA: 0x00329F30 File Offset: 0x00328130
	public r1()
	{
	}

	// Token: 0x060078F2 RID: 30962 RVA: 0x00329F3C File Offset: 0x0032813C
	protected override void bf()
	{
		base.bf();
		cd1 cd = base.c().aa().Offense.u();
		if (cd.TypedDefinition != null && base.c() != null && base.c().a8() != null && base.b() != null && base.b().a8() != null && base.b().a8().j == cgy.b && base.b().a8().Area == base.c().a8().Area)
		{
			cmn cmn = awq.b(base.c(), base.b(), null);
			cmn.b += base.c().aa().Offense.an();
			cwt cwt = euf.a(base.c().aa(), base.b().aa(), cmn, 0.0, null, 1.0, null, true);
			r1.a a_ = null;
			bool flag = false;
			if (!base.b().aa().Passive && base.b().aa().b(d8o.c) && bui.a(bnx.a(base.b().a8().Location.b(), base.b().a8().VisualDirection, base.c().a8().Location.b())))
			{
				if (base.b().aa().SpecialStates.c && !base.b().aa().SpecialStates.h)
				{
					flag = true;
				}
				else if (base.c().aa().SpecialStates.g)
				{
					bm6 b = base.b().a8().t.b;
					if (b != null)
					{
						erl erl = b.c(base.c());
						flag = (erl == null || erl.f() != cem.d);
					}
					else
					{
						flag = true;
					}
				}
			}
			if (flag)
			{
				a_ = new r1.a(this);
				cwt.p = true;
				cwt.l = true;
			}
			cwt.k = "Ломом по башке";
			awq.a(base.c(), base.b(), cwt, cd, a_);
		}
	}

	// Token: 0x02001520 RID: 5408
	[eiz("SA9a")]
	[Serializable]
	private new sealed class a : enp, ISerializable
	{
		// Token: 0x060078F3 RID: 30963 RVA: 0x0032A1B0 File Offset: 0x003283B0
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.a = (A_0.GetValue("SA9a:P", typeof(r1)) as r1);
		}

		// Token: 0x060078F4 RID: 30964 RVA: 0x0032A1D8 File Offset: 0x003283D8
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("SA9a:P", this.a);
		}

		// Token: 0x060078F5 RID: 30965 RVA: 0x0032A1EC File Offset: 0x003283EC
		public a(r1 A_0)
		{
			this.a = A_0;
		}

		// Token: 0x060078F6 RID: 30966 RVA: 0x0032A200 File Offset: 0x00328400
		public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
		{
			if (this.a.b() != null && A_0 != null && A_2.b && A_3.a != null)
			{
				if (Enumerable.Sum<csk>(Enumerable.Where<csk>(A_3.a, new Func<csk, bool>(r1.a.a.a.a)), new Func<csk, int>(r1.a.a.a.b)) > 0)
				{
					if (A_1.aa().Passive || A_1.aa().b(d8o.e) || A_1.aa().d(CharacterImmunities.Incapacitation))
					{
						etm a_ = new etm(new ap9(A_1.aa()), "ошеломлению");
						bey.a(a_, A_0.aa(), A_1.aa(), A_1);
						a7v.a(a_);
						bmj.a(A_1.a8(), new ba0());
						return;
					}
					int num = e0f.b(A_0.aa());
					float num2 = Math.Max(0f, 0.1f * (float)(A_1.aa().BaseAbilities.Constitution - 5));
					cjy a_2 = new cjy((int)Math.Max(1f, (float)num * (1f - num2)) * d0u.b);
					A_1.aa().StatusEffects.a(a_2, false, false, false);
					if (A_1.a8() != null && A_1.a8().t.b != null)
					{
						A_1.a8().t.b.ah();
					}
					if (A_0.aa() is e3q && !(A_1.aa() is e3q))
					{
						cxc.a(eyy.b0);
					}
				}
			}
		}

		// Token: 0x0400307B RID: 12411
		private r1 a;

		// Token: 0x02001521 RID: 5409
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x060078F9 RID: 30969 RVA: 0x0032A3E0 File Offset: 0x003285E0
			internal bool a(csk A_0)
			{
				return A_0.DamageType == DamageType.Mechanical;
			}

			// Token: 0x060078FA RID: 30970 RVA: 0x0032A3EC File Offset: 0x003285EC
			internal int b(csk A_0)
			{
				return A_0.Amount;
			}

			// Token: 0x0400307C RID: 12412
			public static readonly r1.a.a a = new r1.a.a();

			// Token: 0x0400307D RID: 12413
			public static Func<csk, bool> b;

			// Token: 0x0400307E RID: 12414
			public static Func<csk, int> c;
		}
	}
}

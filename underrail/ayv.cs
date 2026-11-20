using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001582 RID: 5506
[eiz("C73")]
[Serializable]
public sealed class ayv : d64, ISerializable
{
	// Token: 0x06007A5F RID: 31327 RVA: 0x00333594 File Offset: 0x00331794
	private ayv(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007A60 RID: 31328 RVA: 0x003335A0 File Offset: 0x003317A0
	public ayv()
	{
	}

	// Token: 0x06007A61 RID: 31329 RVA: 0x003335AC File Offset: 0x003317AC
	protected override void bf()
	{
		base.bf();
		cd1 cd = base.c().aa().Offense.u();
		if (cd.TypedDefinition != null && base.c() != null && base.c().a8() != null && base.b() != null && base.b().a8() != null && base.b().a8().j == cgy.b && base.b().a8().Area == base.c().a8().Area)
		{
			cmn cmn = awq.b(base.c(), base.b(), null);
			cmn.b += base.c().aa().Offense.an();
			cwt cwt = euf.a(base.c().aa(), base.b().aa(), cmn, 0.0, null, 1.0, null, true);
			ayv.a a_ = null;
			bool flag = base.c().aa().GetMicrofeat<ex2>() != null;
			bool flag2 = false;
			if (!base.b().aa().Passive && base.b().aa().b(d8o.c) && !base.b().aa().d(CharacterImmunities.Bleeding) && bui.a(bnx.a(base.b().a8().Location.b(), base.b().a8().VisualDirection, base.c().a8().Location.b())))
			{
				if (base.b().aa().SpecialStates.c && !base.b().aa().SpecialStates.h)
				{
					flag2 = true;
				}
				else if (base.c().aa().SpecialStates.g)
				{
					bm6 b = base.b().a8().t.b;
					if (b != null)
					{
						erl erl = b.c(base.c());
						flag2 = (erl == null || erl.f() != cem.d);
					}
					else
					{
						flag2 = true;
					}
				}
			}
			if (flag2 || flag)
			{
				a_ = new ayv.a(this, !flag2);
				cwt.p = true;
				cwt.l = true;
			}
			cwt.k = "Перерезать глотку";
			awq.a(base.c(), base.b(), cwt, cd, a_);
		}
	}

	// Token: 0x02001583 RID: 5507
	[eiz("C73a")]
	[Serializable]
	private new sealed class a : enp, ISerializable
	{
		// Token: 0x06007A62 RID: 31330 RVA: 0x00333858 File Offset: 0x00331A58
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.a = (A_0.GetValue("C73a:P", typeof(ayv)) as ayv);
			if (ell.a() >= 661)
			{
				this.b = A_0.GetBoolean("C73a:H");
			}
		}

		// Token: 0x06007A63 RID: 31331 RVA: 0x003338AC File Offset: 0x00331AAC
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("C73a:P", this.a);
			info.AddValue("C73a:H", this.b);
		}

		// Token: 0x06007A64 RID: 31332 RVA: 0x003338D0 File Offset: 0x00331AD0
		public a(ayv A_0, bool A_1)
		{
			this.a = A_0;
			this.b = A_1;
		}

		// Token: 0x06007A65 RID: 31333 RVA: 0x003338EC File Offset: 0x00331AEC
		public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
		{
			if (this.a.b() != null && A_2.b && A_3.a != null)
			{
				int num = Enumerable.Sum<csk>(Enumerable.Where<csk>(A_3.a, new Func<csk, bool>(ayv.a.a.a.b)), new Func<csk, int>(ayv.a.a.a.a));
				if (num > 0)
				{
					double num2 = bsk.a(new eoj(A_0.aa(), null, null));
					if (this.b)
					{
						num2 /= 2.0;
					}
					int a_ = (int)Math.Max(1.0, (double)num * num2 / (double)exo.b);
					a5e a_2 = new a5e((A_0 != null) ? A_0.aa().FactionId : null, exo.b * d0u.b, a_, "cutthroat", A_0.aa().Offense.u());
					this.a.b().aa().StatusEffects.a(a_2, false, false, false);
					awq.c(A_0, A_1);
					awq.b(A_0, A_1, exo.b * d0u.b, true);
				}
			}
		}

		// Token: 0x040030F3 RID: 12531
		private ayv a;

		// Token: 0x040030F4 RID: 12532
		private bool b;

		// Token: 0x02001584 RID: 5508
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x06007A68 RID: 31336 RVA: 0x00333A50 File Offset: 0x00331C50
			internal bool b(csk A_0)
			{
				return A_0.DamageType == DamageType.Mechanical;
			}

			// Token: 0x06007A69 RID: 31337 RVA: 0x00333A5C File Offset: 0x00331C5C
			internal int a(csk A_0)
			{
				return A_0.Amount;
			}

			// Token: 0x040030F5 RID: 12533
			public static readonly ayv.a.a a = new ayv.a.a();

			// Token: 0x040030F6 RID: 12534
			public static Func<csk, bool> b;

			// Token: 0x040030F7 RID: 12535
			public static Func<csk, int> c;
		}
	}
}

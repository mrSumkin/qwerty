using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001507 RID: 5383
[eiz("TK02")]
[Serializable]
public sealed class ck8 : bp7, ISerializable
{
	// Token: 0x060078A0 RID: 30880 RVA: 0x00328698 File Offset: 0x00326898
	private ck8(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060078A1 RID: 30881 RVA: 0x003286A4 File Offset: 0x003268A4
	public ck8()
	{
	}

	// Token: 0x060078A2 RID: 30882 RVA: 0x003286AC File Offset: 0x003268AC
	protected override enp r6()
	{
		return new ck8.a();
	}

	// Token: 0x02001508 RID: 5384
	[eiz("TK02a")]
	[Serializable]
	private new sealed class a : enp, ISerializable
	{
		// Token: 0x060078A3 RID: 30883 RVA: 0x003286B4 File Offset: 0x003268B4
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
		}

		// Token: 0x060078A4 RID: 30884 RVA: 0x003286BC File Offset: 0x003268BC
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x060078A5 RID: 30885 RVA: 0x003286C0 File Offset: 0x003268C0
		public a()
		{
		}

		// Token: 0x060078A6 RID: 30886 RVA: 0x003286CC File Offset: 0x003268CC
		public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
		{
			if (A_1 != null)
			{
				if (A_3.c)
				{
					awq.a(A_0, A_1);
				}
				if (!A_1.aa().Dead && A_2.b && A_3.a != null)
				{
					if (Enumerable.Sum<csk>(Enumerable.Where<csk>(A_3.a, new Func<csk, bool>(ck8.a.a.a.b)), new Func<csk, int>(ck8.a.a.a.a)) > 0)
					{
						awq.b(A_0, A_1);
						if (A_1.aa().Passive || A_1.aa().b(d8o.e) || A_1.aa().d(CharacterImmunities.Poison))
						{
							if (A_0 != null)
							{
								etm a_ = new etm(new ap9(A_1.aa()), "яду");
								bey.a(a_, A_0.aa(), A_1.aa(), A_1);
								a7v.a(a_);
							}
							bmj.a(A_1.a8(), new ba0());
							return;
						}
						double num = euf.d(A_1.aa(), 1.0);
						int a = el9.a;
						int c = el9.c;
						int num2 = el9.b;
						string a_2 = "BurrowerPoison";
						string a_3 = "Яд могильщика";
						if (A_0 != null && A_0.aa().Feats.Contains<dt>())
						{
							num2 = (int)((double)num2 * (1.0 + global::dt.a(A_0.aa())));
						}
						int num3 = (int)Math.Max(1.0, (double)a * (1.0 - num));
						c2b a_4 = new c2b((A_0 != null) ? A_0.aa() : null, a_2, a_3, num3 * d0u.b, num2, c);
						A_1.aa().StatusEffects.a(a_4, false, false, false);
					}
				}
			}
		}

		// Token: 0x02001509 RID: 5385
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x060078A9 RID: 30889 RVA: 0x003288D4 File Offset: 0x00326AD4
			internal bool b(csk A_0)
			{
				return A_0.DamageType == DamageType.Mechanical;
			}

			// Token: 0x060078AA RID: 30890 RVA: 0x003288E0 File Offset: 0x00326AE0
			internal int a(csk A_0)
			{
				return A_0.Amount;
			}

			// Token: 0x04003067 RID: 12391
			public static readonly ck8.a.a a = new ck8.a.a();

			// Token: 0x04003068 RID: 12392
			public static Func<csk, bool> b;

			// Token: 0x04003069 RID: 12393
			public static Func<csk, int> c;
		}
	}
}

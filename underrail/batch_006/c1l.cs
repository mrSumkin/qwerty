using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020014ED RID: 5357
[eiz("TK11")]
[Serializable]
public sealed class c1l : bp7, ISerializable
{
	// Token: 0x0600783F RID: 30783 RVA: 0x00325F04 File Offset: 0x00324104
	private c1l(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007840 RID: 30784 RVA: 0x00325F10 File Offset: 0x00324110
	public c1l()
	{
	}

	// Token: 0x06007841 RID: 30785 RVA: 0x00325F18 File Offset: 0x00324118
	protected override enp r6()
	{
		return new c1l.a();
	}

	// Token: 0x020014EF RID: 5359
	[eiz("TK11a")]
	[Serializable]
	private new sealed class a : enp, ISerializable
	{
		// Token: 0x06007847 RID: 30791 RVA: 0x00326A78 File Offset: 0x00324C78
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
		}

		// Token: 0x06007848 RID: 30792 RVA: 0x00326A80 File Offset: 0x00324C80
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x06007849 RID: 30793 RVA: 0x00326A84 File Offset: 0x00324C84
		public a()
		{
		}

		// Token: 0x0600784A RID: 30794 RVA: 0x00326A90 File Offset: 0x00324C90
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
					if (Enumerable.Sum<csk>(Enumerable.Where<csk>(A_3.a, new Func<csk, bool>(c1l.a.a.a.b)), new Func<csk, int>(c1l.a.a.a.a)) > 0)
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
						int num = ezx.v;
						if (A_0 != null && A_0.aa().Feats.Contains<dt>())
						{
							num = (int)((double)num * (1.0 + global::dt.a(A_0.aa())));
						}
						ef5 a_2 = new ef5((A_0 != null) ? A_0.aa() : null, ezx.y * d0u.b, num);
						A_1.aa().StatusEffects.a(a_2, false, false, false);
					}
				}
			}
		}

		// Token: 0x020014F0 RID: 5360
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x0600784D RID: 30797 RVA: 0x00326C44 File Offset: 0x00324E44
			internal bool b(csk A_0)
			{
				return A_0.DamageType == DamageType.Mechanical;
			}

			// Token: 0x0600784E RID: 30798 RVA: 0x00326C50 File Offset: 0x00324E50
			internal int a(csk A_0)
			{
				return A_0.Amount;
			}

			// Token: 0x0400304D RID: 12365
			public static readonly c1l.a.a a = new c1l.a.a();

			// Token: 0x0400304E RID: 12366
			public static Func<csk, bool> b;

			// Token: 0x0400304F RID: 12367
			public static Func<csk, int> c;
		}
	}
}

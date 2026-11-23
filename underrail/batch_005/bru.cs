using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020014F5 RID: 5365
[eiz("TK10")]
[Serializable]
public sealed class bru : bp7, ISerializable
{
	// Token: 0x0600785E RID: 30814 RVA: 0x00327B00 File Offset: 0x00325D00
	private bru(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600785F RID: 30815 RVA: 0x00327B0C File Offset: 0x00325D0C
	public bru()
	{
	}

	// Token: 0x06007860 RID: 30816 RVA: 0x00327B14 File Offset: 0x00325D14
	protected override enp r6()
	{
		return new bru.a();
	}

	// Token: 0x020014F6 RID: 5366
	[eiz("TK10a")]
	[Serializable]
	private new sealed class a : enp, ISerializable
	{
		// Token: 0x06007861 RID: 30817 RVA: 0x00327B1C File Offset: 0x00325D1C
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
		}

		// Token: 0x06007862 RID: 30818 RVA: 0x00327B24 File Offset: 0x00325D24
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x06007863 RID: 30819 RVA: 0x00327B28 File Offset: 0x00325D28
		public a()
		{
		}

		// Token: 0x06007864 RID: 30820 RVA: 0x00327B34 File Offset: 0x00325D34
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
					if (Enumerable.Sum<csk>(Enumerable.Where<csk>(A_3.a, new Func<csk, bool>(bru.a.a.a.b)), new Func<csk, int>(bru.a.a.a.a)) > 0)
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
						int num = ezx.q;
						if (A_0 != null && A_0.aa().Feats.Contains<dt>())
						{
							num = (int)((double)num * (1.0 + global::dt.a(A_0.aa())));
						}
						ab6 a_2 = new ab6((A_0 != null) ? A_0.aa() : null, ezx.t * d0u.b, num);
						A_1.aa().StatusEffects.a(a_2, false, false, false);
					}
				}
			}
		}

		// Token: 0x020014F7 RID: 5367
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x06007867 RID: 30823 RVA: 0x00327CE8 File Offset: 0x00325EE8
			internal bool b(csk A_0)
			{
				return A_0.DamageType == DamageType.Mechanical;
			}

			// Token: 0x06007868 RID: 30824 RVA: 0x00327CF4 File Offset: 0x00325EF4
			internal int a(csk A_0)
			{
				return A_0.Amount;
			}

			// Token: 0x04003055 RID: 12373
			public static readonly bru.a.a a = new bru.a.a();

			// Token: 0x04003056 RID: 12374
			public static Func<csk, bool> b;

			// Token: 0x04003057 RID: 12375
			public static Func<csk, int> c;
		}
	}
}

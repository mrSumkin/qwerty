using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020014F8 RID: 5368
[eiz("TK09")]
[Serializable]
public sealed class e18 : bp7, ISerializable
{
	// Token: 0x06007869 RID: 30825 RVA: 0x00327D00 File Offset: 0x00325F00
	private e18(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600786A RID: 30826 RVA: 0x00327D0C File Offset: 0x00325F0C
	public e18()
	{
	}

	// Token: 0x0600786B RID: 30827 RVA: 0x00327D14 File Offset: 0x00325F14
	protected override enp r6()
	{
		return new e18.a();
	}

	// Token: 0x020014F9 RID: 5369
	[eiz("TK09a")]
	[Serializable]
	private new sealed class a : enp, ISerializable
	{
		// Token: 0x0600786C RID: 30828 RVA: 0x00327D1C File Offset: 0x00325F1C
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
		}

		// Token: 0x0600786D RID: 30829 RVA: 0x00327D24 File Offset: 0x00325F24
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x0600786E RID: 30830 RVA: 0x00327D28 File Offset: 0x00325F28
		public a()
		{
		}

		// Token: 0x0600786F RID: 30831 RVA: 0x00327D34 File Offset: 0x00325F34
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
					if (Enumerable.Sum<csk>(Enumerable.Where<csk>(A_3.a, new Func<csk, bool>(e18.a.a.a.b)), new Func<csk, int>(e18.a.a.a.a)) > 0)
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
						int num = ezx.l;
						if (A_0 != null && A_0.aa().Feats.Contains<dt>())
						{
							num = (int)((double)num * (1.0 + global::dt.a(A_0.aa())));
						}
						vs a_2 = new vs((A_0 != null) ? A_0.aa() : null, ezx.d * d0u.b, num);
						A_1.aa().StatusEffects.a(a_2, false, false, false);
					}
				}
			}
		}

		// Token: 0x020014FA RID: 5370
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x06007872 RID: 30834 RVA: 0x00327EE8 File Offset: 0x003260E8
			internal bool b(csk A_0)
			{
				return A_0.DamageType == DamageType.Mechanical;
			}

			// Token: 0x06007873 RID: 30835 RVA: 0x00327EF4 File Offset: 0x003260F4
			internal int a(csk A_0)
			{
				return A_0.Amount;
			}

			// Token: 0x04003058 RID: 12376
			public static readonly e18.a.a a = new e18.a.a();

			// Token: 0x04003059 RID: 12377
			public static Func<csk, bool> b;

			// Token: 0x0400305A RID: 12378
			public static Func<csk, int> c;
		}
	}
}

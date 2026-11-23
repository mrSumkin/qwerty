using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020014FE RID: 5374
[eiz("RK04")]
[Serializable]
public sealed class eb6 : bp7, ISerializable
{
	// Token: 0x0600787F RID: 30847 RVA: 0x00328100 File Offset: 0x00326300
	private eb6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007880 RID: 30848 RVA: 0x0032810C File Offset: 0x0032630C
	public eb6()
	{
	}

	// Token: 0x06007881 RID: 30849 RVA: 0x00328114 File Offset: 0x00326314
	protected override enp r6()
	{
		return new eb6.a();
	}

	// Token: 0x020014FF RID: 5375
	[eiz("RK04a")]
	[Serializable]
	private new sealed class a : enp, ISerializable
	{
		// Token: 0x06007882 RID: 30850 RVA: 0x0032811C File Offset: 0x0032631C
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
		}

		// Token: 0x06007883 RID: 30851 RVA: 0x00328124 File Offset: 0x00326324
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x06007884 RID: 30852 RVA: 0x00328128 File Offset: 0x00326328
		public a()
		{
		}

		// Token: 0x06007885 RID: 30853 RVA: 0x00328134 File Offset: 0x00326334
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
					if (Enumerable.Sum<csk>(Enumerable.Where<csk>(A_3.a, new Func<csk, bool>(eb6.a.a.a.b)), new Func<csk, int>(eb6.a.a.a.a)) > 0)
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
						dns a_2 = new dns(ezx.g * d0u.b);
						A_1.aa().StatusEffects.a(a_2, false, false, false);
					}
				}
			}
		}

		// Token: 0x02001500 RID: 5376
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x06007888 RID: 30856 RVA: 0x0032829C File Offset: 0x0032649C
			internal bool b(csk A_0)
			{
				return A_0.DamageType == DamageType.Mechanical;
			}

			// Token: 0x06007889 RID: 30857 RVA: 0x003282A8 File Offset: 0x003264A8
			internal int a(csk A_0)
			{
				return A_0.Amount;
			}

			// Token: 0x0400305E RID: 12382
			public static readonly eb6.a.a a = new eb6.a.a();

			// Token: 0x0400305F RID: 12383
			public static Func<csk, bool> b;

			// Token: 0x04003060 RID: 12384
			public static Func<csk, int> c;
		}
	}
}

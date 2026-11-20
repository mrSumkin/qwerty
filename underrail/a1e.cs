using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001504 RID: 5380
[eiz("TK03")]
[Serializable]
public sealed class a1e : bp7, ISerializable
{
	// Token: 0x06007895 RID: 30869 RVA: 0x003284B4 File Offset: 0x003266B4
	private a1e(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007896 RID: 30870 RVA: 0x003284C0 File Offset: 0x003266C0
	public a1e()
	{
	}

	// Token: 0x06007897 RID: 30871 RVA: 0x003284C8 File Offset: 0x003266C8
	protected override enp r6()
	{
		return new a1e.a();
	}

	// Token: 0x02001505 RID: 5381
	[eiz("TK03a")]
	[Serializable]
	private new sealed class a : enp, ISerializable
	{
		// Token: 0x06007898 RID: 30872 RVA: 0x003284D0 File Offset: 0x003266D0
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
		}

		// Token: 0x06007899 RID: 30873 RVA: 0x003284D8 File Offset: 0x003266D8
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x0600789A RID: 30874 RVA: 0x003284DC File Offset: 0x003266DC
		public a()
		{
		}

		// Token: 0x0600789B RID: 30875 RVA: 0x003284E8 File Offset: 0x003266E8
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
					if (Enumerable.Sum<csk>(Enumerable.Where<csk>(A_3.a, new Func<csk, bool>(a1e.a.a.a.b)), new Func<csk, int>(a1e.a.a.a.a)) > 0)
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
						bhe a_2 = new bhe((int)Math.Max(1.0, (double)ezx.c * (1.0 - num)) * d0u.b);
						A_1.aa().StatusEffects.a(a_2, false, false, false);
					}
				}
			}
		}

		// Token: 0x02001506 RID: 5382
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x0600789E RID: 30878 RVA: 0x00328680 File Offset: 0x00326880
			internal bool b(csk A_0)
			{
				return A_0.DamageType == DamageType.Mechanical;
			}

			// Token: 0x0600789F RID: 30879 RVA: 0x0032868C File Offset: 0x0032688C
			internal int a(csk A_0)
			{
				return A_0.Amount;
			}

			// Token: 0x04003064 RID: 12388
			public static readonly a1e.a.a a = new a1e.a.a();

			// Token: 0x04003065 RID: 12389
			public static Func<csk, bool> b;

			// Token: 0x04003066 RID: 12390
			public static Func<csk, int> c;
		}
	}
}

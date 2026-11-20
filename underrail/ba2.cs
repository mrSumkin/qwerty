using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001501 RID: 5377
[eiz("TK04")]
[Serializable]
public sealed class ba2 : bp7, ISerializable
{
	// Token: 0x0600788A RID: 30858 RVA: 0x003282B4 File Offset: 0x003264B4
	private ba2(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600788B RID: 30859 RVA: 0x003282C0 File Offset: 0x003264C0
	public ba2()
	{
	}

	// Token: 0x0600788C RID: 30860 RVA: 0x003282C8 File Offset: 0x003264C8
	protected override enp r6()
	{
		return new ba2.a();
	}

	// Token: 0x02001502 RID: 5378
	[eiz("TK04a")]
	[Serializable]
	private new sealed class a : enp, ISerializable
	{
		// Token: 0x0600788D RID: 30861 RVA: 0x003282D0 File Offset: 0x003264D0
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
		}

		// Token: 0x0600788E RID: 30862 RVA: 0x003282D8 File Offset: 0x003264D8
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x0600788F RID: 30863 RVA: 0x003282DC File Offset: 0x003264DC
		public a()
		{
		}

		// Token: 0x06007890 RID: 30864 RVA: 0x003282E8 File Offset: 0x003264E8
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
					if (Enumerable.Sum<csk>(Enumerable.Where<csk>(A_3.a, new Func<csk, bool>(ba2.a.a.a.b)), new Func<csk, int>(ba2.a.a.a.a)) > 0)
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
						int num = ezx.e;
						if (A_0 != null && A_0.aa().Feats.Contains<dt>())
						{
							num = (int)((double)num * (1.0 + global::dt.a(A_0.aa())));
						}
						ddr a_2 = new ddr((A_0 != null) ? A_0.aa() : null, ezx.d * d0u.b, num);
						A_1.aa().StatusEffects.a(a_2, false, false, false);
					}
				}
			}
		}

		// Token: 0x02001503 RID: 5379
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x06007893 RID: 30867 RVA: 0x0032849C File Offset: 0x0032669C
			internal bool b(csk A_0)
			{
				return A_0.DamageType == DamageType.Mechanical;
			}

			// Token: 0x06007894 RID: 30868 RVA: 0x003284A8 File Offset: 0x003266A8
			internal int a(csk A_0)
			{
				return A_0.Amount;
			}

			// Token: 0x04003061 RID: 12385
			public static readonly ba2.a.a a = new ba2.a.a();

			// Token: 0x04003062 RID: 12386
			public static Func<csk, bool> b;

			// Token: 0x04003063 RID: 12387
			public static Func<csk, int> c;
		}
	}
}

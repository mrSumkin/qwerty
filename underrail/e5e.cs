using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020014FB RID: 5371
[eiz("SK04")]
[Serializable]
public sealed class e5e : bp7, ISerializable
{
	// Token: 0x06007874 RID: 30836 RVA: 0x00327F00 File Offset: 0x00326100
	private e5e(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007875 RID: 30837 RVA: 0x00327F0C File Offset: 0x0032610C
	public e5e()
	{
	}

	// Token: 0x06007876 RID: 30838 RVA: 0x00327F14 File Offset: 0x00326114
	protected override enp r6()
	{
		return new e5e.a();
	}

	// Token: 0x020014FC RID: 5372
	[eiz("SK04a")]
	[Serializable]
	private new sealed class a : enp, ISerializable
	{
		// Token: 0x06007877 RID: 30839 RVA: 0x00327F1C File Offset: 0x0032611C
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
		}

		// Token: 0x06007878 RID: 30840 RVA: 0x00327F24 File Offset: 0x00326124
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x06007879 RID: 30841 RVA: 0x00327F28 File Offset: 0x00326128
		public a()
		{
		}

		// Token: 0x0600787A RID: 30842 RVA: 0x00327F34 File Offset: 0x00326134
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
					if (Enumerable.Sum<csk>(Enumerable.Where<csk>(A_3.a, new Func<csk, bool>(e5e.a.a.a.b)), new Func<csk, int>(e5e.a.a.a.a)) > 0)
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
						int num = ezx.i;
						if (A_0 != null && A_0.aa().Feats.Contains<dt>())
						{
							num = (int)((double)num * (1.0 + global::dt.a(A_0.aa())));
						}
						ehp a_2 = new ehp((A_0 != null) ? A_0.aa() : null, ezx.h * d0u.b, num);
						A_1.aa().StatusEffects.a(a_2, false, false, false);
					}
				}
			}
		}

		// Token: 0x020014FD RID: 5373
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x0600787D RID: 30845 RVA: 0x003280E8 File Offset: 0x003262E8
			internal bool b(csk A_0)
			{
				return A_0.DamageType == DamageType.Mechanical;
			}

			// Token: 0x0600787E RID: 30846 RVA: 0x003280F4 File Offset: 0x003262F4
			internal int a(csk A_0)
			{
				return A_0.Amount;
			}

			// Token: 0x0400305B RID: 12379
			public static readonly e5e.a.a a = new e5e.a.a();

			// Token: 0x0400305C RID: 12380
			public static Func<csk, bool> b;

			// Token: 0x0400305D RID: 12381
			public static Func<csk, int> c;
		}
	}
}

using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001542 RID: 5442
[eiz("CB8")]
[Serializable]
public sealed class e0n : d64, ISerializable
{
	// Token: 0x06007970 RID: 31088 RVA: 0x0032D9E0 File Offset: 0x0032BBE0
	private e0n(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007971 RID: 31089 RVA: 0x0032D9EC File Offset: 0x0032BBEC
	public override CharacterState? q1()
	{
		return new CharacterState?(CharacterState.FinishPsi);
	}

	// Token: 0x06007972 RID: 31090 RVA: 0x0032D9F4 File Offset: 0x0032BBF4
	public e0n()
	{
	}

	// Token: 0x06007973 RID: 31091 RVA: 0x0032D9FC File Offset: 0x0032BBFC
	protected override void bf()
	{
		base.bf();
		cd1 cd = base.c().aa().Offense.u();
		if (cd.TypedDefinition != null && base.b().a8().j == cgy.b && base.b().a8().Area == base.c().a8().Area)
		{
			double num = 2.0 + (double)base.b().aa().StatusEffects.Get<a5e>().Count * 0.3;
			cmn a_ = awq.b(base.c(), base.b(), null);
			cwt cwt = euf.a(base.c().aa(), base.b().aa(), a_, 0.0, null, 1.0, null, true);
			for (int i = 0; i < cwt.f.Count; i++)
			{
				csk csk = cwt.f[i];
				if (csk.DamageType == DamageType.Mechanical)
				{
					cwt.f[i] = new csk(csk.DamageType, (int)Math.Max(1.0, (double)csk.Amount * num));
				}
			}
			cwt.k = "Укус";
			e0n.a a_2 = new e0n.a();
			awq.a(base.c(), base.b(), cwt, cd, a_2);
		}
	}

	// Token: 0x02001543 RID: 5443
	[eiz("CB8A")]
	[Serializable]
	private new sealed class a : enp, ISerializable
	{
		// Token: 0x06007974 RID: 31092 RVA: 0x0032DB80 File Offset: 0x0032BD80
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
		}

		// Token: 0x06007975 RID: 31093 RVA: 0x0032DB88 File Offset: 0x0032BD88
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x06007976 RID: 31094 RVA: 0x0032DB8C File Offset: 0x0032BD8C
		public a()
		{
		}

		// Token: 0x06007977 RID: 31095 RVA: 0x0032DB98 File Offset: 0x0032BD98
		public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
		{
			if (A_1 != null && A_1.a8() != null && A_2.b && A_3.a != null)
			{
				int num = Enumerable.Sum<csk>(Enumerable.Where<csk>(A_3.a, new Func<csk, bool>(e0n.a.a.a.b)), new Func<csk, int>(e0n.a.a.a.a));
				if (num > 0)
				{
					c5x a_ = A_1.a8();
					string a_2 = "Rend";
					int a_3 = 1;
					double maxValue = double.MaxValue;
					bool a_4 = true;
					bool a_5 = true;
					float? a_6 = dz6.b();
					boj.a(a_, a_2, a_3, maxValue, a_4, a_5, null, null, null, a_6, false);
					A_1.a8().c().a(Guid.NewGuid().ToString(), "ConsumingBite", 1f, c9z.a, false, false);
					if (!A_1.aa().c(d8o.e))
					{
						c5x a_7 = A_0.a8();
						string a_8 = "Heal";
						int a_9 = 3;
						double maxValue2 = double.MaxValue;
						bool a_10 = true;
						bool a_11 = true;
						a_6 = dz6.b();
						boj.a(a_7, a_8, a_9, maxValue2, a_10, a_11, null, null, null, a_6, false);
						A_0.aa().Defense.a(num, null, null, true, false, false, null);
					}
				}
			}
		}

		// Token: 0x02001544 RID: 5444
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x0600797A RID: 31098 RVA: 0x0032DD24 File Offset: 0x0032BF24
			internal bool b(csk A_0)
			{
				return A_0.DamageType == DamageType.Mechanical;
			}

			// Token: 0x0600797B RID: 31099 RVA: 0x0032DD30 File Offset: 0x0032BF30
			internal int a(csk A_0)
			{
				return A_0.Amount;
			}

			// Token: 0x040030A7 RID: 12455
			public static readonly e0n.a.a a = new e0n.a.a();

			// Token: 0x040030A8 RID: 12456
			public static Func<csk, bool> b;

			// Token: 0x040030A9 RID: 12457
			public static Func<csk, int> c;
		}
	}
}

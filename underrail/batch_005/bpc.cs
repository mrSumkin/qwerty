using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200152E RID: 5422
[eiz("DAX")]
[Serializable]
public sealed class bpc : d64, ISerializable
{
	// Token: 0x06007928 RID: 31016 RVA: 0x0032BA8C File Offset: 0x00329C8C
	private bpc(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007929 RID: 31017 RVA: 0x0032BA98 File Offset: 0x00329C98
	public override CharacterState? q1()
	{
		return new CharacterState?(CharacterState.Attack2);
	}

	// Token: 0x0600792A RID: 31018 RVA: 0x0032BAA4 File Offset: 0x00329CA4
	public bpc()
	{
	}

	// Token: 0x0600792B RID: 31019 RVA: 0x0032BAAC File Offset: 0x00329CAC
	protected override void bf()
	{
		base.bf();
		cd1 cd = base.c().aa().Offense.u();
		if (cd.TypedDefinition != null && base.c() != null && base.c().a8() != null && base.b() != null && base.b().a8() != null && base.b().a8().j == cgy.b && base.b().a8().Area == base.c().a8().Area)
		{
			cmn cmn = awq.b(base.c(), base.b(), null);
			cmn.b += base.c().aa().Offense.an();
			apj microfeat = base.c().aa().GetMicrofeat<apj>();
			if (microfeat != null && microfeat.a() != 0.0)
			{
				cmn.c += microfeat.a();
			}
			cwt cwt = euf.a(base.c().aa(), base.b().aa(), cmn, 0.0, null, 1.0, null, true);
			double num = bwh.b(base.vg().e());
			for (int i = 0; i < cwt.f.Count; i++)
			{
				csk csk = cwt.f[i];
				if (csk.DamageType == DamageType.Mechanical)
				{
					cwt.f[i] = new csk(csk.DamageType, (int)Math.Max(1.0, (double)csk.Amount * num));
				}
			}
			cwt.k = "Decapitate";
			int num2 = (int)((double)base.b().aa().Defense.q().zo() * bwh.a(base.vg().e())) + 1;
			cwt.ad["DecapitateRequiredDamage"] = num2;
			awq.a(base.c(), base.b(), cwt, cd, new bpc.a(this));
		}
	}

	// Token: 0x0200152F RID: 5423
	[eiz("DAXa")]
	[Serializable]
	private new sealed class a : enp, ISerializable
	{
		// Token: 0x0600792C RID: 31020 RVA: 0x0032BCF0 File Offset: 0x00329EF0
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.a = (A_0.GetValue("DAXa:P", typeof(bpc)) as bpc);
		}

		// Token: 0x0600792D RID: 31021 RVA: 0x0032BD18 File Offset: 0x00329F18
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("DAXa:P", this.a);
		}

		// Token: 0x0600792E RID: 31022 RVA: 0x0032BD2C File Offset: 0x00329F2C
		public a(bpc A_0)
		{
			this.a = A_0;
		}

		// Token: 0x0600792F RID: 31023 RVA: 0x0032BD3C File Offset: 0x00329F3C
		public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
		{
			if (A_2.b && A_1 != null && !A_1.aa().Dead && A_3.a != null)
			{
				int? primitivePropertyValue = A_2.ad.GetPrimitivePropertyValue<int>("DecapitateRequiredDamage", null);
				if (primitivePropertyValue != null)
				{
					if (Enumerable.Sum<csk>(Enumerable.Where<csk>(A_3.a, new Func<csk, bool>(bpc.a.a.a.a)), new Func<csk, int>(bpc.a.a.a.b)) >= primitivePropertyValue.Value)
					{
						if (A_1.aa().b(d8o.e | d8o.m) || A_1.aa().d(CharacterImmunities.Decapitation) || A_1.aa().Passive)
						{
							etm a_ = new etm(new ap9(A_1.aa()), "обезглавливанию");
							bey.a(a_, A_0.aa(), A_1.aa(), A_1);
							a7v.a(a_);
							return;
						}
						bmj.a(A_1.a8(), new cz5("Обезглавлен!", Color.Red, null, false));
						A_1.a8().c().a(Guid.NewGuid().ToString(), "Decapitation", 1f, c9z.a, false, false);
						boj.a(A_1.a8().Area, A_1.a8().Location + new Vector3(0f, 0f, A_1.a8().Size.Z * 0.75f), null, "Обезглавливание", 1, double.MaxValue, null, null, null, null);
						A_1.aa().a(A_2, A_3, false);
					}
				}
			}
		}

		// Token: 0x04003091 RID: 12433
		private bpc a;

		// Token: 0x02001530 RID: 5424
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x06007932 RID: 31026 RVA: 0x0032BF5C File Offset: 0x0032A15C
			internal bool a(csk A_0)
			{
				return A_0.DamageType == DamageType.Mechanical;
			}

			// Token: 0x06007933 RID: 31027 RVA: 0x0032BF68 File Offset: 0x0032A168
			internal int b(csk A_0)
			{
				return A_0.Amount;
			}

			// Token: 0x04003092 RID: 12434
			public static readonly bpc.a.a a = new bpc.a.a();

			// Token: 0x04003093 RID: 12435
			public static Func<csk, bool> b;

			// Token: 0x04003094 RID: 12436
			public static Func<csk, int> c;
		}
	}
}

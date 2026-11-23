using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001526 RID: 5414
[eiz("V666")]
[Serializable]
public sealed class o8 : d64, ISerializable
{
	// Token: 0x0600790B RID: 30987 RVA: 0x0032AE90 File Offset: 0x00329090
	private o8(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600790C RID: 30988 RVA: 0x0032AE9C File Offset: 0x0032909C
	public o8()
	{
	}

	// Token: 0x0600790D RID: 30989 RVA: 0x0032AEA8 File Offset: 0x003290A8
	protected override bool gq()
	{
		if (!base.gq())
		{
			return false;
		}
		awq.a(base.c().aa());
		cd1 cd = base.c().aa().Offense.u();
		if (cd.TypedDefinition != null && base.b().a8().j == cgy.b && base.b().a8().Area == base.c().a8().Area)
		{
			double a_ = aw1.b(base.c().a8(), base.b().a8());
			double a_2 = awq.a(base.vg().e(), base.b(), a_);
			cwt cwt = euf.a(base.c().aa(), base.b().aa(), a_, awq.a(base.c(), base.b(), null, null), 0.0, base.b().a8().l(), base.c().aa().Darkvision, cd.CurrentBullet, awq.f(base.c()), a_2, false, null, null, true, null);
			double a_3;
			if (cwt.e)
			{
				a_3 = 1.0 + base.c().aa().Offense.am();
			}
			else
			{
				a_3 = 1.0;
			}
			int a_4 = eyv.a(base.vg().e().b9() as coh);
			cwt.f.Add(euf.a(e7b.a(base.vg().e().b8(), a_4), a_3));
			awq.a(base.c(), base.b(), cwt, cd, new o8.a(this, a_4), true, null, null, null, false, false, true, null, null);
			return true;
		}
		return false;
	}

	// Token: 0x02001527 RID: 5415
	[eiz("V666a")]
	[Serializable]
	private new sealed class a : enp, ISerializable
	{
		// Token: 0x0600790E RID: 30990 RVA: 0x0032B0A4 File Offset: 0x003292A4
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.a = (A_0.GetValue("V666a:P", typeof(o8)) as o8);
			this.b = A_0.GetInt32("V666a:O");
		}

		// Token: 0x0600790F RID: 30991 RVA: 0x0032B0E0 File Offset: 0x003292E0
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("V666a:P", this.a);
			info.AddValue("V666a:O", this.b);
		}

		// Token: 0x06007910 RID: 30992 RVA: 0x0032B104 File Offset: 0x00329304
		public a(o8 A_0, int A_1)
		{
			this.a = A_0;
			this.b = A_1;
		}

		// Token: 0x06007911 RID: 30993 RVA: 0x0032B11C File Offset: 0x0032931C
		public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
		{
			if (A_1 != null && A_2.b)
			{
				aex.a(A_1.a8().Area, A_1.a8().aj(), 40, 250, 0.9f, 4.25f, true, true);
				if (Enumerable.Sum<csk>(Enumerable.Where<csk>(A_2.f, new Func<csk, bool>(o8.a.a.a.b)), new Func<csk, int>(o8.a.a.a.a)) > 0)
				{
					bq4 bq = new bq4(A_0.aa());
					bq.Stacks = 5;
					A_1.aa().StatusEffects.a(bq, false, false, false);
				}
			}
		}

		// Token: 0x0400308A RID: 12426
		private o8 a;

		// Token: 0x0400308B RID: 12427
		private int b;

		// Token: 0x02001528 RID: 5416
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x06007914 RID: 30996 RVA: 0x0032B200 File Offset: 0x00329400
			internal bool b(csk A_0)
			{
				return A_0.DamageType == DamageType.Energy;
			}

			// Token: 0x06007915 RID: 30997 RVA: 0x0032B20C File Offset: 0x0032940C
			internal int a(csk A_0)
			{
				return A_0.Amount;
			}

			// Token: 0x0400308C RID: 12428
			public static readonly o8.a.a a = new o8.a.a();

			// Token: 0x0400308D RID: 12429
			public static Func<csk, bool> b;

			// Token: 0x0400308E RID: 12430
			public static Func<csk, int> c;
		}
	}
}

using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

// Token: 0x02001595 RID: 5525
[eiz("SA1")]
[Serializable]
public sealed class e83 : d64, ISerializable
{
	// Token: 0x06007AA5 RID: 31397 RVA: 0x0033579C File Offset: 0x0033399C
	private e83(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007AA6 RID: 31398 RVA: 0x003357A8 File Offset: 0x003339A8
	public e83()
	{
	}

	// Token: 0x06007AA7 RID: 31399 RVA: 0x003357B4 File Offset: 0x003339B4
	protected override bool gq()
	{
		if (!base.gq())
		{
			return false;
		}
		cd1 cd = base.c().aa().Offense.u();
		bool flag = cd.TypedDefinition != null;
		float num = cit.a(base.c().aa());
		if (flag && base.b().a8().j == cgy.b && base.b().a8().Area == base.c().a8().Area)
		{
			double a_ = aw1.b(base.c().a8(), base.b().a8());
			double a_2 = awq.a(base.vg().e(), base.b(), a_);
			cmn cmn = awq.a(base.c(), base.b(), null, null);
			cmn.c = -100000.0;
			cmn.b += base.c().aa().Offense.an();
			cwt cwt = euf.a(base.c().aa(), base.b().aa(), a_, cmn, 0.0, base.b().a8().l(), base.c().aa().Darkvision, cd.CurrentBullet, awq.f(base.c()), a_2, false, null, null, true, null);
			for (int i = 0; i < cwt.f.Count; i++)
			{
				csk csk = cwt.f[i];
				cwt.f[i] = new csk(csk.DamageType, (int)Math.Max(1f, (float)csk.Amount * num));
			}
			cwt.k = "Снайперский выстрел";
			bool a_3 = base.b().aa().Defense.q().zo() == base.b().aa().Defense.q().zm();
			awq.a(base.c(), base.b(), cwt, cd, new e83.a(a_3), null);
			return true;
		}
		return false;
	}

	// Token: 0x02001596 RID: 5526
	[eiz("SA1b")]
	[Serializable]
	private new sealed class a : enp, ISerializable
	{
		// Token: 0x06007AA8 RID: 31400 RVA: 0x003359F4 File Offset: 0x00333BF4
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.a = A_0.GetBoolean("SA1b:F");
		}

		// Token: 0x06007AA9 RID: 31401 RVA: 0x00335A10 File Offset: 0x00333C10
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("SA1b:F", this.a);
		}

		// Token: 0x06007AAA RID: 31402 RVA: 0x00335A24 File Offset: 0x00333C24
		public a(bool A_0)
		{
			this.a = A_0;
		}

		// Token: 0x06007AAB RID: 31403 RVA: 0x00335A38 File Offset: 0x00333C38
		public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
		{
			if (this.a && A_2.b && A_1 != null && A_1.aa().Dead && A_3.a != null && A_3.a.Count > 0)
			{
				if (Enumerable.Sum<csk>(A_3.a, new Func<csk, int>(e83.a.a.a.a)) >= (int)A_1.aa().Defense.q().zm())
				{
					cxc.c(eyy.au);
				}
			}
		}

		// Token: 0x04003109 RID: 12553
		private bool a;

		// Token: 0x02001597 RID: 5527
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x06007AAE RID: 31406 RVA: 0x00335AF8 File Offset: 0x00333CF8
			internal int a(csk A_0)
			{
				return A_0.Amount;
			}

			// Token: 0x0400310A RID: 12554
			public static readonly e83.a.a a = new e83.a.a();

			// Token: 0x0400310B RID: 12555
			public static Func<csk, int> b;
		}
	}
}

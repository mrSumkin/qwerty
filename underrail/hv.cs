using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200138F RID: 5007
[eiz("VRPHEA")]
[bs6("HFX:VoidRot")]
[Serializable]
public sealed class hv : cpl, ISerializable
{
	// Token: 0x06007139 RID: 28985 RVA: 0x002F8994 File Offset: 0x002F6B94
	private hv(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600713A RID: 28986 RVA: 0x002F89A0 File Offset: 0x002F6BA0
	public hv()
	{
	}

	// Token: 0x0600713B RID: 28987 RVA: 0x002F89AC File Offset: 0x002F6BAC
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.b() != null && base.b().a8() != null && base.b().a8().j == cgy.b && base.b().a8().Area != null && base.b().a8().Area.Zone != null)
		{
			aex.a(base.b().a8().Area, base.b().a8().aj(), 20, 250, 0.5f, 4.25f, true, true);
		}
		if (base.b() == null || base.agu() == null || base.b() == null || base.b().aa() == null || base.b().aa().Dead)
		{
			return dc4.e;
		}
		if (!base.agw().b || base.agy() == null || base.agy().a == null || base.agw().c.GetValueOrDefault())
		{
			return dc4.c;
		}
		if (Enumerable.Sum<csk>(Enumerable.Where<csk>(base.agy().a, new Func<csk, bool>(hv.a.a.a)), new Func<csk, int>(hv.a.a.b)) > 0)
		{
			bq4 a_ = new bq4(base.a().aa());
			base.b().aa().StatusEffects.a(a_, false, false, false);
		}
		return dc4.c;
	}

	// Token: 0x02001390 RID: 5008
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600713E RID: 28990 RVA: 0x002F8B7C File Offset: 0x002F6D7C
		internal bool a(csk A_0)
		{
			return A_0.DamageType == DamageType.Energy;
		}

		// Token: 0x0600713F RID: 28991 RVA: 0x002F8B88 File Offset: 0x002F6D88
		internal int b(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04002E44 RID: 11844
		public static readonly hv.a a = new hv.a();

		// Token: 0x04002E45 RID: 11845
		public static Func<csk, bool> b;

		// Token: 0x04002E46 RID: 11846
		public static Func<csk, int> c;
	}
}

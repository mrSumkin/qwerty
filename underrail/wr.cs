using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020016DA RID: 5850
[eiz("8SB")]
[Serializable]
public sealed class wr : a6k, ISerializable, enp
{
	// Token: 0x06007F49 RID: 32585 RVA: 0x0035E348 File Offset: 0x0035C548
	private wr(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() >= 624)
		{
			this.a = (A_0.GetValue("8SB:H", typeof(bool?)) as bool?);
			this.b = A_0.GetDouble("8SB:A");
			return;
		}
		this.a = new bool?(true);
	}

	// Token: 0x06007F4A RID: 32586 RVA: 0x0035E3B0 File Offset: 0x0035C5B0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("8SB:H", this.a);
		info.AddValue("8SB:A", this.b);
	}

	// Token: 0x06007F4B RID: 32587 RVA: 0x0035E3E4 File Offset: 0x0035C5E4
	public wr()
	{
	}

	// Token: 0x06007F4C RID: 32588 RVA: 0x0035E3EC File Offset: 0x0035C5EC
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead)
		{
			return dc4.e;
		}
		if (c5x.j == cgy.b && c5x.Area == base.vg().q().Area)
		{
			if (this.b == 0.0)
			{
				this.b = 1.0;
				amc amc = base.vg().q().h.b;
				amc amc2 = c5x.h.b;
				if (amc != null && amc2 != null && !amc2.aa().Dead)
				{
					cmn cmn = awq.b(amc, amc2, null);
					cmn.g += 0.5;
					cwt cwt = euf.a(amc.aa(), amc2.aa(), cmn, -100.0, null, 1.0, null, true);
					cwt.v = "отсос крови присасывание";
					awq.a(amc, amc2, cwt, amc.aa().Offense.u(), this);
					return dc4.b;
				}
			}
			else if (this.a != null)
			{
				if (this.a.Value)
				{
					return dc4.c;
				}
				return dc4.e;
			}
			else if (this.b >= 500.0)
			{
				return dc4.e;
			}
			this.b += A_1.TotalMilliseconds;
			return dc4.b;
		}
		return dc4.e;
	}

	// Token: 0x06007F4D RID: 32589 RVA: 0x0035E590 File Offset: 0x0035C790
	public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
	{
		this.a = new bool?(false);
		if (A_3 != null && A_3.a != null && A_2 != null && A_2.b)
		{
			if (Enumerable.Sum<csk>(Enumerable.Where<csk>(A_3.a, new Func<csk, bool>(wr.a.a.a)), new Func<csk, int>(wr.a.a.b)) > 0)
			{
				this.a = new bool?(true);
			}
		}
	}

	// Token: 0x04003232 RID: 12850
	private new bool? a;

	// Token: 0x04003233 RID: 12851
	private double b;

	// Token: 0x020016DB RID: 5851
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06007F50 RID: 32592 RVA: 0x0035E648 File Offset: 0x0035C848
		internal bool a(csk A_0)
		{
			return A_0.DamageType == DamageType.Mechanical;
		}

		// Token: 0x06007F51 RID: 32593 RVA: 0x0035E654 File Offset: 0x0035C854
		internal int b(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04003234 RID: 12852
		public static readonly wr.a a = new wr.a();

		// Token: 0x04003235 RID: 12853
		public static Func<csk, bool> b;

		// Token: 0x04003236 RID: 12854
		public static Func<csk, int> c;
	}
}

using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02001AF7 RID: 6903
[eiz("PASE")]
[Serializable]
public sealed class csq : els, ISerializable
{
	// Token: 0x06009586 RID: 38278 RVA: 0x003AA810 File Offset: 0x003A8A10
	private csq(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009587 RID: 38279 RVA: 0x003AA81C File Offset: 0x003A8A1C
	public csq(double A_0, int A_1) : base(csq.a, "Псионическое ускорение", ci8.b)
	{
		base.Duration = A_1;
		base.TickPeriod = d0u.b;
		base.Icon = "Status.PsionicAcceleration";
		base.Stacking = axm.b;
		base.Power = (int)(A_0 * 100.0);
		base.StaticEffects.Add(new bxr(A_0));
	}

	// Token: 0x06009588 RID: 38280 RVA: 0x003AA884 File Offset: 0x003A8A84
	public override string cb(ll A_0)
	{
		bxr bxr = Enumerable.FirstOrDefault<d3e>(base.StaticEffects) as bxr;
		if (bxr != null)
		{
			return qv.a("StatusEffects/PsionicAcceleration", new object[]
			{
				(int)(bxr.a() * 100.0)
			});
		}
		return string.Empty;
	}

	// Token: 0x04003994 RID: 14740
	public new static readonly string a = "psionicAcceleration";
}

using System;
using System.Runtime.Serialization;

// Token: 0x02001AED RID: 6893
[eiz("L11")]
[Serializable]
public sealed class b0c : els, ISerializable
{
	// Token: 0x06009558 RID: 38232 RVA: 0x003A9A3C File Offset: 0x003A7C3C
	private b0c(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009559 RID: 38233 RVA: 0x003A9A48 File Offset: 0x003A7C48
	public b0c(int A_0) : base(b0c.a, "Пси-мания", ci8.b)
	{
		base.Duration = A_0;
		base.Icon = "PsionicMania";
		base.StaticEffects.Add(new bi0(null, 1000f));
	}

	// Token: 0x0600955A RID: 38234 RVA: 0x003A9A98 File Offset: 0x003A7C98
	public override string cb(ll A_0)
	{
		return qv.b("StatusEffects/PsionicMania");
	}

	// Token: 0x04003982 RID: 14722
	public new static readonly string a = "psionicMania";
}

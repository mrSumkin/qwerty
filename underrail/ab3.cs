using System;
using System.Runtime.Serialization;

// Token: 0x02001B43 RID: 6979
[eiz("SSE1")]
[Serializable]
public sealed class ab3 : els, ISerializable
{
	// Token: 0x060096EE RID: 38638 RVA: 0x003AF808 File Offset: 0x003ADA08
	private ab3(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060096EF RID: 38639 RVA: 0x003AF814 File Offset: 0x003ADA14
	public override bool oa()
	{
		return false;
	}

	// Token: 0x060096F0 RID: 38640 RVA: 0x003AF818 File Offset: 0x003ADA18
	public ab3(int A_0) : base("stunned", "Оглушение", ci8.c)
	{
		base.Icon = "Status.Stunned";
		base.ExpiredAction = "StunExpiresAction";
		base.RemovedAction = "StunExpiresAction";
		base.VisualEffects.Add(new ud(this, "Stunned"));
		base.Duration = A_0;
		base.StaticEffects.Add(new a1s());
	}

	// Token: 0x060096F1 RID: 38641 RVA: 0x003AF884 File Offset: 0x003ADA84
	public override string cb(ll A_0)
	{
		return qv.b("StatusEffects/Stunned");
	}
}

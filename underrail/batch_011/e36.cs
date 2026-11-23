using System;
using System.Runtime.Serialization;

// Token: 0x02000293 RID: 659
[eiz("AS")]
[Serializable]
public sealed class e36 : ISerializable
{
	// Token: 0x0600134F RID: 4943 RVA: 0x00050C10 File Offset: 0x0004EE10
	private e36(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.b() != 0)
		{
			this.a = (auv)A_0.GetValue("AS:A", typeof(auv));
			this.b = (atp)A_0.GetValue("AS:ET", typeof(atp));
			this.c = A_0.GetBoolean("AS:C");
			return;
		}
		if (base.GetType() == typeof(e36))
		{
			this.a = (auv)A_0.GetValue("Action", typeof(auv));
			this.b = (atp)A_0.GetValue("ExecutionType", typeof(atp));
			this.c = A_0.GetBoolean("Cancelled");
			return;
		}
		this.a = (auv)A_0.GetValue("ActionSetup+Action", typeof(auv));
		this.b = (atp)A_0.GetValue("ActionSetup+ExecutionType", typeof(atp));
		this.c = A_0.GetBoolean("ActionSetup+Cancelled");
	}

	// Token: 0x06001350 RID: 4944 RVA: 0x00050D3C File Offset: 0x0004EF3C
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("AS:A", this.a);
		info.AddValue("AS:ET", this.b);
		info.AddValue("AS:C", this.c);
	}

	// Token: 0x06001351 RID: 4945 RVA: 0x00050D78 File Offset: 0x0004EF78
	public e36(auv A_0, atp A_1)
	{
		czh.a(A_0, "action");
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x04000A86 RID: 2694
	public auv a;

	// Token: 0x04000A87 RID: 2695
	public atp b;

	// Token: 0x04000A88 RID: 2696
	public bool c;
}

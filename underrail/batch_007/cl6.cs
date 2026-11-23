using System;
using System.Runtime.Serialization;

// Token: 0x02000509 RID: 1289
[eiz("CE3")]
[Serializable]
public abstract class cl6 : bjs, b2h, ISerializable
{
	// Token: 0x06002147 RID: 8519 RVA: 0x000B1EB8 File Offset: 0x000B00B8
	protected cl6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("CE3:CN");
			this.b = (ci8)A_0.GetValue("CE3:CN1", typeof(ci8));
			return;
		}
		if (base.GetType() == typeof(cl6))
		{
			this.a = A_0.GetString("_CapabilityName");
			this.b = (ci8)A_0.GetValue("_CapabilityNature", typeof(ci8));
			return;
		}
		this.a = A_0.GetString("CapabilityEvent+_CapabilityName");
		this.b = (ci8)A_0.GetValue("CapabilityEvent+_CapabilityNature", typeof(ci8));
	}

	// Token: 0x06002148 RID: 8520 RVA: 0x000B1F88 File Offset: 0x000B0188
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CE3:CN", this.a);
		info.AddValue("CE3:CN1", this.b);
	}

	// Token: 0x06002149 RID: 8521 RVA: 0x000B1FBC File Offset: 0x000B01BC
	public string d()
	{
		return this.a;
	}

	// Token: 0x0600214A RID: 8522 RVA: 0x000B1FC4 File Offset: 0x000B01C4
	public ci8 c()
	{
		return this.b;
	}

	// Token: 0x0600214B RID: 8523 RVA: 0x000B1FCC File Offset: 0x000B01CC
	protected cl6(ap9 A_0, string A_1, ci8 A_2) : base(null, A_0)
	{
		this.a = A_1;
		this.b = A_2;
	}

	// Token: 0x0600214C RID: 8524
	public abstract ecs se();

	// Token: 0x04001448 RID: 5192
	private new string a;

	// Token: 0x04001449 RID: 5193
	private new ci8 b;
}

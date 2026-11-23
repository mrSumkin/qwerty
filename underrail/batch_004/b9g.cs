using System;
using System.Runtime.Serialization;

// Token: 0x0200053B RID: 1339
[eiz("BE")]
[Serializable]
public abstract class b9g : aeq, ISerializable
{
	// Token: 0x06002244 RID: 8772 RVA: 0x000B5640 File Offset: 0x000B3840
	protected b9g(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("BE:BN");
			this.b = (cr1)A_0.GetValue("BE:BQ", typeof(cr1));
			return;
		}
		if (base.GetType() == typeof(b9g))
		{
			this.a = A_0.GetString("_BlueprintName");
			this.b = (cr1)A_0.GetValue("_BlueprintQuality", typeof(cr1));
			return;
		}
		this.a = A_0.GetString("BlueprintEvent+_BlueprintName");
		this.b = (cr1)A_0.GetValue("BlueprintEvent+_BlueprintQuality", typeof(cr1));
	}

	// Token: 0x06002245 RID: 8773 RVA: 0x000B5710 File Offset: 0x000B3910
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("BE:BN", this.a);
		info.AddValue("BE:BQ", this.b);
	}

	// Token: 0x06002246 RID: 8774 RVA: 0x000B5744 File Offset: 0x000B3944
	public string d()
	{
		return this.a;
	}

	// Token: 0x06002247 RID: 8775 RVA: 0x000B574C File Offset: 0x000B394C
	public cr1 c()
	{
		return this.b;
	}

	// Token: 0x06002248 RID: 8776 RVA: 0x000B5754 File Offset: 0x000B3954
	protected b9g(ap9 A_0, string A_1, cr1 A_2) : base(A_0)
	{
		this.a = A_1;
		this.b = A_2;
	}

	// Token: 0x04001472 RID: 5234
	private string a;

	// Token: 0x04001473 RID: 5235
	private cr1 b;
}

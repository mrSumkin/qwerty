using System;
using System.Runtime.Serialization;

// Token: 0x020004D5 RID: 1237
[eiz("PIIAWPC")]
[Serializable]
public sealed class e2q : dnh, ISerializable
{
	// Token: 0x06001FC0 RID: 8128 RVA: 0x000AE1FC File Offset: 0x000AC3FC
	private e2q(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("PIIAWPC:P");
		this.b = A_0.GetBoolean("PIIAWPC:I");
	}

	// Token: 0x06001FC1 RID: 8129 RVA: 0x000AE228 File Offset: 0x000AC428
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PIIAWPC:P", this.a);
		info.AddValue("PIIAWPC:I", this.b);
	}

	// Token: 0x06001FC2 RID: 8130 RVA: 0x000AE254 File Offset: 0x000AC454
	public string a()
	{
		return this.a;
	}

	// Token: 0x06001FC3 RID: 8131 RVA: 0x000AE25C File Offset: 0x000AC45C
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06001FC4 RID: 8132 RVA: 0x000AE268 File Offset: 0x000AC468
	public bool b()
	{
		return this.b;
	}

	// Token: 0x06001FC5 RID: 8133 RVA: 0x000AE270 File Offset: 0x000AC470
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06001FC6 RID: 8134 RVA: 0x000AE27C File Offset: 0x000AC47C
	public e2q()
	{
	}

	// Token: 0x06001FC7 RID: 8135 RVA: 0x000AE288 File Offset: 0x000AC488
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		bool flag = false;
		if (!string.IsNullOrEmpty(this.a))
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null && serviceOrThrow.aqu().v().b().Zone != null)
			{
				flag = serviceOrThrow.aqu().v().b().Zone.y8().StartsWith(this.a, StringComparison.OrdinalIgnoreCase);
			}
		}
		return flag ^ this.b;
	}

	// Token: 0x040013E3 RID: 5091
	private string a;

	// Token: 0x040013E4 RID: 5092
	private bool b;
}

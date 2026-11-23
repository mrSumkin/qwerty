using System;
using System.Runtime.Serialization;

// Token: 0x020004E6 RID: 1254
[eiz("PIIAC")]
[Serializable]
public sealed class cu : dnh, ISerializable
{
	// Token: 0x06002059 RID: 8281 RVA: 0x000AFA8C File Offset: 0x000ADC8C
	private cu(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("PIIAC:AN");
			this.b = A_0.GetBoolean("PIIAC:I");
			return;
		}
		if (base.GetType() == typeof(cu))
		{
			this.a = A_0.GetString("_AreaName");
			this.b = A_0.GetBoolean("_Inverse");
			return;
		}
		this.a = A_0.GetString("PlayerIsInAreaCondition+_AreaName");
		this.b = A_0.GetBoolean("PlayerIsInAreaCondition+_Inverse");
	}

	// Token: 0x0600205A RID: 8282 RVA: 0x000AFB30 File Offset: 0x000ADD30
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PIIAC:AN", this.a);
		info.AddValue("PIIAC:I", this.b);
	}

	// Token: 0x0600205B RID: 8283 RVA: 0x000AFB5C File Offset: 0x000ADD5C
	public string a()
	{
		return this.a;
	}

	// Token: 0x0600205C RID: 8284 RVA: 0x000AFB64 File Offset: 0x000ADD64
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600205D RID: 8285 RVA: 0x000AFB70 File Offset: 0x000ADD70
	public bool b()
	{
		return this.b;
	}

	// Token: 0x0600205E RID: 8286 RVA: 0x000AFB78 File Offset: 0x000ADD78
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600205F RID: 8287 RVA: 0x000AFB84 File Offset: 0x000ADD84
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		bool flag = false;
		if (!string.IsNullOrEmpty(this.a))
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null && serviceOrThrow.aqu().v().b().Area != null)
			{
				flag = this.a.Equals(serviceOrThrow.aqu().v().b().Area.y8(), StringComparison.OrdinalIgnoreCase);
			}
		}
		return flag ^ this.b;
	}

	// Token: 0x06002060 RID: 8288 RVA: 0x000AFC24 File Offset: 0x000ADE24
	public cu()
	{
	}

	// Token: 0x04001410 RID: 5136
	private string a;

	// Token: 0x04001411 RID: 5137
	private bool b;
}

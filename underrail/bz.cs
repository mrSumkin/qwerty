using System;
using System.Runtime.Serialization;

// Token: 0x02000FC4 RID: 4036
[eiz("CURLOCC")]
[Serializable]
public sealed class bz : dnh, ISerializable
{
	// Token: 0x060052E6 RID: 21222 RVA: 0x0024F290 File Offset: 0x0024D490
	private bz(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() >= 454)
		{
			this.a = A_0.GetString("CURLOCC:LN");
			this.b = A_0.GetBoolean("CURLOCC:I");
		}
	}

	// Token: 0x060052E7 RID: 21223 RVA: 0x0024F2CC File Offset: 0x0024D4CC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CURLOCC:LN", this.a);
		info.AddValue("CURLOCC:I", this.b);
	}

	// Token: 0x060052E8 RID: 21224 RVA: 0x0024F2F8 File Offset: 0x0024D4F8
	public string a()
	{
		return this.a;
	}

	// Token: 0x060052E9 RID: 21225 RVA: 0x0024F300 File Offset: 0x0024D500
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060052EA RID: 21226 RVA: 0x0024F30C File Offset: 0x0024D50C
	public bool b()
	{
		return this.b;
	}

	// Token: 0x060052EB RID: 21227 RVA: 0x0024F314 File Offset: 0x0024D514
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060052EC RID: 21228 RVA: 0x0024F320 File Offset: 0x0024D520
	public bz()
	{
	}

	// Token: 0x060052ED RID: 21229 RVA: 0x0024F32C File Offset: 0x0024D52C
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		bool flag = false;
		if (!string.IsNullOrEmpty(this.a))
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().c() != null && !string.IsNullOrEmpty(serviceOrThrow.aqu().c().b()) && string.Equals(serviceOrThrow.aqu().c().b(), this.a, StringComparison.OrdinalIgnoreCase))
			{
				flag = true;
			}
		}
		return flag ^ this.b;
	}

	// Token: 0x040021EB RID: 8683
	private string a;

	// Token: 0x040021EC RID: 8684
	private bool b;
}

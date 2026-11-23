using System;
using System.Runtime.Serialization;

// Token: 0x02000FD3 RID: 4051
[eiz("ZHH")]
[Serializable]
public sealed class bm7 : dnh
{
	// Token: 0x06005352 RID: 21330 RVA: 0x00250224 File Offset: 0x0024E424
	private bm7(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("ZHH:I");
	}

	// Token: 0x06005353 RID: 21331 RVA: 0x00250240 File Offset: 0x0024E440
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("ZHH:I", this.a);
	}

	// Token: 0x06005354 RID: 21332 RVA: 0x0025025C File Offset: 0x0024E45C
	public bool a()
	{
		return this.a;
	}

	// Token: 0x06005355 RID: 21333 RVA: 0x00250264 File Offset: 0x0024E464
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005356 RID: 21334 RVA: 0x00250270 File Offset: 0x0024E470
	public bm7()
	{
	}

	// Token: 0x06005357 RID: 21335 RVA: 0x0025027C File Offset: 0x0024E47C
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		cnk service = bpo.GetService<cnk>();
		d02 service2 = bpo.GetService<d02>();
		if (service != null && service.aqu() != null && service2 != null)
		{
			bool flag = false;
			foreach (d4n d4n in service2.ahl())
			{
				if (d4n.b != null && d4n.b.aa().a(service.aqu().ac(), asp.a) == global::h.a)
				{
					flag = true;
					break;
				}
			}
			return flag ^ this.a;
		}
		return false;
	}

	// Token: 0x04002205 RID: 8709
	private bool a;
}

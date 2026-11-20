using System;
using System.Runtime.Serialization;

// Token: 0x02000FD2 RID: 4050
[eiz("ZHHNPCS")]
[Serializable]
public sealed class rm : dnh
{
	// Token: 0x0600534C RID: 21324 RVA: 0x0025011C File Offset: 0x0024E31C
	private rm(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("ZHHNPCS:I");
	}

	// Token: 0x0600534D RID: 21325 RVA: 0x00250138 File Offset: 0x0024E338
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("ZHHNPCS:I", this.a);
	}

	// Token: 0x0600534E RID: 21326 RVA: 0x00250154 File Offset: 0x0024E354
	public bool a()
	{
		return this.a;
	}

	// Token: 0x0600534F RID: 21327 RVA: 0x0025015C File Offset: 0x0024E35C
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005350 RID: 21328 RVA: 0x00250168 File Offset: 0x0024E368
	public rm()
	{
	}

	// Token: 0x06005351 RID: 21329 RVA: 0x00250174 File Offset: 0x0024E374
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		cnk service = bpo.GetService<cnk>();
		d02 service2 = bpo.GetService<d02>();
		if (service != null && service.aqu() != null && service2 != null)
		{
			bool flag = false;
			foreach (d4n d4n in service2.ahl())
			{
				if (d4n.b != null && d4n.b.aa().Attributes == d8o.b)
				{
					flag = true;
					break;
				}
			}
			return flag ^ this.a;
		}
		return false;
	}

	// Token: 0x04002204 RID: 8708
	private bool a;
}

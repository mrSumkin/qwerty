using System;
using System.Runtime.Serialization;

// Token: 0x02000FBD RID: 4029
[eiz("CIIAC")]
[Serializable]
public sealed class dhm : dnh, ISerializable
{
	// Token: 0x06005295 RID: 21141 RVA: 0x0024E234 File Offset: 0x0024C434
	private dhm(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("CIIAC:I");
		this.b = A_0.GetBoolean("CIIAC:N");
	}

	// Token: 0x06005296 RID: 21142 RVA: 0x0024E260 File Offset: 0x0024C460
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CIIAC:I", this.a);
		info.AddValue("CIIAC:N", this.b);
	}

	// Token: 0x06005297 RID: 21143 RVA: 0x0024E28C File Offset: 0x0024C48C
	public string a()
	{
		return this.a;
	}

	// Token: 0x06005298 RID: 21144 RVA: 0x0024E294 File Offset: 0x0024C494
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005299 RID: 21145 RVA: 0x0024E2A0 File Offset: 0x0024C4A0
	public bool b()
	{
		return this.b;
	}

	// Token: 0x0600529A RID: 21146 RVA: 0x0024E2A8 File Offset: 0x0024C4A8
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600529B RID: 21147 RVA: 0x0024E2B4 File Offset: 0x0024C4B4
	public dhm()
	{
	}

	// Token: 0x0600529C RID: 21148 RVA: 0x0024E2C0 File Offset: 0x0024C4C0
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		bool flag = false;
		if (!string.IsNullOrEmpty(this.a))
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			d02 service = bpo.GetService<d02>();
			if (service != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null && serviceOrThrow.aqu().v().b().Area != null)
			{
				foreach (d4n d4n in service.ahl())
				{
					if (string.Equals(d4n.b.aa().Id, this.a, StringComparison.OrdinalIgnoreCase) && d4n.b.a8().Area == serviceOrThrow.aqu().v().b().Area)
					{
						flag = true;
						break;
					}
				}
			}
		}
		return flag ^ this.b;
	}

	// Token: 0x040021D1 RID: 8657
	private string a;

	// Token: 0x040021D2 RID: 8658
	private bool b;
}

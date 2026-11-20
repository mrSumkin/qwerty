using System;
using System.Runtime.Serialization;

// Token: 0x02000FD1 RID: 4049
[eiz("TBCA")]
[Serializable]
public sealed class b3b : dnh
{
	// Token: 0x06005346 RID: 21318 RVA: 0x002500A0 File Offset: 0x0024E2A0
	private b3b(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("TBCA:I");
	}

	// Token: 0x06005347 RID: 21319 RVA: 0x002500BC File Offset: 0x0024E2BC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("TBCA:I", this.a);
	}

	// Token: 0x06005348 RID: 21320 RVA: 0x002500D8 File Offset: 0x0024E2D8
	public bool a()
	{
		return this.a;
	}

	// Token: 0x06005349 RID: 21321 RVA: 0x002500E0 File Offset: 0x0024E2E0
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600534A RID: 21322 RVA: 0x002500EC File Offset: 0x0024E2EC
	public b3b()
	{
	}

	// Token: 0x0600534B RID: 21323 RVA: 0x002500F4 File Offset: 0x0024E2F4
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		d02 service = bpo.GetService<d02>();
		return service != null && (service.ahg() ^ this.a);
	}

	// Token: 0x04002203 RID: 8707
	private bool a;
}

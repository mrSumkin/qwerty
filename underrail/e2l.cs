using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010F9 RID: 4345
[eiz("Q0")]
[Serializable]
public sealed class e2l : cze
{
	// Token: 0x06005C17 RID: 23575 RVA: 0x0027728C File Offset: 0x0027548C
	private e2l(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("Q0:L");
		this.b = A_0.GetInt32("Q0:R");
		this.c = (A_0.GetValue("Q0:P", typeof(bdw)) as bdw);
	}

	// Token: 0x06005C18 RID: 23576 RVA: 0x002772EC File Offset: 0x002754EC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("Q0:L", this.a);
		info.AddValue("Q0:R", this.b);
		info.AddValue("Q0:P", this.c);
	}

	// Token: 0x06005C19 RID: 23577 RVA: 0x00277334 File Offset: 0x00275534
	public string a()
	{
		return this.a;
	}

	// Token: 0x06005C1A RID: 23578 RVA: 0x0027733C File Offset: 0x0027553C
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005C1B RID: 23579 RVA: 0x00277348 File Offset: 0x00275548
	public int b()
	{
		return this.b;
	}

	// Token: 0x06005C1C RID: 23580 RVA: 0x00277350 File Offset: 0x00275550
	public void a(int A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005C1D RID: 23581 RVA: 0x0027735C File Offset: 0x0027555C
	public bdw c()
	{
		return this.c;
	}

	// Token: 0x06005C1E RID: 23582 RVA: 0x00277364 File Offset: 0x00275564
	public void a(bdw A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005C1F RID: 23583 RVA: 0x00277370 File Offset: 0x00275570
	public e2l()
	{
	}

	// Token: 0x06005C20 RID: 23584 RVA: 0x00277384 File Offset: 0x00275584
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (!string.IsNullOrEmpty(this.a) && this.c != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				serviceOrThrow.aqu().a(new bw0(this.a, this.c, this.b));
			}
		}
	}

	// Token: 0x040024C7 RID: 9415
	private new string a;

	// Token: 0x040024C8 RID: 9416
	private int b = 1;

	// Token: 0x040024C9 RID: 9417
	private bdw c;
}

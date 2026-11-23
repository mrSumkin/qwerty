using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001091 RID: 4241
[eiz("Q1")]
[Serializable]
public sealed class ce2 : cze
{
	// Token: 0x06005899 RID: 22681 RVA: 0x00266440 File Offset: 0x00264640
	private ce2(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("Q1:L");
		this.b = A_0.GetInt32("Q1:R");
		this.c = (A_0.GetValue("Q1:P", typeof(bdw)) as bdw);
	}

	// Token: 0x0600589A RID: 22682 RVA: 0x002664A0 File Offset: 0x002646A0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("Q1:L", this.a);
		info.AddValue("Q1:R", this.b);
		info.AddValue("Q1:P", this.c);
	}

	// Token: 0x0600589B RID: 22683 RVA: 0x002664E8 File Offset: 0x002646E8
	public string a()
	{
		return this.a;
	}

	// Token: 0x0600589C RID: 22684 RVA: 0x002664F0 File Offset: 0x002646F0
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600589D RID: 22685 RVA: 0x002664FC File Offset: 0x002646FC
	public int b()
	{
		return this.b;
	}

	// Token: 0x0600589E RID: 22686 RVA: 0x00266504 File Offset: 0x00264704
	public void a(int A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600589F RID: 22687 RVA: 0x00266510 File Offset: 0x00264710
	public bdw c()
	{
		return this.c;
	}

	// Token: 0x060058A0 RID: 22688 RVA: 0x00266518 File Offset: 0x00264718
	public void a(bdw A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060058A1 RID: 22689 RVA: 0x00266524 File Offset: 0x00264724
	public ce2()
	{
	}

	// Token: 0x060058A2 RID: 22690 RVA: 0x00266538 File Offset: 0x00264738
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (!string.IsNullOrEmpty(this.a) && this.c != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				serviceOrThrow.aqu().b(new bw0(this.a, this.c, this.b));
			}
		}
	}

	// Token: 0x040023B0 RID: 9136
	private new string a;

	// Token: 0x040023B1 RID: 9137
	private int b = 1;

	// Token: 0x040023B2 RID: 9138
	private bdw c;
}

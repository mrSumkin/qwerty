using System;
using System.Runtime.Serialization;

// Token: 0x0200111B RID: 4379
[eiz("SLSJ")]
[Serializable]
public sealed class b18 : dty
{
	// Token: 0x06005D58 RID: 23896 RVA: 0x0027B430 File Offset: 0x00279630
	private b18(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("PLSJ:SWFP");
	}

	// Token: 0x06005D59 RID: 23897 RVA: 0x0027B44C File Offset: 0x0027964C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PLSJ:SWFP", this.a);
	}

	// Token: 0x06005D5A RID: 23898 RVA: 0x0027B468 File Offset: 0x00279668
	public bool a()
	{
		return this.a;
	}

	// Token: 0x06005D5B RID: 23899 RVA: 0x0027B470 File Offset: 0x00279670
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005D5C RID: 23900 RVA: 0x0027B47C File Offset: 0x0027967C
	public b18()
	{
	}

	// Token: 0x06005D5D RID: 23901 RVA: 0x0027B484 File Offset: 0x00279684
	protected override void xp(c5x A_0)
	{
		if (!string.IsNullOrEmpty(base.m()))
		{
			A_0.v.b.a(base.m(), this.a);
		}
	}

	// Token: 0x04002532 RID: 9522
	private new bool a;
}

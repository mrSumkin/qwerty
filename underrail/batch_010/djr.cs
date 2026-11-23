using System;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;

// Token: 0x0200113D RID: 4413
[eiz("JMPMA")]
[Serializable]
public sealed class djr : Aspect<c5x>, ISerializable
{
	// Token: 0x06005E67 RID: 24167 RVA: 0x0028082C File Offset: 0x0027EA2C
	private djr(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("JMPMA:A");
		this.b = (Guid)A_0.GetValue("JMPMA:I", typeof(Guid));
		this.c = A_0.GetBoolean("JMPMA:M");
	}

	// Token: 0x06005E68 RID: 24168 RVA: 0x00280884 File Offset: 0x0027EA84
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("JMPMA:A", this.a);
		info.AddValue("JMPMA:I", this.b);
		info.AddValue("JMPMA:M", this.c);
	}

	// Token: 0x06005E69 RID: 24169 RVA: 0x002808D4 File Offset: 0x0027EAD4
	public string b()
	{
		return this.a;
	}

	// Token: 0x06005E6A RID: 24170 RVA: 0x002808DC File Offset: 0x0027EADC
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005E6B RID: 24171 RVA: 0x002808E8 File Offset: 0x0027EAE8
	public Guid d()
	{
		return this.b;
	}

	// Token: 0x06005E6C RID: 24172 RVA: 0x002808F0 File Offset: 0x0027EAF0
	public void a(Guid A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005E6D RID: 24173 RVA: 0x002808FC File Offset: 0x0027EAFC
	public bool a()
	{
		return this.c;
	}

	// Token: 0x06005E6E RID: 24174 RVA: 0x00280904 File Offset: 0x0027EB04
	public void a(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005E6F RID: 24175 RVA: 0x00280910 File Offset: 0x0027EB10
	public djr(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x04002583 RID: 9603
	private string a;

	// Token: 0x04002584 RID: 9604
	private Guid b;

	// Token: 0x04002585 RID: 9605
	private bool c;
}

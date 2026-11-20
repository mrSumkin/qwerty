using System;
using System.Runtime.Serialization;

// Token: 0x0200120B RID: 4619
[eiz("HH1")]
[Serializable]
public sealed class aqn : uo, ISerializable
{
	// Token: 0x06006336 RID: 25398 RVA: 0x002ADB8C File Offset: 0x002ABD8C
	private aqn(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06006337 RID: 25399 RVA: 0x002ADB98 File Offset: 0x002ABD98
	protected override string rm()
	{
		return "HeMineActivate";
	}

	// Token: 0x06006338 RID: 25400 RVA: 0x002ADBA0 File Offset: 0x002ABDA0
	protected override string rn()
	{
		return "фугасная мина";
	}

	// Token: 0x06006339 RID: 25401 RVA: 0x002ADBA8 File Offset: 0x002ABDA8
	protected override string ro()
	{
		return bby.g();
	}

	// Token: 0x0600633A RID: 25402 RVA: 0x002ADBB0 File Offset: 0x002ABDB0
	protected override b6a rp()
	{
		return new e3n();
	}

	// Token: 0x0600633B RID: 25403 RVA: 0x002ADBB8 File Offset: 0x002ABDB8
	protected override blv rq()
	{
		return bby.i();
	}

	// Token: 0x0600633C RID: 25404 RVA: 0x002ADBC0 File Offset: 0x002ABDC0
	protected override double rr()
	{
		return (double)bby.h();
	}

	// Token: 0x0600633D RID: 25405 RVA: 0x002ADBC8 File Offset: 0x002ABDC8
	protected override float rs()
	{
		return aju.a2;
	}

	// Token: 0x0600633E RID: 25406 RVA: 0x002ADBD0 File Offset: 0x002ABDD0
	public aqn(c5x A_0, coh A_1) : base(A_0, A_1)
	{
	}
}

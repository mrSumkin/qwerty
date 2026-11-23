using System;
using System.Runtime.Serialization;

// Token: 0x0200120A RID: 4618
[eiz("EE1")]
[Serializable]
public sealed class djt : uo, ISerializable
{
	// Token: 0x0600632C RID: 25388 RVA: 0x002ADB34 File Offset: 0x002ABD34
	private djt(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600632D RID: 25389 RVA: 0x002ADB40 File Offset: 0x002ABD40
	protected override string rm()
	{
		return "EmpMineActivate";
	}

	// Token: 0x0600632E RID: 25390 RVA: 0x002ADB48 File Offset: 0x002ABD48
	protected override string rn()
	{
		return "ЭМИ-мина";
	}

	// Token: 0x0600632F RID: 25391 RVA: 0x002ADB50 File Offset: 0x002ABD50
	protected override string ro()
	{
		return bby.a();
	}

	// Token: 0x06006330 RID: 25392 RVA: 0x002ADB58 File Offset: 0x002ABD58
	protected override string aj6()
	{
		return "EmpBlast";
	}

	// Token: 0x06006331 RID: 25393 RVA: 0x002ADB60 File Offset: 0x002ABD60
	protected override float rs()
	{
		return aju.bd;
	}

	// Token: 0x06006332 RID: 25394 RVA: 0x002ADB68 File Offset: 0x002ABD68
	protected override b6a rp()
	{
		return new dug();
	}

	// Token: 0x06006333 RID: 25395 RVA: 0x002ADB70 File Offset: 0x002ABD70
	protected override blv rq()
	{
		return bby.c();
	}

	// Token: 0x06006334 RID: 25396 RVA: 0x002ADB78 File Offset: 0x002ABD78
	protected override double rr()
	{
		return (double)bby.b();
	}

	// Token: 0x06006335 RID: 25397 RVA: 0x002ADB80 File Offset: 0x002ABD80
	public djt(c5x A_0, coh A_1) : base(A_0, A_1)
	{
	}
}

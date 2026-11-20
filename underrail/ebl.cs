using System;
using System.Runtime.Serialization;

// Token: 0x02001931 RID: 6449
[eiz("LESI")]
[Serializable]
public sealed class ebl : dfg, ISerializable
{
	// Token: 0x060088DC RID: 35036 RVA: 0x003888C8 File Offset: 0x00386AC8
	private ebl(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060088DD RID: 35037 RVA: 0x003888D4 File Offset: 0x00386AD4
	public override string tv()
	{
		return "Запись в журнал";
	}

	// Token: 0x060088DE RID: 35038 RVA: 0x003888DC File Offset: 0x00386ADC
	public override string pu()
	{
		return "Log:";
	}

	// Token: 0x060088DF RID: 35039 RVA: 0x003888E4 File Offset: 0x00386AE4
	public ebl()
	{
		this.a();
	}

	// Token: 0x060088E0 RID: 35040 RVA: 0x003888F4 File Offset: 0x00386AF4
	public ebl(cqh A_0) : base(A_0)
	{
		this.a();
	}

	// Token: 0x060088E1 RID: 35041 RVA: 0x00388908 File Offset: 0x00386B08
	public override bk3 tw()
	{
		ebl ebl = new ebl();
		this.ai7(ebl);
		return ebl;
	}

	// Token: 0x060088E2 RID: 35042 RVA: 0x00388924 File Offset: 0x00386B24
	private new void a()
	{
	}
}

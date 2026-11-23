using System;
using System.Runtime.Serialization;

// Token: 0x020019EC RID: 6636
[eiz("RGE0")]
[Serializable]
public sealed class awd : d3e, ISerializable
{
	// Token: 0x06008ECE RID: 36558 RVA: 0x003966B8 File Offset: 0x003948B8
	private awd(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008ECF RID: 36559 RVA: 0x003966C4 File Offset: 0x003948C4
	protected override void @in(ll A_0)
	{
		A_0.a().SpecialStates.l = true;
	}

	// Token: 0x06008ED0 RID: 36560 RVA: 0x003966D8 File Offset: 0x003948D8
	public awd()
	{
		base.Priority = int.MaxValue;
	}

	// Token: 0x06008ED1 RID: 36561 RVA: 0x003966F0 File Offset: 0x003948F0
	public override d3e b3()
	{
		awd awd = new awd();
		this.xx(awd);
		return awd;
	}
}

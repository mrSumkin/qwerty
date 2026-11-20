using System;
using System.Runtime.Serialization;

// Token: 0x02001942 RID: 6466
[elw(typeof(a12))]
[eiz("BI")]
[Serializable]
public sealed class c5s : eya, ISerializable
{
	// Token: 0x0600893C RID: 35132 RVA: 0x003896D8 File Offset: 0x003878D8
	private c5s(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600893D RID: 35133 RVA: 0x003896E4 File Offset: 0x003878E4
	public override string tv()
	{
		return "Ботинки";
	}

	// Token: 0x0600893E RID: 35134 RVA: 0x003896EC File Offset: 0x003878EC
	public c5s()
	{
	}

	// Token: 0x0600893F RID: 35135 RVA: 0x003896F8 File Offset: 0x003878F8
	public override bk3 tw()
	{
		c5s c5s = new c5s();
		this.ai7(c5s);
		return c5s;
	}
}

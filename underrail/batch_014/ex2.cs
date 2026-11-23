using System;
using System.Runtime.Serialization;

// Token: 0x020019B0 RID: 6576
[eiz("CRRME")]
[Serializable]
public sealed class ex2 : cdh, ISerializable
{
	// Token: 0x06008C8D RID: 35981 RVA: 0x003915D4 File Offset: 0x0038F7D4
	private ex2(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008C8E RID: 35982 RVA: 0x003915E0 File Offset: 0x0038F7E0
	public ex2()
	{
	}

	// Token: 0x06008C8F RID: 35983 RVA: 0x003915E8 File Offset: 0x0038F7E8
	public override string b2()
	{
		return "Это оружие может выполнять атаку Головорез ограничений, но нанося лишь половину урона от кровотечения.";
	}

	// Token: 0x06008C90 RID: 35984 RVA: 0x003915F4 File Offset: 0x0038F7F4
	public override d3e b3()
	{
		ex2 ex = new ex2();
		this.xx(ex);
		return ex;
	}
}

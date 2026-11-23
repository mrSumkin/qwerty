using System;
using System.Runtime.Serialization;

// Token: 0x020019B7 RID: 6583
[eiz("HPSPMME")]
[Serializable]
public sealed class ba7 : cdh, ISerializable, d7s
{
	// Token: 0x06008CCB RID: 36043 RVA: 0x00391DD0 File Offset: 0x0038FFD0
	private ba7(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008CCC RID: 36044 RVA: 0x00391DDC File Offset: 0x0038FFDC
	public ba7()
	{
	}

	// Token: 0x06008CCD RID: 36045 RVA: 0x00391DE4 File Offset: 0x0038FFE4
	public override string b2()
	{
		return "Штраф на точность при Выстреле навскидку уменьшается вдвое.";
	}

	// Token: 0x06008CCE RID: 36046 RVA: 0x00391DF0 File Offset: 0x0038FFF0
	public override d3e b3()
	{
		ba7 ba = new ba7();
		this.xx(ba);
		return ba;
	}

	// Token: 0x06008CCF RID: 36047 RVA: 0x00391E0C File Offset: 0x0039000C
	public void cn(d3e A_0)
	{
	}

	// Token: 0x06008CD0 RID: 36048 RVA: 0x00391E10 File Offset: 0x00390010
	public bool co(d3e A_0)
	{
		return A_0 is ba7;
	}
}

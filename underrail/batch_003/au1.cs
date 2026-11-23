using System;
using System.Runtime.Serialization;

// Token: 0x02001AC0 RID: 6848
[eiz("LPTSE")]
[Serializable]
public sealed class au1 : els, ISerializable
{
	// Token: 0x06009475 RID: 38005 RVA: 0x003A6560 File Offset: 0x003A4760
	private au1(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetInt32("LPTSE:T");
	}

	// Token: 0x06009476 RID: 38006 RVA: 0x003A657C File Offset: 0x003A477C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("LPTSE:T", this.b);
	}

	// Token: 0x06009477 RID: 38007 RVA: 0x003A6598 File Offset: 0x003A4798
	public override bool sk()
	{
		return false;
	}

	// Token: 0x06009478 RID: 38008 RVA: 0x003A659C File Offset: 0x003A479C
	public int a()
	{
		return this.b;
	}

	// Token: 0x06009479 RID: 38009 RVA: 0x003A65A4 File Offset: 0x003A47A4
	public void a(int A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600947A RID: 38010 RVA: 0x003A65B0 File Offset: 0x003A47B0
	public au1(int A_0) : base(au1.a, "Leaking Propane Tank", ci8.c)
	{
		this.b = A_0;
		base.Duration = A_0 * 1000;
		base.TickPeriod = 1000;
		base.Icon = "Misc.0";
		base.MaxStacks = 1;
		base.Stacking = axm.b;
		this.z = "LPTSETJ";
	}

	// Token: 0x0600947B RID: 38011 RVA: 0x003A6614 File Offset: 0x003A4814
	public override string cb(ll A_0)
	{
		return string.Empty;
	}

	// Token: 0x04003918 RID: 14616
	public new static readonly string a = "leakingPropaneTank";

	// Token: 0x04003919 RID: 14617
	private int b;
}

using System;
using System.Runtime.Serialization;

// Token: 0x020004F5 RID: 1269
[eiz("MSACA")]
[Serializable]
public sealed class ep6 : esc
{
	// Token: 0x060020C3 RID: 8387 RVA: 0x000B071C File Offset: 0x000AE91C
	private ep6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("MSACA:A");
	}

	// Token: 0x060020C4 RID: 8388 RVA: 0x000B0738 File Offset: 0x000AE938
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MSACA:A", this.a);
	}

	// Token: 0x060020C5 RID: 8389 RVA: 0x000B0754 File Offset: 0x000AE954
	public int a()
	{
		return this.a;
	}

	// Token: 0x060020C6 RID: 8390 RVA: 0x000B075C File Offset: 0x000AE95C
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060020C7 RID: 8391 RVA: 0x000B0768 File Offset: 0x000AE968
	public ep6()
	{
	}

	// Token: 0x060020C8 RID: 8392 RVA: 0x000B0774 File Offset: 0x000AE974
	public override int d5(bq8 A_0, bq8 A_1)
	{
		int value = A_0.GetPrimitivePropertyValue<int>(bp5.f, new int?(0)).Value;
		A_0.set_Item(bp5.f, value + this.a);
		return 0;
	}

	// Token: 0x04001428 RID: 5160
	private int a;
}

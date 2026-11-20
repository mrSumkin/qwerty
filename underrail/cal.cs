using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000C65 RID: 3173
[eiz("DCMRPC")]
[Serializable]
public sealed class cal : dnh
{
	// Token: 0x0600475F RID: 18271 RVA: 0x001D72E8 File Offset: 0x001D54E8
	private cal(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("DCMRPC:I");
	}

	// Token: 0x06004760 RID: 18272 RVA: 0x001D7304 File Offset: 0x001D5504
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("DCMRPC:I", this.a);
	}

	// Token: 0x06004761 RID: 18273 RVA: 0x001D7320 File Offset: 0x001D5520
	public int a()
	{
		return this.a;
	}

	// Token: 0x06004762 RID: 18274 RVA: 0x001D7328 File Offset: 0x001D5528
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06004763 RID: 18275 RVA: 0x001D7334 File Offset: 0x001D5534
	public cal()
	{
	}

	// Token: 0x06004764 RID: 18276 RVA: 0x001D7340 File Offset: 0x001D5540
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		HashSet<int> classPropertyValue = A_0.GetClassPropertyValue<HashSet<int>>("loc_dc_mutagenReagentsPresent");
		return classPropertyValue != null && classPropertyValue.Contains(this.a);
	}

	// Token: 0x04001C95 RID: 7317
	private int a;
}

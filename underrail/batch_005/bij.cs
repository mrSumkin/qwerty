using System;
using System.Runtime.Serialization;

// Token: 0x020007B1 RID: 1969
[eiz("XPBLSAKLA")]
[Serializable]
public sealed class bij : esc, ISerializable
{
	// Token: 0x0600315C RID: 12636 RVA: 0x0012EEE0 File Offset: 0x0012D0E0
	private bij(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("XPBLSAKLA:L");
	}

	// Token: 0x0600315D RID: 12637 RVA: 0x0012EEFC File Offset: 0x0012D0FC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("XPBLSAKLA:L", this.a);
	}

	// Token: 0x0600315E RID: 12638 RVA: 0x0012EF18 File Offset: 0x0012D118
	public int a()
	{
		return this.a;
	}

	// Token: 0x0600315F RID: 12639 RVA: 0x0012EF20 File Offset: 0x0012D120
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06003160 RID: 12640 RVA: 0x0012EF2C File Offset: 0x0012D12C
	public override int d5(bq8 A_0, bq8 A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			int value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("global_xpbl_knowACoNR_level", new int?(0)).Value;
			if (this.a > value)
			{
				serviceOrThrow.aqu().r()["global_xpbl_knowACoNR_level"] = this.a;
			}
		}
		return 0;
	}

	// Token: 0x06003161 RID: 12641 RVA: 0x0012EFA4 File Offset: 0x0012D1A4
	public bij()
	{
	}

	// Token: 0x04001AAE RID: 6830
	private int a;
}

using System;
using System.Runtime.Serialization;

// Token: 0x02000F65 RID: 3941
[eiz("XPBLAMC")]
[Serializable]
public sealed class bz4 : dnh, ISerializable
{
	// Token: 0x06004FE5 RID: 20453 RVA: 0x0023DE58 File Offset: 0x0023C058
	private bz4(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("XPBLAMC:MBV");
	}

	// Token: 0x06004FE6 RID: 20454 RVA: 0x0023DE74 File Offset: 0x0023C074
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("XPBLAMC:MBV", this.a);
	}

	// Token: 0x06004FE7 RID: 20455 RVA: 0x0023DE90 File Offset: 0x0023C090
	public int a()
	{
		return this.a;
	}

	// Token: 0x06004FE8 RID: 20456 RVA: 0x0023DE98 File Offset: 0x0023C098
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06004FE9 RID: 20457 RVA: 0x0023DEA4 File Offset: 0x0023C0A4
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
		{
			int value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("global_xpbl_knowACoNR_level", new int?(0)).Value;
			return serviceOrThrow.aqu().v().Skills.Get<e70>().g() >= this.a - value * 10;
		}
		return false;
	}

	// Token: 0x06004FEA RID: 20458 RVA: 0x0023DF24 File Offset: 0x0023C124
	public bz4()
	{
	}

	// Token: 0x0400209C RID: 8348
	private int a;
}

using System;
using System.Runtime.Serialization;

// Token: 0x02000FD0 RID: 4048
[eiz("CASMC")]
[Serializable]
public sealed class vj : dnh, ISerializable
{
	// Token: 0x06005340 RID: 21312 RVA: 0x0024FFE0 File Offset: 0x0024E1E0
	private vj(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("CASMC:L");
	}

	// Token: 0x06005341 RID: 21313 RVA: 0x0024FFFC File Offset: 0x0024E1FC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CASMC:L", this.a);
	}

	// Token: 0x06005342 RID: 21314 RVA: 0x00250018 File Offset: 0x0024E218
	public int a()
	{
		return this.a;
	}

	// Token: 0x06005343 RID: 21315 RVA: 0x00250020 File Offset: 0x0024E220
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005344 RID: 21316 RVA: 0x0025002C File Offset: 0x0024E22C
	public vj()
	{
	}

	// Token: 0x06005345 RID: 21317 RVA: 0x00250038 File Offset: 0x0024E238
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			string text = evt.a(A_0);
			if (!string.IsNullOrWhiteSpace(text))
			{
				string name = string.Format("SpecialMerchandiseLevel_{0}", text);
				return serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>(name, new int?(-1)).Value == this.a;
			}
		}
		return false;
	}

	// Token: 0x04002202 RID: 8706
	private int a;
}

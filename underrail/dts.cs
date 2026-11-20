using System;
using System.Runtime.Serialization;

// Token: 0x020019E6 RID: 6630
[eiz("MSFE")]
[Serializable]
public abstract class dts : d3e, ISerializable
{
	// Token: 0x06008E8C RID: 36492 RVA: 0x00395A54 File Offset: 0x00393C54
	protected dts(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetInt32("MSFE:V");
			return;
		}
		if (base.GetType() == typeof(dts))
		{
			this.a = A_0.GetInt32("_Value");
			return;
		}
		this.a = A_0.GetInt32("ModifyStatFlatEffect+_Value");
	}

	// Token: 0x06008E8D RID: 36493 RVA: 0x00395AC4 File Offset: 0x00393CC4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MSFE:V", this.a);
	}

	// Token: 0x06008E8E RID: 36494 RVA: 0x00395AE0 File Offset: 0x00393CE0
	public int c()
	{
		return this.a;
	}

	// Token: 0x06008E8F RID: 36495 RVA: 0x00395AE8 File Offset: 0x00393CE8
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008E90 RID: 36496 RVA: 0x00395AF4 File Offset: 0x00393CF4
	public override bool ae5()
	{
		return this.a < 0;
	}

	// Token: 0x06008E91 RID: 36497 RVA: 0x00395B00 File Offset: 0x00393D00
	protected dts()
	{
	}

	// Token: 0x06008E92 RID: 36498 RVA: 0x00395B08 File Offset: 0x00393D08
	protected dts(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008E93 RID: 36499 RVA: 0x00395B18 File Offset: 0x00393D18
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((dts)A_0).a = this.a;
	}

	// Token: 0x040037D9 RID: 14297
	private new int a;
}

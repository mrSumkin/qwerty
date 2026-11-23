using System;
using System.Runtime.Serialization;

// Token: 0x020019BC RID: 6588
[eiz("MSPE")]
[Serializable]
public abstract class dh6 : d3e, ISerializable
{
	// Token: 0x06008D01 RID: 36097 RVA: 0x00392554 File Offset: 0x00390754
	protected dh6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetSingle("MSPE:V");
			return;
		}
		if (base.GetType() == typeof(dh6))
		{
			this.a = A_0.GetSingle("_Value");
			return;
		}
		this.a = A_0.GetSingle("ModifyStatPercentageEffect+_Value");
	}

	// Token: 0x06008D02 RID: 36098 RVA: 0x003925C4 File Offset: 0x003907C4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MSPE:V", this.a);
	}

	// Token: 0x06008D03 RID: 36099 RVA: 0x003925E0 File Offset: 0x003907E0
	public float c()
	{
		return this.a;
	}

	// Token: 0x06008D04 RID: 36100 RVA: 0x003925E8 File Offset: 0x003907E8
	public void a(float A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008D05 RID: 36101 RVA: 0x003925F4 File Offset: 0x003907F4
	public override bool ae5()
	{
		return this.a < 0f;
	}

	// Token: 0x06008D06 RID: 36102 RVA: 0x00392604 File Offset: 0x00390804
	protected dh6()
	{
	}

	// Token: 0x06008D07 RID: 36103 RVA: 0x0039260C File Offset: 0x0039080C
	protected dh6(float A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008D08 RID: 36104 RVA: 0x0039261C File Offset: 0x0039081C
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((dh6)A_0).a = this.a;
	}

	// Token: 0x040037AE RID: 14254
	private new float a;
}

using System;
using System.Runtime.Serialization;

// Token: 0x0200015F RID: 351
[eiz("SFFV")]
[Serializable]
public class z2 : ccy, ISerializable
{
	// Token: 0x060008D0 RID: 2256 RVA: 0x00024E54 File Offset: 0x00023054
	protected z2(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.b() != 0)
		{
			this.a = A_0.GetInt32("SFFV:V");
			return;
		}
		if (base.GetType() == typeof(z2))
		{
			this.a = A_0.GetInt32("_Value");
			return;
		}
		this.a = A_0.GetInt32("SetFloatFiledValue+_Value");
	}

	// Token: 0x060008D1 RID: 2257 RVA: 0x00024EC4 File Offset: 0x000230C4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SFFV:V", this.a);
	}

	// Token: 0x060008D2 RID: 2258 RVA: 0x00024EE0 File Offset: 0x000230E0
	public int a()
	{
		return this.a;
	}

	// Token: 0x060008D3 RID: 2259 RVA: 0x00024EE8 File Offset: 0x000230E8
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060008D4 RID: 2260 RVA: 0x00024EF4 File Offset: 0x000230F4
	public override int d5(bq8 A_0, bq8 A_1)
	{
		d8z.a(A_0, A_1, base.b(), this.a);
		return 1;
	}

	// Token: 0x060008D5 RID: 2261 RVA: 0x00024F10 File Offset: 0x00023110
	public override string ToString()
	{
		return string.Format("{0} = {1}", base.b(), this.a);
	}

	// Token: 0x060008D6 RID: 2262 RVA: 0x00024F30 File Offset: 0x00023130
	public z2()
	{
	}

	// Token: 0x040005C6 RID: 1478
	private int a;
}

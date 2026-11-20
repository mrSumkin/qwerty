using System;
using System.Runtime.Serialization;

// Token: 0x0200015A RID: 346
[eiz("MFFV")]
[Serializable]
public sealed class bzo : ccy, ISerializable
{
	// Token: 0x060008A6 RID: 2214 RVA: 0x000246B8 File Offset: 0x000228B8
	private bzo(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetSingle("MFFV:V");
	}

	// Token: 0x060008A7 RID: 2215 RVA: 0x000246D4 File Offset: 0x000228D4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MFFV:V", this.a);
	}

	// Token: 0x060008A8 RID: 2216 RVA: 0x000246F0 File Offset: 0x000228F0
	public float a()
	{
		return this.a;
	}

	// Token: 0x060008A9 RID: 2217 RVA: 0x000246F8 File Offset: 0x000228F8
	public void a(float A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060008AA RID: 2218 RVA: 0x00024704 File Offset: 0x00022904
	public override int d5(bq8 A_0, bq8 A_1)
	{
		object obj = d8z.a(A_0, A_1, base.b());
		float num;
		if (!(obj is float))
		{
			num = 0f;
		}
		else
		{
			num = (float)obj;
		}
		d8z.a(A_0, A_1, base.b(), num + this.a);
		return 1;
	}

	// Token: 0x060008AB RID: 2219 RVA: 0x00024758 File Offset: 0x00022958
	public override string ToString()
	{
		return string.Format("{0} += {1}", base.b(), this.a);
	}

	// Token: 0x060008AC RID: 2220 RVA: 0x00024778 File Offset: 0x00022978
	public bzo()
	{
	}

	// Token: 0x040005BD RID: 1469
	private float a;
}

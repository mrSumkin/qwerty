using System;
using System.Runtime.Serialization;

// Token: 0x02000162 RID: 354
[eiz("SSFV")]
[Serializable]
public sealed class dsl : ccy, ISerializable
{
	// Token: 0x060008E5 RID: 2277 RVA: 0x000251B8 File Offset: 0x000233B8
	private dsl(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.b() != 0)
		{
			this.a = A_0.GetString("SSFV:V");
			return;
		}
		if (base.GetType() == typeof(dsl))
		{
			this.a = A_0.GetString("_Value");
			return;
		}
		this.a = A_0.GetString("SetStringFieldValue+_Value");
	}

	// Token: 0x060008E6 RID: 2278 RVA: 0x00025228 File Offset: 0x00023428
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SSFV:V", this.a);
	}

	// Token: 0x060008E7 RID: 2279 RVA: 0x00025244 File Offset: 0x00023444
	public string a()
	{
		return this.a;
	}

	// Token: 0x060008E8 RID: 2280 RVA: 0x0002524C File Offset: 0x0002344C
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060008E9 RID: 2281 RVA: 0x00025258 File Offset: 0x00023458
	public override int d5(bq8 A_0, bq8 A_1)
	{
		d8z.a(A_0, A_1, base.b(), this.a);
		return 1;
	}

	// Token: 0x060008EA RID: 2282 RVA: 0x00025270 File Offset: 0x00023470
	public override string ToString()
	{
		return string.Format("{0} = \"{1}\"", base.b(), this.a);
	}

	// Token: 0x060008EB RID: 2283 RVA: 0x00025288 File Offset: 0x00023488
	public dsl()
	{
	}

	// Token: 0x040005C9 RID: 1481
	private string a;
}

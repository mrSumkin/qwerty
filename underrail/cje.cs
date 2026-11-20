using System;
using System.Runtime.Serialization;

// Token: 0x0200015E RID: 350
[eiz("SBFV")]
[Serializable]
public class cje : ccy, ISerializable
{
	// Token: 0x060008C9 RID: 2249 RVA: 0x00024D6C File Offset: 0x00022F6C
	protected cje(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.b() != 0)
		{
			this.a = A_0.GetBoolean("SBFV:V");
			return;
		}
		if (base.GetType() == typeof(cje))
		{
			this.a = A_0.GetBoolean("_Value");
			return;
		}
		this.a = A_0.GetBoolean("SetBoolFieldValue+_Value");
	}

	// Token: 0x060008CA RID: 2250 RVA: 0x00024DDC File Offset: 0x00022FDC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SBFV:V", this.a);
	}

	// Token: 0x060008CB RID: 2251 RVA: 0x00024DF8 File Offset: 0x00022FF8
	public bool a()
	{
		return this.a;
	}

	// Token: 0x060008CC RID: 2252 RVA: 0x00024E00 File Offset: 0x00023000
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060008CD RID: 2253 RVA: 0x00024E0C File Offset: 0x0002300C
	public override int d5(bq8 A_0, bq8 A_1)
	{
		d8z.a(A_0, A_1, base.b(), this.a);
		return 1;
	}

	// Token: 0x060008CE RID: 2254 RVA: 0x00024E28 File Offset: 0x00023028
	public override string ToString()
	{
		return string.Format("{0} = {1}", base.b(), this.a);
	}

	// Token: 0x060008CF RID: 2255 RVA: 0x00024E48 File Offset: 0x00023048
	public cje()
	{
	}

	// Token: 0x040005C5 RID: 1477
	private bool a;
}

using System;
using System.Runtime.Serialization;

// Token: 0x02000160 RID: 352
[eiz("SIFV")]
[Serializable]
public sealed class cgg : ccy, ISerializable
{
	// Token: 0x060008D7 RID: 2263 RVA: 0x00024F3C File Offset: 0x0002313C
	private cgg(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.b() != 0)
		{
			if (ell.b() >= 34)
			{
				this.a = (A_0.GetValue("SIFV:V", typeof(int?)) as int?);
				return;
			}
			this.a = new int?(A_0.GetInt32("SIFV:V"));
			return;
		}
		else
		{
			if (base.GetType() == typeof(cgg))
			{
				this.a = new int?(A_0.GetInt32("_Value"));
				return;
			}
			this.a = new int?(A_0.GetInt32("SetIntegerFieldValue+_Value"));
			return;
		}
	}

	// Token: 0x060008D8 RID: 2264 RVA: 0x00024FF8 File Offset: 0x000231F8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SIFV:V", this.a);
	}

	// Token: 0x060008D9 RID: 2265 RVA: 0x00025018 File Offset: 0x00023218
	public int? a()
	{
		return this.a;
	}

	// Token: 0x060008DA RID: 2266 RVA: 0x00025020 File Offset: 0x00023220
	public void a(int? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060008DB RID: 2267 RVA: 0x0002502C File Offset: 0x0002322C
	public override int d5(bq8 A_0, bq8 A_1)
	{
		d8z.a(A_0, A_1, base.b(), this.a);
		return 1;
	}

	// Token: 0x060008DC RID: 2268 RVA: 0x00025048 File Offset: 0x00023248
	public override string ToString()
	{
		return string.Format("{0} = {1}", base.b(), (this.a != null) ? this.a.ToString() : "null");
	}

	// Token: 0x060008DD RID: 2269 RVA: 0x00025090 File Offset: 0x00023290
	public cgg()
	{
	}

	// Token: 0x040005C7 RID: 1479
	private int? a = new int?(0);
}

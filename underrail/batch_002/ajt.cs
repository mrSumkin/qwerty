using System;
using System.Runtime.Serialization;

// Token: 0x0200015B RID: 347
[eiz("MIFV")]
[Serializable]
public sealed class ajt : ccy, ISerializable
{
	// Token: 0x060008AD RID: 2221 RVA: 0x00024780 File Offset: 0x00022980
	private ajt(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("MIFV:V");
	}

	// Token: 0x060008AE RID: 2222 RVA: 0x0002479C File Offset: 0x0002299C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MIFV:V", this.a);
	}

	// Token: 0x060008AF RID: 2223 RVA: 0x000247B8 File Offset: 0x000229B8
	public int a()
	{
		return this.a;
	}

	// Token: 0x060008B0 RID: 2224 RVA: 0x000247C0 File Offset: 0x000229C0
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060008B1 RID: 2225 RVA: 0x000247CC File Offset: 0x000229CC
	public override int d5(bq8 A_0, bq8 A_1)
	{
		object obj = d8z.a(A_0, A_1, base.b());
		int num;
		if (!(obj is int))
		{
			num = 0;
		}
		else
		{
			num = (int)obj;
		}
		d8z.a(A_0, A_1, base.b(), num + this.a);
		return 1;
	}

	// Token: 0x060008B2 RID: 2226 RVA: 0x0002481C File Offset: 0x00022A1C
	public override string ToString()
	{
		return string.Format("{0} += {1}", base.b(), this.a);
	}

	// Token: 0x060008B3 RID: 2227 RVA: 0x0002483C File Offset: 0x00022A3C
	public ajt()
	{
	}

	// Token: 0x040005BE RID: 1470
	private int a;
}

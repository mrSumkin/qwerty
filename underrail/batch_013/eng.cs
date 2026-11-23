using System;
using System.Runtime.Serialization;

// Token: 0x020004F3 RID: 1267
[eiz("R01")]
[Serializable]
public sealed class eng : esc, ISerializable
{
	// Token: 0x060020B2 RID: 8370 RVA: 0x000B0504 File Offset: 0x000AE704
	private eng(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetInt32("R01:M");
		if (ell.b() >= 545)
		{
			this.c = A_0.GetString("R02:P");
		}
	}

	// Token: 0x060020B3 RID: 8371 RVA: 0x000B0540 File Offset: 0x000AE740
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("R01:M", this.b);
		info.AddValue("R02:P", this.c);
	}

	// Token: 0x060020B4 RID: 8372 RVA: 0x000B056C File Offset: 0x000AE76C
	public int b()
	{
		return this.b;
	}

	// Token: 0x060020B5 RID: 8373 RVA: 0x000B0574 File Offset: 0x000AE774
	public void a(int A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060020B6 RID: 8374 RVA: 0x000B0580 File Offset: 0x000AE780
	public string a()
	{
		return this.c;
	}

	// Token: 0x060020B7 RID: 8375 RVA: 0x000B0588 File Offset: 0x000AE788
	public void a(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060020B8 RID: 8376 RVA: 0x000B0594 File Offset: 0x000AE794
	public eng(string A_0 = null)
	{
		this.c = A_0;
	}

	// Token: 0x060020B9 RID: 8377 RVA: 0x000B05A8 File Offset: 0x000AE7A8
	public override int d5(bq8 A_0, bq8 A_1)
	{
		if (eng.a == 2147483647)
		{
			eng.a = 0;
		}
		else
		{
			eng.a++;
		}
		string name = (!string.IsNullOrEmpty(this.c)) ? this.c : "persistedInt";
		A_1.set_Item(name, eng.a % this.b);
		return 1;
	}

	// Token: 0x04001423 RID: 5155
	private static int a;

	// Token: 0x04001424 RID: 5156
	private int b;

	// Token: 0x04001425 RID: 5157
	private string c;
}

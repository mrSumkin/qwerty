using System;
using System.Runtime.Serialization;

// Token: 0x020004F2 RID: 1266
[eiz("R05")]
[Serializable]
public sealed class a5i : esc, ISerializable
{
	// Token: 0x060020AC RID: 8364 RVA: 0x000B0484 File Offset: 0x000AE684
	private a5i(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("R05:M");
	}

	// Token: 0x060020AD RID: 8365 RVA: 0x000B04A0 File Offset: 0x000AE6A0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("R05:M", this.a);
	}

	// Token: 0x060020AE RID: 8366 RVA: 0x000B04BC File Offset: 0x000AE6BC
	public int a()
	{
		return this.a;
	}

	// Token: 0x060020AF RID: 8367 RVA: 0x000B04C4 File Offset: 0x000AE6C4
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060020B0 RID: 8368 RVA: 0x000B04D0 File Offset: 0x000AE6D0
	public a5i()
	{
	}

	// Token: 0x060020B1 RID: 8369 RVA: 0x000B04D8 File Offset: 0x000AE6D8
	public override int d5(bq8 A_0, bq8 A_1)
	{
		if (A_1 != null)
		{
			A_1.set_Item("rndInt", cuo.a.Next(this.a));
		}
		return 1;
	}

	// Token: 0x04001422 RID: 5154
	private int a;
}

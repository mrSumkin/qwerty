using System;
using System.Runtime.Serialization;

// Token: 0x020004F9 RID: 1273
[eiz("RIFPA")]
[Serializable]
public sealed class ete : esc, ISerializable
{
	// Token: 0x060020E7 RID: 8423 RVA: 0x000B0BE0 File Offset: 0x000AEDE0
	private ete(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("RIFPA:IC");
			this.b = A_0.GetInt32("RIFPA:S");
			this.c = A_0.GetBoolean("RIFPA:SG");
			return;
		}
		if (base.GetType() == typeof(ete))
		{
			this.a = A_0.GetString("_ItemCode");
			this.b = A_0.GetInt32("_Stacks");
			this.c = A_0.GetBoolean("_SearchGear");
			return;
		}
		this.a = A_0.GetString("RemoveItemFromPlayerAction+_ItemCode");
		this.b = A_0.GetInt32("RemoveItemFromPlayerAction+_Stacks");
		this.c = A_0.GetBoolean("RemoveItemFromPlayerAction+_SearchGear");
	}

	// Token: 0x060020E8 RID: 8424 RVA: 0x000B0CC4 File Offset: 0x000AEEC4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("RIFPA:IC", this.a);
		info.AddValue("RIFPA:S", this.b);
		info.AddValue("RIFPA:SG", this.c);
	}

	// Token: 0x060020E9 RID: 8425 RVA: 0x000B0D0C File Offset: 0x000AEF0C
	public string b()
	{
		return this.a;
	}

	// Token: 0x060020EA RID: 8426 RVA: 0x000B0D14 File Offset: 0x000AEF14
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060020EB RID: 8427 RVA: 0x000B0D20 File Offset: 0x000AEF20
	public int c()
	{
		return this.b;
	}

	// Token: 0x060020EC RID: 8428 RVA: 0x000B0D28 File Offset: 0x000AEF28
	public void a(int A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060020ED RID: 8429 RVA: 0x000B0D34 File Offset: 0x000AEF34
	public bool a()
	{
		return this.c;
	}

	// Token: 0x060020EE RID: 8430 RVA: 0x000B0D3C File Offset: 0x000AEF3C
	public void a(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060020EF RID: 8431 RVA: 0x000B0D48 File Offset: 0x000AEF48
	public override int d5(bq8 A_0, bq8 A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (this.a != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
		{
			coh coh = serviceOrThrow.aqu().v().a(this.a, this.b, this.c);
			if (coh != null)
			{
				a7v.a(new aub(coh));
				return 1;
			}
		}
		return 0;
	}

	// Token: 0x060020F0 RID: 8432 RVA: 0x000B0DB8 File Offset: 0x000AEFB8
	public ete()
	{
	}

	// Token: 0x04001432 RID: 5170
	private string a;

	// Token: 0x04001433 RID: 5171
	private int b = 1;

	// Token: 0x04001434 RID: 5172
	private bool c = true;
}

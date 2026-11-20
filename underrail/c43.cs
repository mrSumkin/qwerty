using System;
using System.Runtime.Serialization;

// Token: 0x0200193C RID: 6460
[eiz("ASI")]
[elw(typeof(c8d))]
[Serializable]
public sealed class c43 : eya, ISerializable
{
	// Token: 0x0600890E RID: 35086 RVA: 0x00388F58 File Offset: 0x00387158
	private c43(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			if (base.GetType() == typeof(c43))
			{
				this.a = A_0.GetString("_ArmorSuitVisualModel");
			}
			else
			{
				this.a = A_0.GetString("ArmorSuitItem+_ArmorSuitVisualModel");
			}
			this.f = true;
			return;
		}
		this.a = A_0.GetString("ASI:ASVM");
		if (ell.a() >= 117)
		{
			this.b = (A_0.GetValue("ASI:C", typeof(ai5?)) as ai5?);
		}
		if (ell.a() >= 163)
		{
			this.c = A_0.GetBoolean("ASI:O");
		}
		if (ell.a() >= 164)
		{
			this.d = A_0.GetDouble("ASI:BC");
			this.e = A_0.GetInt32("ASI:BA");
		}
		if (ell.a() >= 705)
		{
			this.f = A_0.GetBoolean("ASI:SC");
			return;
		}
		this.f = true;
	}

	// Token: 0x0600890F RID: 35087 RVA: 0x00389084 File Offset: 0x00387284
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("ASI:ASVM", this.a);
		info.AddValue("ASI:C", this.b);
		info.AddValue("ASI:O", this.c);
		info.AddValue("ASI:BC", this.d);
		info.AddValue("ASI:BA", this.e);
		info.AddValue("ASI:SC", this.f);
	}

	// Token: 0x06008910 RID: 35088 RVA: 0x00389104 File Offset: 0x00387304
	public override string tv()
	{
		return "Броня";
	}

	// Token: 0x06008911 RID: 35089 RVA: 0x0038910C File Offset: 0x0038730C
	public string e()
	{
		return this.a;
	}

	// Token: 0x06008912 RID: 35090 RVA: 0x00389114 File Offset: 0x00387314
	public new void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008913 RID: 35091 RVA: 0x00389120 File Offset: 0x00387320
	public ai5? d()
	{
		return this.b;
	}

	// Token: 0x06008914 RID: 35092 RVA: 0x00389128 File Offset: 0x00387328
	public new void a(ai5? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06008915 RID: 35093 RVA: 0x00389134 File Offset: 0x00387334
	public new bool a()
	{
		return this.c;
	}

	// Token: 0x06008916 RID: 35094 RVA: 0x0038913C File Offset: 0x0038733C
	public new void a(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06008917 RID: 35095 RVA: 0x00389148 File Offset: 0x00387348
	public double c()
	{
		return this.d;
	}

	// Token: 0x06008918 RID: 35096 RVA: 0x00389150 File Offset: 0x00387350
	public new void a(double A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06008919 RID: 35097 RVA: 0x0038915C File Offset: 0x0038735C
	public int b()
	{
		return this.e;
	}

	// Token: 0x0600891A RID: 35098 RVA: 0x00389164 File Offset: 0x00387364
	public new void a(int A_0)
	{
		this.e = A_0;
	}

	// Token: 0x0600891B RID: 35099 RVA: 0x00389170 File Offset: 0x00387370
	public c43()
	{
	}

	// Token: 0x0600891C RID: 35100 RVA: 0x00389180 File Offset: 0x00387380
	public override bk3 tw()
	{
		c43 c = new c43();
		this.ai7(c);
		return c;
	}

	// Token: 0x0600891D RID: 35101 RVA: 0x0038919C File Offset: 0x0038739C
	protected override void ai7(bk3 A_0)
	{
		base.ai7(A_0);
		c43 c = (c43)A_0;
		c.a = this.a;
		c.b = this.b;
		c.c = this.c;
		c.d = this.d;
		c.e = this.e;
		c.f = this.f;
	}

	// Token: 0x0400369E RID: 13982
	private new string a;

	// Token: 0x0400369F RID: 13983
	private ai5? b;

	// Token: 0x040036A0 RID: 13984
	private bool c;

	// Token: 0x040036A1 RID: 13985
	private double d;

	// Token: 0x040036A2 RID: 13986
	private new int e;

	// Token: 0x040036A3 RID: 13987
	public bool f = true;
}

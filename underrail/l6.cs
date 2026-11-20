using System;
using System.Runtime.Serialization;

// Token: 0x0200028D RID: 653
[eiz("CETFMA")]
[Serializable]
public sealed class l6 : dvv, ISerializable
{
	// Token: 0x06001314 RID: 4884 RVA: 0x0004F07C File Offset: 0x0004D27C
	private l6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.b() != 0)
		{
			this.a = (ar7)A_0.GetValue("CETFMA:ER", typeof(ar7));
			this.b = (x3)A_0.GetValue("CETFMA:CT", typeof(x3));
			this.c = (bjp)A_0.GetValue("CETFMA:TFM", typeof(bjp));
			return;
		}
		if (base.GetType() == typeof(l6))
		{
			this.a = (ar7)A_0.GetValue("_EntityRef", typeof(ar7));
			this.b = (x3)A_0.GetValue("_ChangeType", typeof(x3));
			this.c = (bjp)A_0.GetValue("_TileFormationModifiers", typeof(bjp));
			return;
		}
		this.a = (ar7)A_0.GetValue("ChangeEntityTileFormationModifiersAction+_EntityRef", typeof(ar7));
		this.b = (x3)A_0.GetValue("ChangeEntityTileFormationModifiersAction+_ChangeType", typeof(x3));
		this.c = (bjp)A_0.GetValue("ChangeEntityTileFormationModifiersAction+_TileFormationModifiers", typeof(bjp));
	}

	// Token: 0x06001315 RID: 4885 RVA: 0x0004F1E4 File Offset: 0x0004D3E4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CETFMA:ER", this.a);
		info.AddValue("CETFMA:CT", this.b);
		info.AddValue("CETFMA:TFM", this.c);
	}

	// Token: 0x06001316 RID: 4886 RVA: 0x0004F234 File Offset: 0x0004D434
	public ar7 b()
	{
		return this.a;
	}

	// Token: 0x06001317 RID: 4887 RVA: 0x0004F23C File Offset: 0x0004D43C
	public void a(ar7 A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06001318 RID: 4888 RVA: 0x0004F248 File Offset: 0x0004D448
	public x3 c()
	{
		return this.b;
	}

	// Token: 0x06001319 RID: 4889 RVA: 0x0004F250 File Offset: 0x0004D450
	public void a(x3 A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600131A RID: 4890 RVA: 0x0004F25C File Offset: 0x0004D45C
	public bjp a()
	{
		return this.c;
	}

	// Token: 0x0600131B RID: 4891 RVA: 0x0004F264 File Offset: 0x0004D464
	public void a(bjp A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600131C RID: 4892 RVA: 0x0004F270 File Offset: 0x0004D470
	public l6()
	{
	}

	// Token: 0x0600131D RID: 4893 RVA: 0x0004F284 File Offset: 0x0004D484
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.a == null || this.a.ao() == null || this.c == null)
		{
			return dc4.e;
		}
		if (this.b == x3.a)
		{
			this.a.ao().TileFormationModifiers = this.c;
		}
		else if (this.b == x3.b)
		{
			this.a.ao().TileFormationModifiers.c(this.c.b);
		}
		else
		{
			this.a.ao().TileFormationModifiers.b(this.c.b);
		}
		this.a.ao().z();
		return dc4.c;
	}

	// Token: 0x04000A65 RID: 2661
	private new ar7 a;

	// Token: 0x04000A66 RID: 2662
	private x3 b;

	// Token: 0x04000A67 RID: 2663
	private bjp c = new bjp();
}

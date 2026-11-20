using System;
using System.Runtime.Serialization;

// Token: 0x020004D2 RID: 1234
[eiz("SISEC")]
[Serializable]
public sealed class at5 : dnh, ISerializable
{
	// Token: 0x06001FA4 RID: 8100 RVA: 0x000ADD40 File Offset: 0x000ABF40
	private at5(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (Guid?)A_0.GetValue("SISEC:I", typeof(Guid?));
		this.b = A_0.GetString("SISEC:A");
		this.c = A_0.GetBoolean("SISEC:N");
	}

	// Token: 0x06001FA5 RID: 8101 RVA: 0x000ADD98 File Offset: 0x000ABF98
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SISEC:I", this.a);
		info.AddValue("SISEC:A", this.b);
		info.AddValue("SISEC:N", this.c);
	}

	// Token: 0x06001FA6 RID: 8102 RVA: 0x000ADDE8 File Offset: 0x000ABFE8
	public string a()
	{
		return this.b;
	}

	// Token: 0x06001FA7 RID: 8103 RVA: 0x000ADDF0 File Offset: 0x000ABFF0
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06001FA8 RID: 8104 RVA: 0x000ADDFC File Offset: 0x000ABFFC
	public Guid? b()
	{
		return this.a;
	}

	// Token: 0x06001FA9 RID: 8105 RVA: 0x000ADE04 File Offset: 0x000AC004
	public void a(Guid? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06001FAA RID: 8106 RVA: 0x000ADE10 File Offset: 0x000AC010
	public bool c()
	{
		return this.c;
	}

	// Token: 0x06001FAB RID: 8107 RVA: 0x000ADE18 File Offset: 0x000AC018
	public void a(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06001FAC RID: 8108 RVA: 0x000ADE24 File Offset: 0x000AC024
	public at5()
	{
	}

	// Token: 0x06001FAD RID: 8109 RVA: 0x000ADE2C File Offset: 0x000AC02C
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		bool flag = false;
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqw() != null)
		{
			b0b b0b = null;
			if (this.a != null)
			{
				aud aud;
				if (this.b != null)
				{
					aud = serviceOrThrow.aqw().n(this.b);
				}
				else
				{
					aud = serviceOrThrow.aqu().v().b().Area;
				}
				if (aud != null)
				{
					b0b = new ar7(this.a.Value, aud).ao();
				}
			}
			if (b0b != null && (b0b == A_0.GetPropertyValue(c49.b) as b0b || b0b == A_0.GetPropertyValue(c49.a) as b0b))
			{
				flag = true;
			}
		}
		return flag ^ this.c;
	}

	// Token: 0x040013DB RID: 5083
	private Guid? a;

	// Token: 0x040013DC RID: 5084
	private string b;

	// Token: 0x040013DD RID: 5085
	private bool c;
}

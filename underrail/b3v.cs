using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x0200103E RID: 4158
[eiz("ACRCJ")]
[Serializable]
public sealed class b3v : cze, ISerializable
{
	// Token: 0x06005603 RID: 22019 RVA: 0x0025DA4C File Offset: 0x0025BC4C
	private b3v(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = (Guid?)A_0.GetValue("ACRCJ:I", typeof(Guid?));
		this.c = A_0.GetString("ACRCJ:A");
		this.a = A_0.GetString("ACRCJ:R");
	}

	// Token: 0x06005604 RID: 22020 RVA: 0x0025DAA4 File Offset: 0x0025BCA4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("ACRCJ:I", this.b);
		info.AddValue("ACRCJ:A", this.c);
		info.AddValue("ACRCJ:R", this.a);
	}

	// Token: 0x06005605 RID: 22021 RVA: 0x0025DAF4 File Offset: 0x0025BCF4
	public string b()
	{
		return this.a;
	}

	// Token: 0x06005606 RID: 22022 RVA: 0x0025DAFC File Offset: 0x0025BCFC
	public void b(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005607 RID: 22023 RVA: 0x0025DB08 File Offset: 0x0025BD08
	public string a()
	{
		return this.c;
	}

	// Token: 0x06005608 RID: 22024 RVA: 0x0025DB10 File Offset: 0x0025BD10
	public void a(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005609 RID: 22025 RVA: 0x0025DB1C File Offset: 0x0025BD1C
	public Guid? c()
	{
		return this.b;
	}

	// Token: 0x0600560A RID: 22026 RVA: 0x0025DB24 File Offset: 0x0025BD24
	public void a(Guid? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600560B RID: 22027 RVA: 0x0025DB30 File Offset: 0x0025BD30
	public b3v()
	{
	}

	// Token: 0x0600560C RID: 22028 RVA: 0x0025DB38 File Offset: 0x0025BD38
	public sealed override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = null;
		if (this.b != null)
		{
			aud aud = cze.a(this.c, A_0, A_1, A_2);
			if (aud != null)
			{
				c5x = (new ar7(this.b.Value, aud).ao() as c5x);
			}
		}
		else
		{
			c5x = (A_1 as c5x);
		}
		if (c5x != null)
		{
			c5x.b(this.a);
		}
	}

	// Token: 0x040022F2 RID: 8946
	private new string a;

	// Token: 0x040022F3 RID: 8947
	private Guid? b;

	// Token: 0x040022F4 RID: 8948
	private string c;
}

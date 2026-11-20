using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x0200104B RID: 4171
[eiz("SEJEASJ")]
[Serializable]
public sealed class dzk : cze, ISerializable
{
	// Token: 0x06005665 RID: 22117 RVA: 0x0025EF24 File Offset: 0x0025D124
	private dzk(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = (Guid?)A_0.GetValue("SEJEASJ:I", typeof(Guid?));
		this.c = A_0.GetString("SEJEASJ:A");
		this.a = A_0.GetBoolean("SEJEASJ:E");
	}

	// Token: 0x06005666 RID: 22118 RVA: 0x0025EF7C File Offset: 0x0025D17C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SEJEASJ:I", this.b);
		info.AddValue("SEJEASJ:A", this.c);
		info.AddValue("SEJEASJ:E", this.a);
	}

	// Token: 0x06005667 RID: 22119 RVA: 0x0025EFCC File Offset: 0x0025D1CC
	public bool c()
	{
		return this.a;
	}

	// Token: 0x06005668 RID: 22120 RVA: 0x0025EFD4 File Offset: 0x0025D1D4
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005669 RID: 22121 RVA: 0x0025EFE0 File Offset: 0x0025D1E0
	public string a()
	{
		return this.c;
	}

	// Token: 0x0600566A RID: 22122 RVA: 0x0025EFE8 File Offset: 0x0025D1E8
	public void a(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600566B RID: 22123 RVA: 0x0025EFF4 File Offset: 0x0025D1F4
	public Guid? b()
	{
		return this.b;
	}

	// Token: 0x0600566C RID: 22124 RVA: 0x0025EFFC File Offset: 0x0025D1FC
	public void a(Guid? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600566D RID: 22125 RVA: 0x0025F008 File Offset: 0x0025D208
	public dzk()
	{
	}

	// Token: 0x0600566E RID: 22126 RVA: 0x0025F010 File Offset: 0x0025D210
	public sealed override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = null;
		c1a c1a = null;
		if (A_0 != null)
		{
			c1a = A_0.Zone;
		}
		if (c1a == null && A_1 != null)
		{
			c1a = A_1.Zone;
		}
		if (c1a != null)
		{
			if (this.b != null)
			{
				aud aud = null;
				if (this.c != null)
				{
					aud = c1a.n(this.c);
				}
				else if (A_1 != null)
				{
					aud = A_1.Area;
				}
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
				t6 aspect = c5x.GetAspect<t6>();
				if (aspect != null)
				{
					aspect.a(this.a);
				}
			}
		}
	}

	// Token: 0x0400230D RID: 8973
	private new bool a;

	// Token: 0x0400230E RID: 8974
	private Guid? b;

	// Token: 0x0400230F RID: 8975
	private string c;
}

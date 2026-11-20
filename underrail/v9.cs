using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010D0 RID: 4304
[eiz("SAESJ")]
[Serializable]
public sealed class v9 : cze, ISerializable
{
	// Token: 0x06005AB1 RID: 23217 RVA: 0x002719B0 File Offset: 0x0026FBB0
	private v9(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = (Guid?)A_0.GetValue("SAESJ:I", typeof(Guid?));
		this.c = A_0.GetString("SAESJ:A");
		this.a = A_0.GetBoolean("SAESJ:E");
	}

	// Token: 0x06005AB2 RID: 23218 RVA: 0x00271A08 File Offset: 0x0026FC08
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SAESJ:I", this.b);
		info.AddValue("SAESJ:A", this.c);
		info.AddValue("SAESJ:E", this.a);
	}

	// Token: 0x06005AB3 RID: 23219 RVA: 0x00271A58 File Offset: 0x0026FC58
	public bool c()
	{
		return this.a;
	}

	// Token: 0x06005AB4 RID: 23220 RVA: 0x00271A60 File Offset: 0x0026FC60
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005AB5 RID: 23221 RVA: 0x00271A6C File Offset: 0x0026FC6C
	public string a()
	{
		return this.c;
	}

	// Token: 0x06005AB6 RID: 23222 RVA: 0x00271A74 File Offset: 0x0026FC74
	public void a(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005AB7 RID: 23223 RVA: 0x00271A80 File Offset: 0x0026FC80
	public Guid? b()
	{
		return this.b;
	}

	// Token: 0x06005AB8 RID: 23224 RVA: 0x00271A88 File Offset: 0x0026FC88
	public void a(Guid? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005AB9 RID: 23225 RVA: 0x00271A94 File Offset: 0x0026FC94
	public v9()
	{
	}

	// Token: 0x06005ABA RID: 23226 RVA: 0x00271A9C File Offset: 0x0026FC9C
	public sealed override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = null;
		if (this.b != null)
		{
			aud aud = null;
			if (this.c != null)
			{
				if (A_0 != null)
				{
					aud = A_0.Zone.n(this.c);
				}
				else if (A_1 != null)
				{
					aud = A_1.Zone.n(this.c);
				}
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
			dm aspect = c5x.GetAspect<dm>();
			if (aspect != null)
			{
				aspect.b(this.a);
			}
		}
	}

	// Token: 0x0400244A RID: 9290
	private new bool a;

	// Token: 0x0400244B RID: 9291
	private Guid? b;

	// Token: 0x0400244C RID: 9292
	private string c;
}

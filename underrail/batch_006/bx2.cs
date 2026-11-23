using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x0200105E RID: 4190
[eiz("SCPRJ")]
[Serializable]
public sealed class bx2 : cze, ISerializable
{
	// Token: 0x060056F7 RID: 22263 RVA: 0x002615CC File Offset: 0x0025F7CC
	private bx2(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = (Guid?)A_0.GetValue("SCPRJ:I", typeof(Guid?));
		this.c = A_0.GetString("SCPRJ:A");
		this.a = A_0.GetString("SCPRJ:P");
	}

	// Token: 0x060056F8 RID: 22264 RVA: 0x00261624 File Offset: 0x0025F824
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SCPRJ:I", this.b);
		info.AddValue("SCPRJ:A", this.c);
		info.AddValue("SCPRJ:P", this.a);
	}

	// Token: 0x060056F9 RID: 22265 RVA: 0x00261674 File Offset: 0x0025F874
	public string b()
	{
		return this.a;
	}

	// Token: 0x060056FA RID: 22266 RVA: 0x0026167C File Offset: 0x0025F87C
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060056FB RID: 22267 RVA: 0x00261688 File Offset: 0x0025F888
	public string a()
	{
		return this.c;
	}

	// Token: 0x060056FC RID: 22268 RVA: 0x00261690 File Offset: 0x0025F890
	public void b(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060056FD RID: 22269 RVA: 0x0026169C File Offset: 0x0025F89C
	public Guid? c()
	{
		return this.b;
	}

	// Token: 0x060056FE RID: 22270 RVA: 0x002616A4 File Offset: 0x0025F8A4
	public void a(Guid? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060056FF RID: 22271 RVA: 0x002616B0 File Offset: 0x0025F8B0
	public bx2()
	{
	}

	// Token: 0x06005700 RID: 22272 RVA: 0x002616B8 File Offset: 0x0025F8B8
	public sealed override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = null;
		if (this.b != null)
		{
			aud aud = null;
			if (!string.IsNullOrWhiteSpace(this.c))
			{
				aud = cze.a(this.c, A_0, A_1, A_2);
			}
			else if (A_1 != null)
			{
				aud = A_1.Area;
			}
			else if (A_0 != null)
			{
				aud = A_0.Area;
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
			amc aspect = c5x.GetAspect<amc>();
			if (aspect != null)
			{
				aspect.aa().Portrait = this.a;
				aspect.a5();
			}
		}
	}

	// Token: 0x0400233E RID: 9022
	private new string a;

	// Token: 0x0400233F RID: 9023
	private Guid? b;

	// Token: 0x04002340 RID: 9024
	private string c;
}

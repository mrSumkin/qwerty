using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x0200108D RID: 4237
[eiz("TIFJ")]
[Serializable]
public sealed class e1u : cze
{
	// Token: 0x0600586D RID: 22637 RVA: 0x00265C90 File Offset: 0x00263E90
	private e1u(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (Guid?)A_0.GetValue("TIFJ:I", typeof(Guid?));
		this.b = A_0.GetString("TIFJ:A");
	}

	// Token: 0x0600586E RID: 22638 RVA: 0x00265CCC File Offset: 0x00263ECC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("TIFJ:I", this.a);
		info.AddValue("TIFJ:A", this.b);
	}

	// Token: 0x0600586F RID: 22639 RVA: 0x00265D00 File Offset: 0x00263F00
	public string a()
	{
		return this.b;
	}

	// Token: 0x06005870 RID: 22640 RVA: 0x00265D08 File Offset: 0x00263F08
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005871 RID: 22641 RVA: 0x00265D14 File Offset: 0x00263F14
	public Guid? b()
	{
		return this.a;
	}

	// Token: 0x06005872 RID: 22642 RVA: 0x00265D1C File Offset: 0x00263F1C
	public void a(Guid? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005873 RID: 22643 RVA: 0x00265D28 File Offset: 0x00263F28
	public e1u()
	{
	}

	// Token: 0x06005874 RID: 22644 RVA: 0x00265D30 File Offset: 0x00263F30
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = null;
		if (this.a != null)
		{
			aud aud = null;
			if (this.b != null)
			{
				aud = A_1.Zone.n(this.b);
			}
			else if (A_1 != null)
			{
				aud = A_1.Area;
			}
			if (aud != null)
			{
				c5x = (new ar7(this.a.Value, aud).ao() as c5x);
			}
		}
		else
		{
			c5x = (A_1 as c5x);
		}
		if (c5x != null)
		{
			eks eks = c5x.GetAspect<bim>() as eks;
			if (eks != null)
			{
				eks.o();
			}
		}
	}

	// Token: 0x040023A3 RID: 9123
	private new Guid? a;

	// Token: 0x040023A4 RID: 9124
	private string b;
}

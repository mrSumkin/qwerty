using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001058 RID: 4184
[eiz("PSCDJ")]
[Serializable]
public sealed class d0k : cze
{
	// Token: 0x060056DB RID: 22235 RVA: 0x00260A78 File Offset: 0x0025EC78
	private d0k(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (Guid?)A_0.GetValue("PSCDJ:I", typeof(Guid?));
		this.b = A_0.GetString("PSCDJ:A");
	}

	// Token: 0x060056DC RID: 22236 RVA: 0x00260AB4 File Offset: 0x0025ECB4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PSCDJ:I", this.a);
		info.AddValue("PSCDJ:A", this.b);
	}

	// Token: 0x060056DD RID: 22237 RVA: 0x00260AE8 File Offset: 0x0025ECE8
	public string a()
	{
		return this.b;
	}

	// Token: 0x060056DE RID: 22238 RVA: 0x00260AF0 File Offset: 0x0025ECF0
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060056DF RID: 22239 RVA: 0x00260AFC File Offset: 0x0025ECFC
	public Guid? b()
	{
		return this.a;
	}

	// Token: 0x060056E0 RID: 22240 RVA: 0x00260B04 File Offset: 0x0025ED04
	public void a(Guid? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060056E1 RID: 22241 RVA: 0x00260B10 File Offset: 0x0025ED10
	public d0k()
	{
	}

	// Token: 0x060056E2 RID: 22242 RVA: 0x00260B1C File Offset: 0x0025ED1C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = null;
		if (this.a != null)
		{
			aud aud = cze.a(this.b, A_0, A_1, A_2);
			if (aud != null)
			{
				c5x = (aud.a(this.a.Value) as c5x);
			}
		}
		else
		{
			c5x = (A_1 as c5x);
		}
		if (c5x != null)
		{
			string str;
			if (c5x.Size.Y > 1f)
			{
				str = "Y";
			}
			else
			{
				str = "X";
			}
			c5x c5x2 = vq.a("Door\\SecretCaveDoorRevealed" + str, c5x.Zone, new bt4(c5x.Area.y8(), c5x.Location), false);
			if (c5x2 != null)
			{
				c5x.w();
				c5x.an();
				c5x2.c().a("SecretCaveDoorPush");
			}
		}
	}

	// Token: 0x04002336 RID: 9014
	private new Guid? a;

	// Token: 0x04002337 RID: 9015
	private string b;
}

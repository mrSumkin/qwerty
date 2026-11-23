using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001069 RID: 4201
[eiz("SBARVJ")]
[Serializable]
public sealed class aq7 : cze, ISerializable
{
	// Token: 0x06005764 RID: 22372 RVA: 0x00262800 File Offset: 0x00260A00
	private aq7(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = (Guid?)A_0.GetValue("SBARVJ:I", typeof(Guid?));
		this.c = A_0.GetString("SBARVJ:A");
		this.a = A_0.GetInt32("SBARVJ:E");
	}

	// Token: 0x06005765 RID: 22373 RVA: 0x00262858 File Offset: 0x00260A58
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SBARVJ:I", this.b);
		info.AddValue("SBARVJ:A", this.c);
		info.AddValue("SBARVJ:E", this.a);
	}

	// Token: 0x06005766 RID: 22374 RVA: 0x002628A8 File Offset: 0x00260AA8
	public int b()
	{
		return this.a;
	}

	// Token: 0x06005767 RID: 22375 RVA: 0x002628B0 File Offset: 0x00260AB0
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005768 RID: 22376 RVA: 0x002628BC File Offset: 0x00260ABC
	public string a()
	{
		return this.c;
	}

	// Token: 0x06005769 RID: 22377 RVA: 0x002628C4 File Offset: 0x00260AC4
	public void a(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600576A RID: 22378 RVA: 0x002628D0 File Offset: 0x00260AD0
	public Guid? c()
	{
		return this.b;
	}

	// Token: 0x0600576B RID: 22379 RVA: 0x002628D8 File Offset: 0x00260AD8
	public void a(Guid? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600576C RID: 22380 RVA: 0x002628E4 File Offset: 0x00260AE4
	public aq7()
	{
	}

	// Token: 0x0600576D RID: 22381 RVA: 0x002628EC File Offset: 0x00260AEC
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
			bb2 bb = c5x.s.b as bb2;
			if (bb != null)
			{
				bb.a(this.a);
			}
		}
	}

	// Token: 0x0400235F RID: 9055
	private new int a;

	// Token: 0x04002360 RID: 9056
	private Guid? b;

	// Token: 0x04002361 RID: 9057
	private string c;
}

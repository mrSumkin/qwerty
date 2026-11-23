using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Playfield.Space;

// Token: 0x0200106C RID: 4204
[eiz("SEVDJ")]
[Serializable]
public sealed class ey : cze, ISerializable
{
	// Token: 0x0600577B RID: 22395 RVA: 0x00262C88 File Offset: 0x00260E88
	private ey(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = (Guid?)A_0.GetValue("SEVDJ:I", typeof(Guid?));
		this.c = A_0.GetString("SEVDJ:A");
		this.a = (HorizontalDirection)A_0.GetValue("SEVDJ:D", typeof(HorizontalDirection));
	}

	// Token: 0x0600577C RID: 22396 RVA: 0x00262CF0 File Offset: 0x00260EF0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SEVDJ:I", this.b);
		info.AddValue("SEVDJ:A", this.c);
		info.AddValue("SEVDJ:D", this.a);
	}

	// Token: 0x0600577D RID: 22397 RVA: 0x00262D44 File Offset: 0x00260F44
	public HorizontalDirection c()
	{
		return this.a;
	}

	// Token: 0x0600577E RID: 22398 RVA: 0x00262D4C File Offset: 0x00260F4C
	public void a(HorizontalDirection A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600577F RID: 22399 RVA: 0x00262D58 File Offset: 0x00260F58
	public string a()
	{
		return this.c;
	}

	// Token: 0x06005780 RID: 22400 RVA: 0x00262D60 File Offset: 0x00260F60
	public void a(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005781 RID: 22401 RVA: 0x00262D6C File Offset: 0x00260F6C
	public Guid? b()
	{
		return this.b;
	}

	// Token: 0x06005782 RID: 22402 RVA: 0x00262D74 File Offset: 0x00260F74
	public void a(Guid? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005783 RID: 22403 RVA: 0x00262D80 File Offset: 0x00260F80
	public ey()
	{
	}

	// Token: 0x06005784 RID: 22404 RVA: 0x00262D88 File Offset: 0x00260F88
	public ey(HorizontalDirection A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005785 RID: 22405 RVA: 0x00262D98 File Offset: 0x00260F98
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
					A_0.Zone.n(this.c);
				}
				else
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
			c5x.VisualDirection = this.a;
		}
	}

	// Token: 0x04002365 RID: 9061
	private new HorizontalDirection a;

	// Token: 0x04002366 RID: 9062
	private Guid? b;

	// Token: 0x04002367 RID: 9063
	private string c;
}

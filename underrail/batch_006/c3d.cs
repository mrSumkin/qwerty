using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x0200108E RID: 4238
[eiz("SFSJ")]
[Serializable]
public sealed class c3d : cze
{
	// Token: 0x06005875 RID: 22645 RVA: 0x00265DD0 File Offset: 0x00263FD0
	private c3d(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (Guid?)A_0.GetValue("SFSJ:I", typeof(Guid?));
		this.b = A_0.GetString("SFSJ:A");
		this.c = (A_0.GetValue("SFSJ:S", typeof(g0?)) as g0?);
		this.d = (A_0.GetValue("SFSJ:M", typeof(bool?)) as bool?);
	}

	// Token: 0x06005876 RID: 22646 RVA: 0x00265E60 File Offset: 0x00264060
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SFSJ:I", this.a);
		info.AddValue("SFSJ:A", this.b);
		info.AddValue("SFSJ:S", this.c);
		info.AddValue("SFSJ:M", this.d);
	}

	// Token: 0x06005877 RID: 22647 RVA: 0x00265EC8 File Offset: 0x002640C8
	public string b()
	{
		return this.b;
	}

	// Token: 0x06005878 RID: 22648 RVA: 0x00265ED0 File Offset: 0x002640D0
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005879 RID: 22649 RVA: 0x00265EDC File Offset: 0x002640DC
	public Guid? c()
	{
		return this.a;
	}

	// Token: 0x0600587A RID: 22650 RVA: 0x00265EE4 File Offset: 0x002640E4
	public void a(Guid? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600587B RID: 22651 RVA: 0x00265EF0 File Offset: 0x002640F0
	public bool? a()
	{
		return this.d;
	}

	// Token: 0x0600587C RID: 22652 RVA: 0x00265EF8 File Offset: 0x002640F8
	public void a(bool? A_0)
	{
		this.d = A_0;
	}

	// Token: 0x0600587D RID: 22653 RVA: 0x00265F04 File Offset: 0x00264104
	public g0? d()
	{
		return this.c;
	}

	// Token: 0x0600587E RID: 22654 RVA: 0x00265F0C File Offset: 0x0026410C
	public void a(g0? A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600587F RID: 22655 RVA: 0x00265F18 File Offset: 0x00264118
	public c3d()
	{
	}

	// Token: 0x06005880 RID: 22656 RVA: 0x00265F20 File Offset: 0x00264120
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
				if (this.c != null)
				{
					eks.a(this.c.Value);
					eks.l();
				}
				if (this.d != null)
				{
					eks.a(this.d.Value);
					eks.l();
				}
			}
		}
	}

	// Token: 0x040023A5 RID: 9125
	private new Guid? a;

	// Token: 0x040023A6 RID: 9126
	private string b;

	// Token: 0x040023A7 RID: 9127
	private g0? c;

	// Token: 0x040023A8 RID: 9128
	private bool? d;
}

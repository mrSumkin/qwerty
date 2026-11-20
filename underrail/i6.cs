using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x0200108F RID: 4239
[eiz("SCM1")]
[Serializable]
public sealed class i6 : cze, ISerializable
{
	// Token: 0x06005881 RID: 22657 RVA: 0x00266004 File Offset: 0x00264204
	private i6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("SCM1:MC");
		this.b = (Gender?)A_0.GetValue("SCM1:G", typeof(Gender?));
		this.c = (Guid?)A_0.GetValue("SCM1:ORI", typeof(Guid?));
		this.d = A_0.GetString("SCM1:A");
	}

	// Token: 0x06005882 RID: 22658 RVA: 0x0026607C File Offset: 0x0026427C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SCM1:MC", this.a);
		info.AddValue("SCM1:G", this.b);
		info.AddValue("SCM1:ORI", this.c);
		info.AddValue("SCM1:A", this.d);
	}

	// Token: 0x06005883 RID: 22659 RVA: 0x002660E0 File Offset: 0x002642E0
	public string d()
	{
		return this.a;
	}

	// Token: 0x06005884 RID: 22660 RVA: 0x002660E8 File Offset: 0x002642E8
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005885 RID: 22661 RVA: 0x002660F4 File Offset: 0x002642F4
	public Gender? c()
	{
		return this.b;
	}

	// Token: 0x06005886 RID: 22662 RVA: 0x002660FC File Offset: 0x002642FC
	public void a(Gender? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005887 RID: 22663 RVA: 0x00266108 File Offset: 0x00264308
	public Guid? a()
	{
		return this.c;
	}

	// Token: 0x06005888 RID: 22664 RVA: 0x00266110 File Offset: 0x00264310
	public void a(Guid? A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005889 RID: 22665 RVA: 0x0026611C File Offset: 0x0026431C
	public string b()
	{
		return this.d;
	}

	// Token: 0x0600588A RID: 22666 RVA: 0x00266124 File Offset: 0x00264324
	public void b(string A_0)
	{
		this.d = A_0;
	}

	// Token: 0x0600588B RID: 22667 RVA: 0x00266130 File Offset: 0x00264330
	public i6()
	{
	}

	// Token: 0x0600588C RID: 22668 RVA: 0x00266138 File Offset: 0x00264338
	public i6(string A_0, Gender? A_1, Guid? A_2, string A_3)
	{
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
		this.d = A_3;
	}

	// Token: 0x0600588D RID: 22669 RVA: 0x00266160 File Offset: 0x00264360
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = null;
		if (this.c != null)
		{
			aud aud = null;
			if (this.d != null)
			{
				aud = A_1.Zone.n(this.d);
			}
			else if (A_1 != null)
			{
				aud = A_1.Area;
			}
			if (aud != null)
			{
				c5x = (new ar7(this.c.Value, aud).ao() as c5x);
			}
		}
		else
		{
			c5x = (A_1 as c5x);
		}
		if (c5x != null && c5x.h.b != null)
		{
			c5x.h.b.a(this.a);
			if (this.b != null)
			{
				c5x.h.b.aa().Gender = this.b.Value;
			}
		}
	}

	// Token: 0x040023A9 RID: 9129
	private new string a;

	// Token: 0x040023AA RID: 9130
	private Gender? b;

	// Token: 0x040023AB RID: 9131
	private Guid? c;

	// Token: 0x040023AC RID: 9132
	private string d;
}

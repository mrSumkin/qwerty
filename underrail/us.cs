using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x0200110F RID: 4367
[eiz("DDJ")]
[Serializable]
public sealed class us : cze
{
	// Token: 0x06005CE3 RID: 23779 RVA: 0x00279EB8 File Offset: 0x002780B8
	private us(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("SYJ:T");
		this.b = (bvl)A_0.GetValue("SYJ:S", typeof(bvl));
		this.c = A_0.GetBoolean("SYJ:I");
		this.d = (A_0.GetValue("SYJ:C", typeof(Color?)) as Color?);
		this.f = (Guid?)A_0.GetValue("SYJ:OT", typeof(Guid?));
		if (ell.a() >= 587)
		{
			this.e = (A_0.GetValue("SYJ:X", typeof(Color?)) as Color?);
		}
	}

	// Token: 0x06005CE4 RID: 23780 RVA: 0x00279F90 File Offset: 0x00278190
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SYJ:T", this.a);
		info.AddValue("SYJ:S", this.b);
		info.AddValue("SYJ:I", this.c);
		info.AddValue("SYJ:C", this.d);
		info.AddValue("SYJ:OT", this.f);
		info.AddValue("SYJ:X", this.e);
	}

	// Token: 0x06005CE5 RID: 23781 RVA: 0x0027A020 File Offset: 0x00278220
	public string c()
	{
		return this.a;
	}

	// Token: 0x06005CE6 RID: 23782 RVA: 0x0027A028 File Offset: 0x00278228
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005CE7 RID: 23783 RVA: 0x0027A034 File Offset: 0x00278234
	public bool b()
	{
		return this.c;
	}

	// Token: 0x06005CE8 RID: 23784 RVA: 0x0027A03C File Offset: 0x0027823C
	public void a(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005CE9 RID: 23785 RVA: 0x0027A048 File Offset: 0x00278248
	public Color? f()
	{
		return this.d;
	}

	// Token: 0x06005CEA RID: 23786 RVA: 0x0027A050 File Offset: 0x00278250
	public void b(Color? A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06005CEB RID: 23787 RVA: 0x0027A05C File Offset: 0x0027825C
	public Color? e()
	{
		return this.e;
	}

	// Token: 0x06005CEC RID: 23788 RVA: 0x0027A064 File Offset: 0x00278264
	public void a(Color? A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06005CED RID: 23789 RVA: 0x0027A070 File Offset: 0x00278270
	public bvl d()
	{
		return this.b;
	}

	// Token: 0x06005CEE RID: 23790 RVA: 0x0027A078 File Offset: 0x00278278
	public void a(bvl A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005CEF RID: 23791 RVA: 0x0027A084 File Offset: 0x00278284
	public Guid? a()
	{
		return this.f;
	}

	// Token: 0x06005CF0 RID: 23792 RVA: 0x0027A08C File Offset: 0x0027828C
	public void a(Guid? A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06005CF1 RID: 23793 RVA: 0x0027A098 File Offset: 0x00278298
	public us()
	{
	}

	// Token: 0x06005CF2 RID: 23794 RVA: 0x0027A0A8 File Offset: 0x002782A8
	public us(string A_0, bool A_1, Color? A_2 = null, bvl A_3 = bvl.c, Guid? A_4 = null, Color? A_5 = null)
	{
		this.a = A_0;
		this.c = A_1;
		this.d = A_2;
		this.b = A_3;
		this.f = A_4;
		this.e = A_5;
	}

	// Token: 0x06005CF3 RID: 23795 RVA: 0x0027A0E4 File Offset: 0x002782E4
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		b0b b0b = null;
		if (this.f != null)
		{
			b0b = (new ar7(this.f.Value, A_0.Area).ao() as c5x);
		}
		else
		{
			switch (this.b)
			{
			case bvl.b:
				b0b = A_0;
				break;
			case bvl.c:
				b0b = A_1;
				break;
			case bvl.d:
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
				{
					b0b = serviceOrThrow.aqu().v().b();
				}
				break;
			}
			}
		}
		if (b0b != null)
		{
			c0s aspect = b0b.GetAspect<c0s>();
			if (aspect != null)
			{
				aspect.a(this.a, this.c, this.d, this.e);
			}
		}
	}

	// Token: 0x04002511 RID: 9489
	private new string a;

	// Token: 0x04002512 RID: 9490
	private bvl b = bvl.c;

	// Token: 0x04002513 RID: 9491
	private bool c;

	// Token: 0x04002514 RID: 9492
	private Color? d;

	// Token: 0x04002515 RID: 9493
	private Color? e;

	// Token: 0x04002516 RID: 9494
	private Guid? f;
}

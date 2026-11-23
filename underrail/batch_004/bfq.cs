using System;
using System.Runtime.Serialization;

// Token: 0x0200111D RID: 4381
[eiz("PLSJ")]
[Serializable]
public sealed class bfq : dty
{
	// Token: 0x06005D76 RID: 23926 RVA: 0x0027B900 File Offset: 0x00279B00
	private bfq(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() >= 15)
		{
			this.a = A_0.GetBoolean("PLSJ:SCIC");
			this.b = A_0.GetBoolean("PLSJ:SWFP");
			if (ell.a() >= 41)
			{
				this.c = A_0.GetBoolean("PLSJ:SIUP");
			}
		}
		if (ell.a() >= 593)
		{
			this.d = (ca4)A_0.GetValue("PLSJ:G", typeof(ca4));
		}
	}

	// Token: 0x06005D77 RID: 23927 RVA: 0x0027B990 File Offset: 0x00279B90
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PLSJ:SCIC", this.a);
		info.AddValue("PLSJ:SWFP", this.b);
		info.AddValue("PLSJ:SIUP", this.c);
		info.AddValue("PLSJ:G", this.d);
	}

	// Token: 0x06005D78 RID: 23928 RVA: 0x0027B9F0 File Offset: 0x00279BF0
	public bool d()
	{
		return this.a;
	}

	// Token: 0x06005D79 RID: 23929 RVA: 0x0027B9F8 File Offset: 0x00279BF8
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005D7A RID: 23930 RVA: 0x0027BA04 File Offset: 0x00279C04
	public bool c()
	{
		return this.b;
	}

	// Token: 0x06005D7B RID: 23931 RVA: 0x0027BA0C File Offset: 0x00279C0C
	public void c(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005D7C RID: 23932 RVA: 0x0027BA18 File Offset: 0x00279C18
	public bool b()
	{
		return this.c;
	}

	// Token: 0x06005D7D RID: 23933 RVA: 0x0027BA20 File Offset: 0x00279C20
	public void b(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005D7E RID: 23934 RVA: 0x0027BA2C File Offset: 0x00279C2C
	public ca4 a()
	{
		return this.d;
	}

	// Token: 0x06005D7F RID: 23935 RVA: 0x0027BA34 File Offset: 0x00279C34
	public void a(ca4 A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06005D80 RID: 23936 RVA: 0x0027BA40 File Offset: 0x00279C40
	public bfq()
	{
	}

	// Token: 0x06005D81 RID: 23937 RVA: 0x0027BA4C File Offset: 0x00279C4C
	public bfq(string A_0) : this(Guid.NewGuid().ToString(), A_0)
	{
	}

	// Token: 0x06005D82 RID: 23938 RVA: 0x0027BA74 File Offset: 0x00279C74
	public bfq(string A_0, string A_1)
	{
		base.b(A_0);
		base.c(A_1);
	}

	// Token: 0x06005D83 RID: 23939 RVA: 0x0027BA90 File Offset: 0x00279C90
	protected override void xp(c5x A_0)
	{
		if (this.c)
		{
			dt5 aspect = A_0.GetAspect<dt5>();
			if (aspect != null && (aspect.e() == null || !aspect.e().Value))
			{
				return;
			}
		}
		string text = base.n();
		ca4 ca;
		if (this.d.a)
		{
			ca = this.d;
		}
		else
		{
			ca = new ca4
			{
				a = true,
				b = base.e(),
				c = 50
			};
		}
		if (!string.IsNullOrEmpty(text))
		{
			if (ca.a)
			{
				if (!dc2.a(ca))
				{
					return;
				}
				dc2.b(ca);
			}
			if (this.a)
			{
				A_0.v.b.a(text, this.b);
			}
			if (!string.IsNullOrEmpty(base.e()))
			{
				A_0.v.b.a(text, base.e(), base.h(), base.j(), base.l(), base.i());
			}
		}
	}

	// Token: 0x0400253C RID: 9532
	private new bool a;

	// Token: 0x0400253D RID: 9533
	private bool b;

	// Token: 0x0400253E RID: 9534
	private bool c;

	// Token: 0x0400253F RID: 9535
	public ca4 d;
}

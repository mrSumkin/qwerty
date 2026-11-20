using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x0200108C RID: 4236
[eiz("TDHCJ")]
[Serializable]
public sealed class dh8 : cze
{
	// Token: 0x06005862 RID: 22626 RVA: 0x00265A88 File Offset: 0x00263C88
	private dh8(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		di7.ReadList<Guid>("TDHCJ:E", ref this.a, A_0);
		this.b = A_0.GetBoolean("TDHCJ:T");
		if (ell.a() >= 488)
		{
			this.c = (A_0.GetValue("TDHCJ:S", typeof(int?)) as int?);
		}
	}

	// Token: 0x06005863 RID: 22627 RVA: 0x00265B08 File Offset: 0x00263D08
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<Guid>("TDHCJ:E", this.a, info);
		info.AddValue("TDHCJ:T", this.b);
		info.AddValue("TDHCJ:S", this.c);
	}

	// Token: 0x06005864 RID: 22628 RVA: 0x00265B58 File Offset: 0x00263D58
	public List<Guid> c()
	{
		return this.a;
	}

	// Token: 0x06005865 RID: 22629 RVA: 0x00265B60 File Offset: 0x00263D60
	public void a(List<Guid> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005866 RID: 22630 RVA: 0x00265B6C File Offset: 0x00263D6C
	public bool a()
	{
		return this.b;
	}

	// Token: 0x06005867 RID: 22631 RVA: 0x00265B74 File Offset: 0x00263D74
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005868 RID: 22632 RVA: 0x00265B80 File Offset: 0x00263D80
	public int? b()
	{
		return this.c;
	}

	// Token: 0x06005869 RID: 22633 RVA: 0x00265B88 File Offset: 0x00263D88
	public void a(int? A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600586A RID: 22634 RVA: 0x00265B94 File Offset: 0x00263D94
	public dh8()
	{
	}

	// Token: 0x0600586B RID: 22635 RVA: 0x00265BB0 File Offset: 0x00263DB0
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		aud aud = null;
		if (A_0 != null)
		{
			aud = A_0.Area;
		}
		else if (A_1 != null)
		{
			aud = A_1.Area;
		}
		if (aud != null)
		{
			if (this.b && A_1 != null)
			{
				this.a(aud, A_1.qe());
			}
			foreach (Guid a_ in this.a)
			{
				this.a(aud, a_);
			}
		}
	}

	// Token: 0x0600586C RID: 22636 RVA: 0x00265C50 File Offset: 0x00263E50
	private void a(aud A_0, Guid A_1)
	{
		c5x c5x = new ar7(A_1, A_0).ao() as c5x;
		if (c5x != null)
		{
			dzl aspect = c5x.GetAspect<dzl>();
			if (aspect != null)
			{
				aspect.a(this.c);
			}
		}
	}

	// Token: 0x040023A0 RID: 9120
	private new List<Guid> a = new List<Guid>();

	// Token: 0x040023A1 RID: 9121
	private bool b = true;

	// Token: 0x040023A2 RID: 9122
	private int? c;
}

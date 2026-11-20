using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02000F8F RID: 3983
[a(typeof(dy8))]
[eiz("GCICEA")]
[Serializable]
public sealed class ahg : dy8
{
	// Token: 0x06005154 RID: 20820 RVA: 0x00249C78 File Offset: 0x00247E78
	private ahg(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		di7.ReadList<Guid>("GCICEA:G", ref this.a, A_0);
		di7.ReadList<Guid>("GCICEA:D", ref this.b, A_0);
		if (ell.a() >= 309)
		{
			di7.ReadList<Guid>("GCICEA:L", ref this.c, A_0);
		}
	}

	// Token: 0x06005155 RID: 20821 RVA: 0x00249CF0 File Offset: 0x00247EF0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<Guid>("GCICEA:G", this.a, info);
		di7.WriteList<Guid>("GCICEA:D", this.b, info);
		di7.WriteList<Guid>("GCICEA:L", this.c, info);
	}

	// Token: 0x06005156 RID: 20822 RVA: 0x00249D30 File Offset: 0x00247F30
	public List<Guid> a()
	{
		return this.a;
	}

	// Token: 0x06005157 RID: 20823 RVA: 0x00249D38 File Offset: 0x00247F38
	public void d(List<Guid> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005158 RID: 20824 RVA: 0x00249D44 File Offset: 0x00247F44
	public List<Guid> d()
	{
		return this.b;
	}

	// Token: 0x06005159 RID: 20825 RVA: 0x00249D4C File Offset: 0x00247F4C
	public void e(List<Guid> A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600515A RID: 20826 RVA: 0x00249D58 File Offset: 0x00247F58
	public List<Guid> b()
	{
		return this.c;
	}

	// Token: 0x0600515B RID: 20827 RVA: 0x00249D60 File Offset: 0x00247F60
	public void c(List<Guid> A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600515C RID: 20828 RVA: 0x00249D6C File Offset: 0x00247F6C
	public ahg(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x0600515D RID: 20829 RVA: 0x00249D98 File Offset: 0x00247F98
	protected override void o2()
	{
		foreach (Guid a_ in this.a)
		{
			dxv dxv = new EntityAspectReference<dxv, dxv>(base.a8().Area, a_).ao();
			if (dxv != null)
			{
				dxv.a(true);
			}
		}
		base.g(this.b);
		this.b(this.c);
	}

	// Token: 0x0600515E RID: 20830 RVA: 0x00249E28 File Offset: 0x00248028
	protected override void o3()
	{
		foreach (Guid a_ in this.a)
		{
			dxv dxv = new EntityAspectReference<dxv, dxv>(base.a8().Area, a_).ao();
			if (dxv != null)
			{
				dxv.a(false);
			}
		}
		base.h(this.b);
		this.a(this.c);
	}

	// Token: 0x0600515F RID: 20831 RVA: 0x00249EB8 File Offset: 0x002480B8
	protected override void o4()
	{
	}

	// Token: 0x06005160 RID: 20832 RVA: 0x00249EBC File Offset: 0x002480BC
	private void b(List<Guid> A_0)
	{
		foreach (Guid a_ in A_0)
		{
			c5x c5x = new ar7(a_, base.a8().Area).ao() as c5x;
			if (c5x != null)
			{
				d2b aspect = c5x.GetAspect<d2b>();
				if (aspect != null && !aspect.n())
				{
					aspect.b(true, true);
				}
			}
		}
	}

	// Token: 0x06005161 RID: 20833 RVA: 0x00249F4C File Offset: 0x0024814C
	private void a(List<Guid> A_0)
	{
		foreach (Guid a_ in A_0)
		{
			c5x c5x = new ar7(a_, base.a8().Area).ao() as c5x;
			if (c5x != null)
			{
				d2b aspect = c5x.GetAspect<d2b>();
				if (aspect != null && aspect.n())
				{
					aspect.a(true, true);
				}
			}
		}
	}

	// Token: 0x04002153 RID: 8531
	private List<Guid> a = new List<Guid>();

	// Token: 0x04002154 RID: 8532
	private List<Guid> b = new List<Guid>();

	// Token: 0x04002155 RID: 8533
	private new List<Guid> c = new List<Guid>();
}

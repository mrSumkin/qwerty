using System;

// Token: 0x02000458 RID: 1112
public abstract class afa : adt
{
	// Token: 0x06001CF7 RID: 7415 RVA: 0x000A0D60 File Offset: 0x0009EF60
	public atp e()
	{
		return atp.a;
	}

	// Token: 0x06001CF8 RID: 7416 RVA: 0x000A0D64 File Offset: 0x0009EF64
	public virtual bool rt()
	{
		return true;
	}

	// Token: 0x06001CF9 RID: 7417 RVA: 0x000A0D68 File Offset: 0x0009EF68
	public virtual bool g()
	{
		return true;
	}

	// Token: 0x06001CFA RID: 7418 RVA: 0x000A0D6C File Offset: 0x0009EF6C
	public cst d()
	{
		return this.a;
	}

	// Token: 0x06001CFB RID: 7419 RVA: 0x000A0D74 File Offset: 0x0009EF74
	public afa(string A_0) : base(A_0)
	{
	}

	// Token: 0x06001CFC RID: 7420 RVA: 0x000A0D80 File Offset: 0x0009EF80
	public override void mc(TimeSpan A_0, double A_1)
	{
		this.a = null;
	}

	// Token: 0x06001CFD RID: 7421 RVA: 0x000A0D8C File Offset: 0x0009EF8C
	public override ej1 aci(TimeSpan A_0, double A_1)
	{
		if (this.Subject.a8().i.b == null)
		{
			return ej1.c;
		}
		if (this.a == null)
		{
			this.a = this.ru(A_0, A_1);
			if (this.a != null)
			{
				if (this.rt())
				{
					this.Subject.a8().i.b.b(this.a, this.e());
				}
				return ej1.a;
			}
			return ej1.c;
		}
		else
		{
			if (this.a.State == dc4.c)
			{
				return ej1.b;
			}
			if (this.a.State == dc4.e || this.a.State == dc4.d)
			{
				return ej1.c;
			}
			return ej1.a;
		}
	}

	// Token: 0x06001CFE RID: 7422 RVA: 0x000A0E48 File Offset: 0x0009F048
	public override bool acj(TimeSpan A_0, double A_1)
	{
		return !this.g() && this.a != null && this.a.State == dc4.b;
	}

	// Token: 0x06001CFF RID: 7423 RVA: 0x000A0E78 File Offset: 0x0009F078
	public override void ack()
	{
		if (this.a != null && this.a.State == dc4.b && (this.a.kh() & m7.k) != m7.k)
		{
			this.a.j();
			this.a = null;
		}
		cst cst = this.f();
		if (cst != null)
		{
			this.Subject.a8().i.b.b(cst, atp.a);
		}
	}

	// Token: 0x06001D00 RID: 7424 RVA: 0x000A0EF8 File Offset: 0x0009F0F8
	protected virtual cst f()
	{
		return null;
	}

	// Token: 0x06001D01 RID: 7425
	protected abstract cst ru(TimeSpan A_0, double A_1);

	// Token: 0x04001004 RID: 4100
	private cst a;
}

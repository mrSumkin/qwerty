using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010E8 RID: 4328
[eiz("SLAPJ")]
[Serializable]
public sealed class bpj : cze, ISerializable
{
	// Token: 0x06005B69 RID: 23401 RVA: 0x00274844 File Offset: 0x00272A44
	private bpj(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = (Guid?)A_0.GetValue("SLAPJ:I", typeof(Guid?));
		this.c = A_0.GetString("SLAPJ:A");
		this.a = A_0.GetString("SLAPJ:D");
		if (ell.a() >= 620)
		{
			this.d = (A_0.GetValue("SLAPJ:F", typeof(bool?)) as bool?);
			this.e = A_0.GetString("SLAPJ:O");
			this.f = (A_0.GetValue("SLAPJ:C", typeof(bool?)) as bool?);
		}
	}

	// Token: 0x06005B6A RID: 23402 RVA: 0x00274908 File Offset: 0x00272B08
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SLAPJ:I", this.b);
		info.AddValue("SLAPJ:A", this.c);
		info.AddValue("SLAPJ:D", this.a);
		info.AddValue("SLAPJ:F", this.d);
		info.AddValue("SLAPJ:O", this.e);
		info.AddValue("SLAPJ:C", this.f);
	}

	// Token: 0x06005B6B RID: 23403 RVA: 0x00274994 File Offset: 0x00272B94
	public string d()
	{
		return this.a;
	}

	// Token: 0x06005B6C RID: 23404 RVA: 0x0027499C File Offset: 0x00272B9C
	public void c(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005B6D RID: 23405 RVA: 0x002749A8 File Offset: 0x00272BA8
	public string b()
	{
		return this.c;
	}

	// Token: 0x06005B6E RID: 23406 RVA: 0x002749B0 File Offset: 0x00272BB0
	public void b(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005B6F RID: 23407 RVA: 0x002749BC File Offset: 0x00272BBC
	public Guid? f()
	{
		return this.b;
	}

	// Token: 0x06005B70 RID: 23408 RVA: 0x002749C4 File Offset: 0x00272BC4
	public void a(Guid? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005B71 RID: 23409 RVA: 0x002749D0 File Offset: 0x00272BD0
	public bool? c()
	{
		return this.d;
	}

	// Token: 0x06005B72 RID: 23410 RVA: 0x002749D8 File Offset: 0x00272BD8
	public void a(bool? A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06005B73 RID: 23411 RVA: 0x002749E4 File Offset: 0x00272BE4
	public string a()
	{
		return this.e;
	}

	// Token: 0x06005B74 RID: 23412 RVA: 0x002749EC File Offset: 0x00272BEC
	public void a(string A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06005B75 RID: 23413 RVA: 0x002749F8 File Offset: 0x00272BF8
	public bool? e()
	{
		return this.f;
	}

	// Token: 0x06005B76 RID: 23414 RVA: 0x00274A00 File Offset: 0x00272C00
	public void b(bool? A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06005B77 RID: 23415 RVA: 0x00274A0C File Offset: 0x00272C0C
	public bpj()
	{
	}

	// Token: 0x06005B78 RID: 23416 RVA: 0x00274A14 File Offset: 0x00272C14
	public sealed override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = null;
		if (this.b != null)
		{
			aud aud = null;
			if (this.c != null)
			{
				b4b serviceOrThrow = bpo.GetServiceOrThrow<b4b>();
				if (serviceOrThrow.yn() != null && serviceOrThrow.yn().Zones.Count > 0)
				{
					aud = serviceOrThrow.yn().Zones[0].n(this.c);
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
			bn5 bn = c5x.GetAspect<j7>() as bn5;
			if (bn != null)
			{
				if (this.a != null)
				{
					bn.b(this.a);
				}
				if (this.d != null)
				{
					bn.a(this.d.Value);
				}
				if (this.e != null)
				{
					bn.a(this.e);
				}
				if (this.f != null)
				{
					bn.b(this.f.Value);
				}
			}
		}
	}

	// Token: 0x04002483 RID: 9347
	private new string a;

	// Token: 0x04002484 RID: 9348
	private Guid? b;

	// Token: 0x04002485 RID: 9349
	private string c;

	// Token: 0x04002486 RID: 9350
	private bool? d;

	// Token: 0x04002487 RID: 9351
	private string e;

	// Token: 0x04002488 RID: 9352
	private bool? f;
}

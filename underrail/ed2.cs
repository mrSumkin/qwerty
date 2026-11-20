using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;

// Token: 0x020012DE RID: 4830
[eiz("TA0")]
[a(typeof(b4h))]
[Serializable]
public sealed class ed2 : b4h, ISerializable
{
	// Token: 0x06006ADA RID: 27354 RVA: 0x002CFAD4 File Offset: 0x002CDCD4
	private ed2(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("TA0:A", typeof(HashSet<Guid>)) as HashSet<Guid>);
		this.c = A_0.GetInt32("TA0:D");
		this.e = (A_0.GetValue("TA0:O", typeof(EntityAspectReference<amc, amc>)) as EntityAspectReference<amc, amc>);
		this.f = A_0.GetString("TA0:F");
		this.d = A_0.GetInt32("TA0:R");
		this.g = A_0.GetString("TA0:S");
		this.h = (Color)A_0.GetValue("TA0:C", typeof(Color));
		if (ell.a() >= 176)
		{
			this.i = A_0.GetBoolean("TA0:L");
		}
		else
		{
			this.i = true;
		}
		if (ell.a() >= 445)
		{
			di7.ReadList<cze>("TA0:TJ", ref this.j, A_0);
		}
		else
		{
			this.j = new List<cze>();
		}
		if (ell.a() >= 448)
		{
			di7.ReadList<string>("TA0:AF", ref this.b, A_0);
			return;
		}
		this.b = new List<string>();
	}

	// Token: 0x06006ADB RID: 27355 RVA: 0x002CFC38 File Offset: 0x002CDE38
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("TA0:A", this.a);
		info.AddValue("TA0:D", this.c);
		info.AddValue("TA0:O", this.e);
		info.AddValue("TA0:F", this.f);
		info.AddValue("TA0:R", this.d);
		info.AddValue("TA0:S", this.g);
		info.AddValue("TA0:C", this.h);
		info.AddValue("TA0:L", this.i);
		di7.WriteList<cze>("TA0:TJ", this.j, info);
		di7.WriteList<string>("TA0:AF", this.b, info);
	}

	// Token: 0x06006ADC RID: 27356 RVA: 0x002CFCFC File Offset: 0x002CDEFC
	public amc a()
	{
		if (this.e != null)
		{
			return this.e.ao();
		}
		return null;
	}

	// Token: 0x06006ADD RID: 27357 RVA: 0x002CFD18 File Offset: 0x002CDF18
	public List<cze> d()
	{
		return this.j;
	}

	// Token: 0x06006ADE RID: 27358 RVA: 0x002CFD20 File Offset: 0x002CDF20
	public void a(List<cze> A_0)
	{
		this.j = A_0;
	}

	// Token: 0x06006ADF RID: 27359 RVA: 0x002CFD2C File Offset: 0x002CDF2C
	public List<string> b()
	{
		return this.b;
	}

	// Token: 0x06006AE0 RID: 27360 RVA: 0x002CFD34 File Offset: 0x002CDF34
	public void a(List<string> A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006AE1 RID: 27361 RVA: 0x002CFD40 File Offset: 0x002CDF40
	public ed2(c5x A_0, amc A_1) : base(A_0)
	{
		if (A_1 != null)
		{
			this.e = new EntityAspectReference<amc, amc>(A_1);
			this.f = A_1.aa().FactionId;
		}
	}

	// Token: 0x06006AE2 RID: 27362 RVA: 0x002CFD98 File Offset: 0x002CDF98
	public ed2(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006AE3 RID: 27363 RVA: 0x002CFDC4 File Offset: 0x002CDFC4
	public cos e()
	{
		if (base.a8() != null && base.a8().Area != null && base.a8().l.Count > 0)
		{
			List<ya> list = base.a8().l[0].a(typeof(cos));
			if (list != null)
			{
				foreach (cos cos in Enumerable.OfType<cos>(list))
				{
					if (cos.TrapEntity == base.a8())
					{
						return cos;
					}
				}
			}
		}
		return null;
	}

	// Token: 0x06006AE4 RID: 27364 RVA: 0x002CFE88 File Offset: 0x002CE088
	public void f()
	{
		cos cos = this.e();
		if (cos != null)
		{
			cos.o();
		}
	}

	// Token: 0x06006AE5 RID: 27365 RVA: 0x002CFEAC File Offset: 0x002CE0AC
	public void a(c5x A_0)
	{
		foreach (cze cze in this.j)
		{
			cze.ym(A_0, base.a8(), null);
		}
	}

	// Token: 0x04002BE1 RID: 11233
	public new HashSet<Guid> a = new HashSet<Guid>();

	// Token: 0x04002BE2 RID: 11234
	public List<string> b = new List<string>();

	// Token: 0x04002BE3 RID: 11235
	public int c;

	// Token: 0x04002BE4 RID: 11236
	public int d;

	// Token: 0x04002BE5 RID: 11237
	public EntityAspectReference<amc, amc> e;

	// Token: 0x04002BE6 RID: 11238
	public string f;

	// Token: 0x04002BE7 RID: 11239
	public string g;

	// Token: 0x04002BE8 RID: 11240
	public Color h;

	// Token: 0x04002BE9 RID: 11241
	public bool i;

	// Token: 0x04002BEA RID: 11242
	private List<cze> j = new List<cze>();
}

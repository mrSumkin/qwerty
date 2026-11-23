using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x0200105F RID: 4191
[eiz("RCPJ")]
[Serializable]
public sealed class hx : cze, ISerializable
{
	// Token: 0x06005701 RID: 22273 RVA: 0x00261774 File Offset: 0x0025F974
	private hx(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (Guid?)A_0.GetValue("RCPJ:I", typeof(Guid?));
		this.b = A_0.GetString("RCPJ:A");
		di7.ReadList<string>("RCPJ:P", ref this.c, A_0);
	}

	// Token: 0x06005702 RID: 22274 RVA: 0x002617D8 File Offset: 0x0025F9D8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("RCPJ:I", this.a);
		info.AddValue("RCPJ:A", this.b);
		di7.WriteList<string>("RCPJ:P", this.c, info);
	}

	// Token: 0x06005703 RID: 22275 RVA: 0x00261828 File Offset: 0x0025FA28
	public string b()
	{
		return this.b;
	}

	// Token: 0x06005704 RID: 22276 RVA: 0x00261830 File Offset: 0x0025FA30
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005705 RID: 22277 RVA: 0x0026183C File Offset: 0x0025FA3C
	public Guid? c()
	{
		return this.a;
	}

	// Token: 0x06005706 RID: 22278 RVA: 0x00261844 File Offset: 0x0025FA44
	public void a(Guid? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005707 RID: 22279 RVA: 0x00261850 File Offset: 0x0025FA50
	public List<string> a()
	{
		return this.c;
	}

	// Token: 0x06005708 RID: 22280 RVA: 0x00261858 File Offset: 0x0025FA58
	public void a(List<string> A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005709 RID: 22281 RVA: 0x00261864 File Offset: 0x0025FA64
	public hx()
	{
	}

	// Token: 0x0600570A RID: 22282 RVA: 0x00261878 File Offset: 0x0025FA78
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = null;
		if (this.a != null)
		{
			aud aud = null;
			if (this.b != null)
			{
				b4b serviceOrThrow = bpo.GetServiceOrThrow<b4b>();
				if (serviceOrThrow.yn() != null && serviceOrThrow.yn().Zones.Count > 0)
				{
					aud = serviceOrThrow.yn().Zones[0].n(this.b);
				}
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
			bm6 aspect = c5x.GetAspect<bm6>();
			if (aspect != null)
			{
				foreach (string name in this.c)
				{
					aspect.y6().RemoveProperty(name);
				}
			}
		}
	}

	// Token: 0x04002341 RID: 9025
	private new Guid? a;

	// Token: 0x04002342 RID: 9026
	private string b;

	// Token: 0x04002343 RID: 9027
	private List<string> c = new List<string>();
}

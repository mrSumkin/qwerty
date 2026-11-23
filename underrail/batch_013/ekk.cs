using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;

// Token: 0x020010DF RID: 4319
[eiz("SCPJ")]
[Serializable]
public sealed class ekk : cze, ISerializable
{
	// Token: 0x06005B0E RID: 23310 RVA: 0x00272FC0 File Offset: 0x002711C0
	private ekk(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.c = (A_0.GetValue("SCPJ:P", typeof(PropertyCollection)) as PropertyCollection);
		if (ell.a() >= 254)
		{
			this.a = (Guid?)A_0.GetValue("SCPJ:I", typeof(Guid?));
			this.b = A_0.GetString("SCPJ:A");
		}
	}

	// Token: 0x06005B0F RID: 23311 RVA: 0x00273040 File Offset: 0x00271240
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SCPJ:P", this.c);
		info.AddValue("SCPJ:I", this.a);
		info.AddValue("SCPJ:A", this.b);
	}

	// Token: 0x06005B10 RID: 23312 RVA: 0x00273090 File Offset: 0x00271290
	public string b()
	{
		return this.b;
	}

	// Token: 0x06005B11 RID: 23313 RVA: 0x00273098 File Offset: 0x00271298
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005B12 RID: 23314 RVA: 0x002730A4 File Offset: 0x002712A4
	public Guid? c()
	{
		return this.a;
	}

	// Token: 0x06005B13 RID: 23315 RVA: 0x002730AC File Offset: 0x002712AC
	public void a(Guid? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005B14 RID: 23316 RVA: 0x002730B8 File Offset: 0x002712B8
	public PropertyCollection a()
	{
		return this.c;
	}

	// Token: 0x06005B15 RID: 23317 RVA: 0x002730C0 File Offset: 0x002712C0
	public void a(PropertyCollection A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005B16 RID: 23318 RVA: 0x002730CC File Offset: 0x002712CC
	public ekk()
	{
	}

	// Token: 0x06005B17 RID: 23319 RVA: 0x002730E0 File Offset: 0x002712E0
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
				foreach (Property property in this.c.Properties)
				{
					aspect.y6()[property.Name] = property.Value;
				}
			}
		}
	}

	// Token: 0x04002464 RID: 9316
	private new Guid? a;

	// Token: 0x04002465 RID: 9317
	private string b;

	// Token: 0x04002466 RID: 9318
	private PropertyCollection c = new PropertyCollection();
}

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;

// Token: 0x02001045 RID: 4165
[eiz("STPJ")]
[Serializable]
public sealed class b3z : cze, ISerializable
{
	// Token: 0x0600563E RID: 22078 RVA: 0x0025E7F0 File Offset: 0x0025C9F0
	private b3z(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.c = (A_0.GetValue("STPJ:P", typeof(PropertyCollection)) as PropertyCollection);
		if (ell.a() >= 254)
		{
			this.a = (Guid?)A_0.GetValue("STPJ:I", typeof(Guid?));
			this.b = A_0.GetString("STPJ:A");
		}
	}

	// Token: 0x0600563F RID: 22079 RVA: 0x0025E870 File Offset: 0x0025CA70
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("STPJ:P", this.c);
		info.AddValue("STPJ:I", this.a);
		info.AddValue("STPJ:A", this.b);
	}

	// Token: 0x06005640 RID: 22080 RVA: 0x0025E8C0 File Offset: 0x0025CAC0
	public string b()
	{
		return this.b;
	}

	// Token: 0x06005641 RID: 22081 RVA: 0x0025E8C8 File Offset: 0x0025CAC8
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005642 RID: 22082 RVA: 0x0025E8D4 File Offset: 0x0025CAD4
	public Guid? c()
	{
		return this.a;
	}

	// Token: 0x06005643 RID: 22083 RVA: 0x0025E8DC File Offset: 0x0025CADC
	public void a(Guid? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005644 RID: 22084 RVA: 0x0025E8E8 File Offset: 0x0025CAE8
	public PropertyCollection a()
	{
		return this.c;
	}

	// Token: 0x06005645 RID: 22085 RVA: 0x0025E8F0 File Offset: 0x0025CAF0
	public void a(PropertyCollection A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005646 RID: 22086 RVA: 0x0025E8FC File Offset: 0x0025CAFC
	public b3z()
	{
	}

	// Token: 0x06005647 RID: 22087 RVA: 0x0025E910 File Offset: 0x0025CB10
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
					aspect.ad()[property.Name] = property.Value;
				}
			}
		}
	}

	// Token: 0x04002304 RID: 8964
	private new Guid? a;

	// Token: 0x04002305 RID: 8965
	private string b;

	// Token: 0x04002306 RID: 8966
	private PropertyCollection c = new PropertyCollection();
}

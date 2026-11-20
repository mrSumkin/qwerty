using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;

// Token: 0x0200106D RID: 4205
[eiz("SCCPJ")]
[Serializable]
public sealed class afw : cze, ISerializable
{
	// Token: 0x06005786 RID: 22406 RVA: 0x00262E48 File Offset: 0x00261048
	private afw(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.c = (A_0.GetValue("SCCPJ:P", typeof(PropertyCollection)) as PropertyCollection);
		this.a = (Guid?)A_0.GetValue("SCCPJ:I", typeof(Guid?));
		this.b = A_0.GetString("SCCPJ:A");
	}

	// Token: 0x06005787 RID: 22407 RVA: 0x00262EBC File Offset: 0x002610BC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SCCPJ:P", this.c);
		info.AddValue("SCCPJ:I", this.a);
		info.AddValue("SCCPJ:A", this.b);
	}

	// Token: 0x06005788 RID: 22408 RVA: 0x00262F0C File Offset: 0x0026110C
	public string b()
	{
		return this.b;
	}

	// Token: 0x06005789 RID: 22409 RVA: 0x00262F14 File Offset: 0x00261114
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600578A RID: 22410 RVA: 0x00262F20 File Offset: 0x00261120
	public Guid? c()
	{
		return this.a;
	}

	// Token: 0x0600578B RID: 22411 RVA: 0x00262F28 File Offset: 0x00261128
	public void a(Guid? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600578C RID: 22412 RVA: 0x00262F34 File Offset: 0x00261134
	public PropertyCollection a()
	{
		return this.c;
	}

	// Token: 0x0600578D RID: 22413 RVA: 0x00262F3C File Offset: 0x0026113C
	public void a(PropertyCollection A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600578E RID: 22414 RVA: 0x00262F48 File Offset: 0x00261148
	public afw()
	{
	}

	// Token: 0x0600578F RID: 22415 RVA: 0x00262F5C File Offset: 0x0026115C
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
			amc aspect = c5x.GetAspect<amc>();
			if (aspect != null)
			{
				foreach (Property property in this.c.Properties)
				{
					aspect.aa().CustomProperties[property.Name] = property.Value;
				}
			}
		}
	}

	// Token: 0x04002368 RID: 9064
	private new Guid? a;

	// Token: 0x04002369 RID: 9065
	private string b;

	// Token: 0x0400236A RID: 9066
	private PropertyCollection c = new PropertyCollection();
}
